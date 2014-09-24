#!/bin/bash

platform='anycpu'
monopath='/usr/local/lib/mono/4.0/'
fscorepath='/usr/local/lib/mono/4.0/'

MCS='mcs'
MCSFLAGS="-debug+ -optimize+ -platform:$platform -target:library -warn:4 -warnaserror -fullpaths"
MCSSOURCES="IronJS.Runtime/ArgumentsLinkArray.cs \
		IronJS.Runtime/BoxedValue.cs \
		IronJS.Runtime/BoxFields.cs \
		IronJS.Runtime/Caches.cs \
		IronJS.Runtime/DefaultValueHint.cs \
		IronJS.Runtime/Delegates.cs \
		IronJS.Runtime/Descriptor.cs \
		IronJS.Runtime/DescriptorAttrs.cs \
		IronJS.Runtime/Environment.cs \
		IronJS.Runtime/Errors.cs \
		IronJS.Runtime/FunctionMetaData.cs \
		IronJS.Runtime/FunctionType.cs \
		IronJS.Runtime/Jumps.cs \
		IronJS.Runtime/Legacy.cs \
		IronJS.Runtime/MarshalModes.cs \
		IronJS.Runtime/Objects/ArgumentsObject.cs \
		IronJS.Runtime/Objects/ArrayObject.cs \
		IronJS.Runtime/Objects/BooleanObject.cs \
		IronJS.Runtime/Objects/CommonObject.cs \
		IronJS.Runtime/Objects/DateObject.cs \
		IronJS.Runtime/Objects/ErrorObject.cs \
		IronJS.Runtime/Objects/FunctionObject.cs \
		IronJS.Runtime/Objects/HostFunctionObject.cs \
		IronJS.Runtime/Objects/MathObject.cs \
		IronJS.Runtime/Objects/NumberObject.cs \
		IronJS.Runtime/Objects/RegExpObject.cs \
		IronJS.Runtime/Objects/StringObject.cs \
		IronJS.Runtime/Objects/ValueObject.cs \
		IronJS.Runtime/Operators.cs \
		IronJS.Runtime/ParameterStorageType.cs \
		IronJS.Runtime/ParamsMode.cs \
		IronJS.Runtime/Properties/AssemblyInfo.cs \
		IronJS.Runtime/Schema.cs \
		IronJS.Runtime/SplayTree.cs \
		IronJS.Runtime/SuffixString.cs \
		IronJS.Runtime/TaggedBools.cs \
		IronJS.Runtime/TypeConverter.cs \
		IronJS.Runtime/TypeTags.cs \
		IronJS.Runtime/Undefined.cs"

FSC='fsc'
FSCFLAGS="--debug:pdbonly --noframework --optimize+ --platform:$platform --target:library --warn:4 --warnaserror:76 --vserrors --LCID:1033 --utf8output --fullpaths --flaterrors"
FSCSOURCES="IronJS/AssemblyInfo.fs \
		IronJS/FSharp.fs \
		IronJS/Dlr.fs \
		IronJS/Support.fs \
		IronJS/Error.fs \
		IronJS/Runtime.fs \
		IronJS/Runtime.Binders.fs \
		IronJS/Helpers.fs \
		IronJS/Operators.fs \
		IronJS/InlineCaches.fs \
		IronJS/Compiler.Ast.fs \
		IronJS/Compiler.Lexer.fs \
		IronJS/Compiler.Parser.fs \
		IronJS/Compiler.Analyzer.fs \
		IronJS/Compiler.Context.fs \
		IronJS/Compiler.Utils.fs \
		IronJS/Compiler.HostFunction.fs \
		IronJS/Compiler.Object.fs \
		IronJS/Compiler.Identifier.fs \
		IronJS/Compiler.Function.fs \
		IronJS/Compiler.Exception.fs \
		IronJS/Compiler.Operators.fs \
		IronJS/Compiler.ControlFlow.fs \
		IronJS/Compiler.Scope.fs \
		IronJS/Compiler.Core.fs \
		IronJS/Native.Utils.fs \
		IronJS/Native.Global.fs \
		IronJS/Native.Math.fs \
		IronJS/Native.Object.fs \
		IronJS/Native.Function.fs \
		IronJS/Native.Array.fs \
		IronJS/Native.RegExp.fs \
		IronJS/Native.String.fs \
		IronJS/Native.Number.fs \
		IronJS/Native.Date.fs \
		IronJS/Native.Boolean.fs \
		IronJS/Native.Error.fs \
		IronJS/Hosting.fs"

$MCS -out:IronJS.Runtime.dll -r:$fscorepath/FSharp.Core.dll -r:$monopath/System.Numerics.dll $MCSFLAGS $MCSSOURCES
$FSC -o:IronJS.dll -r:IronJS.Runtime.dll -r:$fscorepath/FSharp.Core.dll -r:$monopath/mscorlib.dll -r:$monopath/System.Core.dll -r:$monopath/System.dll -r:$monopath/System.Numerics.dll $FSCFLAGS $FSCSOURCES

