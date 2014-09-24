#!/bin/bash

MCS='mcs'
MCSFLAGS='-debug+ -fullpaths -optimize+'
MCSSOURCES='SunSpiderTestSuite.cs TestSuite.cs TestResult.cs V8BenchMarkTestSuite.cs Program.cs'

DISABLEQUESTIONS=1

if [[ "$DISABLEQUESTIONS" == "1" ]]; then
	$MCS -d:DISABLE_QUESTIONS -out:Program.exe -r:../IronJS.dll -r:../IronJS.Runtime.dll $MCSFLAGS $MCSSOURCES
else
	$MCS -out:Program.exe -r:../IronJS.dll -r:../IronJS.Runtime.dll $MCSFLAGS $MCSSOURCES
fi
