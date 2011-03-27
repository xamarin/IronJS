// <auto-generated />
namespace IronJS.Tests.UnitTests.Sputnik.Conformance.Expressions.LeftHandSideExpressions
{
    using System;
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    [TestClass]
    public class FunctionCallsTests : SputnikTestFixture
    {
        public FunctionCallsTests()
            : base(@"Conformance\11_Expressions\11.2_Left_Hand_Side_Expressions\11.2.3_Function_Calls")
        {
        }

        [TestMethod]
        [TestCategory("Sputnik Conformance")]
        [TestCategory("ECMA 11.2.3")]
        [TestCategory("ECMA 7.2")]
        [TestCategory("ECMA 7.3")]
        [Description("White Space and Line Terminator between MemberExpression and Arguments are allowed")]
        public void S11_2_3_A1()
        {
            RunFile(@"S11.2.3_A1.js");
        }

        [TestMethod]
        [TestCategory("Sputnik Conformance")]
        [TestCategory("ECMA 11.2.3")]
        [Description("CallExpression : MemberExpression Arguments uses GetValue")]
        public void S11_2_3_A2()
        {
            RunFile(@"S11.2.3_A2.js");
        }

        [TestMethod]
        [TestCategory("Sputnik Conformance")]
        [TestCategory("ECMA 11.2.3")]
        [Description("If MemberExpression is not Object, throw TypeError")]
        public void S11_2_3_A3_T1()
        {
            RunFile(@"S11.2.3_A3_T1.js");
        }

        [TestMethod]
        [TestCategory("Sputnik Conformance")]
        [TestCategory("ECMA 11.2.3")]
        [Description("If MemberExpression is not Object, throw TypeError")]
        public void S11_2_3_A3_T2()
        {
            RunFile(@"S11.2.3_A3_T2.js");
        }

        [TestMethod]
        [TestCategory("Sputnik Conformance")]
        [TestCategory("ECMA 11.2.3")]
        [Description("If MemberExpression is not Object, throw TypeError")]
        public void S11_2_3_A3_T3()
        {
            RunFile(@"S11.2.3_A3_T3.js");
        }

        [TestMethod]
        [TestCategory("Sputnik Conformance")]
        [TestCategory("ECMA 11.2.3")]
        [Description("If MemberExpression is not Object, throw TypeError")]
        public void S11_2_3_A3_T4()
        {
            RunFile(@"S11.2.3_A3_T4.js");
        }

        [TestMethod]
        [TestCategory("Sputnik Conformance")]
        [TestCategory("ECMA 11.2.3")]
        [Description("If MemberExpression is not Object, throw TypeError")]
        public void S11_2_3_A3_T5()
        {
            RunFile(@"S11.2.3_A3_T5.js");
        }

        [TestMethod]
        [TestCategory("Sputnik Conformance")]
        [TestCategory("ECMA 11.2.3")]
        [Description("If MemberExpression does not implement the internal [[Call]] method, throw TypeError")]
        public void S11_2_3_A4_T1()
        {
            RunFile(@"S11.2.3_A4_T1.js");
        }

        [TestMethod]
        [TestCategory("Sputnik Conformance")]
        [TestCategory("ECMA 11.2.3")]
        [Description("If MemberExpression does not implement the internal [[Call]] method, throw TypeError")]
        public void S11_2_3_A4_T2()
        {
            RunFile(@"S11.2.3_A4_T2.js");
        }

        [TestMethod]
        [TestCategory("Sputnik Conformance")]
        [TestCategory("ECMA 11.2.3")]
        [Description("If MemberExpression does not implement the internal [[Call]] method, throw TypeError")]
        public void S11_2_3_A4_T3()
        {
            RunFile(@"S11.2.3_A4_T3.js");
        }

        [TestMethod]
        [TestCategory("Sputnik Conformance")]
        [TestCategory("ECMA 11.2.3")]
        [Description("If MemberExpression does not implement the internal [[Call]] method, throw TypeError")]
        public void S11_2_3_A4_T4()
        {
            RunFile(@"S11.2.3_A4_T4.js");
        }

        [TestMethod]
        [TestCategory("Sputnik Conformance")]
        [TestCategory("ECMA 11.2.3")]
        [Description("If MemberExpression does not implement the internal [[Call]] method, throw TypeError")]
        public void S11_2_3_A4_T5()
        {
            RunFile(@"S11.2.3_A4_T5.js");
        }
    }
}