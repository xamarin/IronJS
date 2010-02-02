﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using Antlr.Runtime.Tree;
using IronJS.Compiler.Optimizer;
using IronJS.Runtime;
using IronJS.Runtime.Js;
using IronJS.Extensions;
using Et = System.Linq.Expressions.Expression;
using System.Linq.Expressions;

namespace IronJS.Compiler.Ast
{
    public class FuncNode : Node
    {
        public FuncNode Parent { get; protected set; }
        public IdentifierNode Name { get; protected set; }
        public List<IdentifierNode> Parameters { get; protected set; }
        public HashSet<IjsVarInfo> ClosesOver { get; protected set; }
        public INode Body { get; protected set; }
        public List<IdentifierNode> Locals { get; protected set; }
        public HashSet<INode> Returns { get; protected set; }
        public LabelTarget ReturnLabel { get; protected set; }

        public bool IsNamed { get { return !IsLambda; } }
        public bool IsLambda { get { return Name == null; } }

        public bool IsBranched { get; set; }
        public bool IsSimple { get { return !IsBranched; } }

        public bool IsGlobalScope { get; protected set; }
        public bool IsNotGlobalScope { get { return !IsGlobalScope; } }

        public FuncNode(IdentifierNode name, List<IdentifierNode> parameters, INode body, ITree node)
            : base(NodeType.Func, node)
        {
            Body = body;
            Name = name;
            Parameters = parameters;
            Locals = new List<IdentifierNode>();

            if (IsNamed)
                Name.IsDefinition = true;
        }

        public override Type ExprType
        {
            get
            {
                return IjsTypes.Object;
            }
        }

        public Type ReturnType
        {
            get
            {
                if (IsSimple)
                    return Returns.EvalType();

                return IjsTypes.Dynamic;
            }
        }

        public INode Analyze()
        {
            return Analyze(this);
        }

        public override INode Analyze(FuncNode func)
        {
            Parent = func;

            if (IsNamed)
            {
                Name.Analyze(func);
                Name.VarInfo.AssignedFrom.Add(this);
            }

            foreach (var param in Parameters)
            {
                param.Analyze(this);
                param.VarInfo.IsParameter = true;
            }

            Body = Body.Analyze(this);

            return this;
        }

        public override void Print(StringBuilder writer, int indent = 0)
        {
            var indentStr = new String(' ', indent * 2);
            var indentStr2 = new String(' ', (indent + 1) * 2);
            var indentStr3 = new String(' ', (indent + 3) * 2);

            writer.AppendLine(indentStr 
                + "(" + NodeType 
                + (" " + Name + " ").TrimEnd() 
                + " " + ReturnType.ShortName()
            );

            if (ClosesOver.Count > 0)
            {
                writer.AppendLine(indentStr2 + "(Closure");

                foreach (var id in ClosesOver)
                    writer.AppendLine(indentStr3 + "(" + id.Name + ")");

                writer.AppendLine(indentStr2 + ")");
            }

            writer.Append(indentStr2 + "(Args");

            foreach (var node in Parameters)
                writer.Append(" " + node);

            writer.AppendLine(")");
            Body.Print(writer, indent + 1);
            writer.AppendLine(indentStr + ")");
        }

        public static FuncNode CreateGlobal(List<INode> body)
        {
            return new FuncNode(
                null, 
                new List<IdentifierNode>(), 
                new BlockNode(body, null), 
                null
            ) { IsGlobalScope = true };
        }
    }
}
