﻿namespace IronJS.Compiler

open IronJS
open IronJS.Aliases
open IronJS.Tools
open IronJS.Compiler

module UnaryOp =

  let private buildPreInc (ctx:Context) (target:Ast.Node) = 
    let expr = ctx.Builder ctx target
    if expr.Type = typeof<int> then
      Dlr.Expr.blockTmp expr.Type (fun tmp -> 
      [
        (Dlr.Expr.assign tmp expr)
        (Assign.build ctx target (Ast.Quote(Dlr.Expr.Math.add tmp Dlr.Expr.Math.int1)))
        (tmp)
      ])
    else
      failwith "Not supported"
  
  let build (ctx:Context) op target =
    match op with
    | Ast.PreInc -> buildPreInc ctx target
    | _ -> failwith "not supported"
