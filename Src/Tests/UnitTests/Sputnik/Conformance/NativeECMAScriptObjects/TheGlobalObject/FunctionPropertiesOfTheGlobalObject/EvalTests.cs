// <auto-generated />
namespace IronJS.Tests.UnitTests.Sputnik.Conformance.NativeECMAScriptObjects.TheGlobalObject.FunctionPropertiesOfTheGlobalObject
{
    using System;
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    [TestClass]
    public class EvalTests : SputnikTestFixture
    {
        public EvalTests()
            : base(@"Conformance\15_Native_ECMA_Script_Objects\15.1_The_Global_Object\15.1.2_Function_Properties_of_the_Global_Object\15.1.2.1_eval")
        {
        }

        [TestMethod]
        [TestCategory("Sputnik Conformance")]
        [TestCategory("ECMA 15.1.2.1")]
        [Description("If x is not a string value, return x")]
        public void S15_1_2_1_A1_1_T1()
        {
            RunFile(@"S15.1.2.1_A1.1_T1.js");
        }

        [TestMethod]
        [TestCategory("Sputnik Conformance")]
        [TestCategory("ECMA 15.1.2.1")]
        [Description("If x is not a string value, return x")]
        public void S15_1_2_1_A1_1_T2()
        {
            RunFile(@"S15.1.2.1_A1.1_T2.js");
        }

        [TestMethod]
        [TestCategory("Sputnik Conformance")]
        [TestCategory("ECMA 15.1.2.1")]
        [Description("If the eval function is called with some argument, then use a first argument")]
        public void S15_1_2_1_A1_2_T1()
        {
            RunFile(@"S15.1.2.1_A1.2_T1.js");
        }

        [TestMethod]
        [TestCategory("Sputnik Conformance")]
        [TestCategory("ECMA 15.1.2.1")]
        [TestCategory("ECMA 16")]
        [Description("If the parse fails, throw a SyntaxError exception (but see also clause 16)")]
        public void S15_1_2_1_A2_T1()
        {
            RunFile(@"S15.1.2.1_A2_T1.js");
        }

        [TestMethod]
        [TestCategory("Sputnik Conformance")]
        [TestCategory("ECMA 15.1.2.1")]
        [TestCategory("ECMA 16")]
        [Description("If the parse fails, throw a SyntaxError exception (but see also clause 16)")]
        public void S15_1_2_1_A2_T2()
        {
            RunFile_ExpectException(@"S15.1.2.1_A2_T2.js");
        }

        [TestMethod]
        [TestCategory("Sputnik Conformance")]
        [TestCategory("ECMA 15.1.2.1")]
        [TestCategory("ECMA 12.4")]
        [Description("If Result(3).type is normal and its completion value is a value V, then return the value V")]
        public void S15_1_2_1_A3_1_T1()
        {
            RunFile(@"S15.1.2.1_A3.1_T1.js");
        }

        [TestMethod]
        [TestCategory("Sputnik Conformance")]
        [TestCategory("ECMA 15.1.2.1")]
        [TestCategory("ECMA 12.4")]
        [Description("If Result(3).type is normal and its completion value is a value V, then return the value V")]
        public void S15_1_2_1_A3_1_T2()
        {
            RunFile(@"S15.1.2.1_A3.1_T2.js");
        }

        [TestMethod]
        [TestCategory("Sputnik Conformance")]
        [TestCategory("ECMA 15.1.2.1")]
        [TestCategory("ECMA 12.1")]
        [Description("If Result(3).type is normal and its completion value is empty, then return the value undefined")]
        public void S15_1_2_1_A3_2_T1()
        {
            RunFile(@"S15.1.2.1_A3.2_T1.js");
        }

        [TestMethod]
        [TestCategory("Sputnik Conformance")]
        [TestCategory("ECMA 15.1.2.1")]
        [TestCategory("ECMA 12.2")]
        [Description("If Result(3).type is normal and its completion value is empty, then return the value undefined")]
        public void S15_1_2_1_A3_2_T2()
        {
            RunFile(@"S15.1.2.1_A3.2_T2.js");
        }

        [TestMethod]
        [TestCategory("Sputnik Conformance")]
        [TestCategory("ECMA 15.1.2.1")]
        [TestCategory("ECMA 12.3")]
        [Description("If Result(3).type is normal and its completion value is empty, then return the value undefined")]
        public void S15_1_2_1_A3_2_T3()
        {
            RunFile(@"S15.1.2.1_A3.2_T3.js");
        }

        [TestMethod]
        [TestCategory("Sputnik Conformance")]
        [TestCategory("ECMA 15.1.2.1")]
        [TestCategory("ECMA 12.5")]
        [Description("If Result(3).type is normal and its completion value is empty, then return the value undefined")]
        public void S15_1_2_1_A3_2_T4()
        {
            RunFile(@"S15.1.2.1_A3.2_T4.js");
        }

        [TestMethod]
        [TestCategory("Sputnik Conformance")]
        [TestCategory("ECMA 15.1.2.1")]
        [TestCategory("ECMA 12.11")]
        [Description("If Result(3).type is normal and its completion value is empty, then return the value undefined")]
        public void S15_1_2_1_A3_2_T5()
        {
            RunFile(@"S15.1.2.1_A3.2_T5.js");
        }

