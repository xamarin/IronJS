﻿using System;
using System.Text;
using Antlr.Runtime.Tree;
using AstUtils = Microsoft.Scripting.Ast.Utils;
using Et = System.Linq.Expressions.Expression;

namespace IronJS.Compiler.Ast
{
    // 12.6.3
    public class ForStepNode : LoopNode
    {
        public INode Setup { get; protected set; }
        public INode Test { get; protected set; }
        public INode Incr { get; protected set; }
        public INode Body { get; protected set; }

        public ForStepNode(INode setup, INode test, INode incr, INode body, ITree node)
            : base(NodeType.ForStep, node)
        {
            Setup = setup;
            Test = test;
            Incr = incr;
            Body = body;
        }

        public override INode Analyze(FuncNode astopt)
        {
            if (Setup != null)
                Setup = Setup.Analyze(astopt);

            if(Test != null)
                Test = Test.Analyze(astopt);

            if (Incr != null)
                Incr = Incr.Analyze(astopt);

            if (Body != null)
                Body = Body.Analyze(astopt);

            return this;
        }

        public override void Print(StringBuilder writer, int indent = 0)
        {
            var indentStr = new String(' ', indent * 2);

            writer.AppendLine(indentStr + "(" + NodeType);

            Setup.Print(writer, indent + 1);
            Test.Print(writer, indent + 1);
            Incr.Print(writer, indent + 1);
            Body.Print(writer, indent + 1);

            writer.AppendLine(indentStr + ")");
        }
    }
}