        [TestMethod]
        [TestCategory("Sputnik Conformance")]
        [TestCategory("ECMA 15.1.2.1")]
        [TestCategory("ECMA 12.6.1")]
        [Description("If Result(3).type is normal and its completion value is empty, then return the value undefined")]
        public void S15_1_2_1_A3_2_T6()
        {
            RunFile(@"S15.1.2.1_A3.2_T6.js");
        }

        [TestMethod]
        [TestCategory("Sputnik Conformance")]
        [TestCategory("ECMA 15.1.2.1")]
        [TestCategory("ECMA 12.6.2")]
        [Description("If Result(3).type is normal and its completion value is empty, then return the value undefined")]
        public void S15_1_2_1_A3_2_T7()
        {
            RunFile(@"S15.1.2.1_A3.2_T7.js");
        }

        [TestMethod]
        [TestCategory("Sputnik Conformance")]
        [TestCategory("ECMA 15.1.2.1")]
        [TestCategory("ECMA 12.6.3")]
        [Description("If Result(3).type is normal and its completion value is empty, then return the value undefined")]
        public void S15_1_2_1_A3_2_T8()
        {
            RunFile(@"S15.1.2.1_A3.2_T8.js");
        }

        [TestMethod]
        [TestCategory("Sputnik Conformance")]
        [TestCategory("ECMA 15.1.2.1")]
        [TestCategory("ECMA 12.7")]
        [Description("If Result(3).type is not normal, then Result(3).type must be throw. Throw Result(3).value as an exception")]
        public void S15_1_2_1_A3_3_T1()
        {
            RunFile(@"S15.1.2.1_A3.3_T1.js");
        }

        [TestMethod]
        [TestCategory("Sputnik Conformance")]
        [TestCategory("ECMA 15.1.2.1")]
        [TestCategory("ECMA 12.8")]
        [Description("If Result(3).type is not normal, then Result(3).type must be throw. Throw Result(3).value as an exception")]
        public void S15_1_2_1_A3_3_T2()
        {
            RunFile(@"S15.1.2.1_A3.3_T2.js");
        }

        [TestMethod]
        [TestCategory("Sputnik Conformance")]
        [TestCategory("ECMA 15.1.2.1")]
        [TestCategory("ECMA 12.9")]
        [Description("If Result(3).type is not normal, then Result(3).type must be throw. Throw Result(3).value as an exception")]
        public void S15_1_2_1_A3_3_T3()
        {
            RunFile(@"S15.1.2.1_A3.3_T3.js");
        }

        [TestMethod]
        [TestCategory("Sputnik Conformance")]
        [TestCategory("ECMA 15.1.2.1")]
        [TestCategory("ECMA 12.13")]
        [Description("If Result(3).type is not normal, then Result(3).type must be throw. Throw Result(3).value as an exception")]
        public void S15_1_2_1_A3_3_T4()
        {
            RunFile(@"S15.1.2.1_A3.3_T4.js");
        }

        [TestMethod]
        [TestCategory("Sputnik Conformance")]
        [TestCategory("ECMA 15.1.2.1")]
        [TestCategory("ECMA 15.2.4.7")]
        [TestCategory("ECMA 12.6.4")]
        [Description("The length property of eval has the attribute DontEnum")]
        public void S15_1_2_1_A4_1()
        {
            RunFile(@"S15.1.2.1_A4.1.js");
        }

        [TestMethod]
        [TestCategory("Sputnik Conformance")]
        [TestCategory("ECMA 15.1.2.1")]
        [TestCategory("ECMA 15.2.4.5")]
        [TestCategory("ECMA 11.4.1")]
        [Description("The length property of eval has the attribute DontDelete")]
        public void S15_1_2_1_A4_2()
        {
            RunFile(@"S15.1.2.1_A4.2.js");
        }

        [TestMethod]
        [TestCategory("Sputnik Conformance")]
        [TestCategory("ECMA 15.1.2.1")]
        [Description("The length property of eval has the attribute ReadOnly")]
        public void S15_1_2_1_A4_3()
        {
            RunFile(@"S15.1.2.1_A4.3.js");
        }

        [TestMethod]
        [TestCategory("Sputnik Conformance")]
        [TestCategory("ECMA 15.1.2.1")]
        [Description("The length property of eval is 1")]
        public void S15_1_2_1_A4_4()
        {
            RunFile(@"S15.1.2.1_A4.4.js");
        }

        [TestMethod]
        [TestCategory("Sputnik Conformance")]
        [TestCategory("ECMA 15.1.2.1")]
        [TestCategory("ECMA 15.2.4.7")]
        [TestCategory("ECMA 12.6.4")]
        [Description("The eval property has the attribute DontEnum")]
        public void S15_1_2_1_A4_5()
        {
            RunFile(@"S15.1.2.1_A4.5.js");
        }

        [TestMethod]
        [TestCategory("Sputnik Conformance")]
        [TestCategory("ECMA 15.1.2.1")]
        [Description("The eval property has not prototype property")]
        public void S15_1_2_1_A4_6()
        {
            RunFile(@"S15.1.2.1_A4.6.js");
        }

        [TestMethod]
        [TestCategory("Sputnik Conformance")]
        [TestCategory("ECMA 15.1.2.1")]
        [TestCategory("ECMA 11.2.2")]
        [Description("The eval property can\'t be used as constructor")]
        public void S15_1_2_1_A4_7()
        {
            RunFile(@"S15.1.2.1_A4.7.js");
        }
    }
}