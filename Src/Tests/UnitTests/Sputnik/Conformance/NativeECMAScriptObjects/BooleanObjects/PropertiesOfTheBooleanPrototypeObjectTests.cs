// <auto-generated />
namespace IronJS.Tests.UnitTests.Sputnik.Conformance.NativeECMAScriptObjects.BooleanObjects
{
    using System;
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    [TestClass]
    public class PropertiesOfTheBooleanPrototypeObjectTests : SputnikTestFixture
    {
        public PropertiesOfTheBooleanPrototypeObjectTests()
            : base(@"Conformance\15_Native_ECMA_Script_Objects\15.6_Boolean_Objects\15.6.4_Properties_of_the_Boolean_Prototype_Object")
        {
        }

        [TestMethod]
        [TestCategory("Sputnik Conformance")]
        [TestCategory("ECMA 15.6.4.1")]
        [Description("The initial value of Boolean.prototype.constructor is the built-in Boolean constructor")]
        public void S15_6_4_1_A1()
        {
            RunFile(@"S15.6.4.1_A1.js");
        }

        [TestMethod]
        [TestCategory("Sputnik Conformance")]
        [TestCategory("ECMA 15.6.4.2")]
        [Description("toString: If this boolean value is true, then the string \"true\" is returned, otherwise, this boolean value must be false, and the string \"false\" is returned")]
        public void S15_6_4_2_A1_T1()
        {
            RunFile(@"S15.6.4.2_A1_T1.js");
        }

        [TestMethod]
        [TestCategory("Sputnik Conformance")]
        [TestCategory("ECMA 15.6.4.2")]
        [Description("toString: If this boolean value is true, then the string \"true\" is returned, otherwise, this boolean value must be false, and the string \"false\" is returned")]
        public void S15_6_4_2_A1_T2()
        {
            RunFile(@"S15.6.4.2_A1_T2.js");
        }

        [TestMethod]
        [TestCategory("Sputnik Conformance")]
        [TestCategory("ECMA 15.6.4.2")]
        [Description("The toString function is not generic, it cannot be transferred to other kinds of objects for use as a method and there is should be a TypeError exception if its this value is not a Boolean object")]
        public void S15_6_4_2_A2_T1()
        {
            RunFile(@"S15.6.4.2_A2_T1.js");
        }

        [TestMethod]
        [TestCategory("Sputnik Conformance")]
        [TestCategory("ECMA 15.6.4.2")]
        [Description("The toString function is not generic, it cannot be transferred to other kinds of objects for use as a method and there is should be a TypeError exception if its this value is not a Boolean object")]
        public void S15_6_4_2_A2_T2()
        {
            RunFile(@"S15.6.4.2_A2_T2.js");
        }

        [TestMethod]
        [TestCategory("Sputnik Conformance")]
        [TestCategory("ECMA 15.6.4.2")]
        [Description("The toString function is not generic, it cannot be transferred to other kinds of objects for use as a method and there is should be a TypeError exception if its this value is not a Boolean object")]
        public void S15_6_4_2_A2_T3()
        {
            RunFile(@"S15.6.4.2_A2_T3.js");
        }

        [TestMethod]
        [TestCategory("Sputnik Conformance")]
        [TestCategory("ECMA 15.6.4.2")]
        [Description("The toString function is not generic, it cannot be transferred to other kinds of objects for use as a method and there is should be a TypeError exception if its this value is not a Boolean object")]
        public void S15_6_4_2_A2_T4()
        {
            RunFile(@"S15.6.4.2_A2_T4.js");
        }

        [TestMethod]
        [TestCategory("Sputnik Conformance")]
        [TestCategory("ECMA 15.6.4.2")]
        [Description("The toString function is not generic, it cannot be transferred to other kinds of objects for use as a method and there is should be a TypeError exception if its this value is not a Boolean object")]
        public void S15_6_4_2_A2_T5()
        {
            RunFile(@"S15.6.4.2_A2_T5.js");
        }

        [TestMethod]
        [TestCategory("Sputnik Conformance")]
        [TestCategory("ECMA 15.6.4.3")]
        [Description("Boolean.prototype.valueOf() returns this boolean value")]
        public void S15_6_4_3_A1_T1()
        {
            RunFile(@"S15.6.4.3_A1_T1.js");
        }

        [TestMethod]
        [TestCategory("Sputnik Conformance")]
        [TestCategory("ECMA 15.6.4.3")]
        [Description("Boolean.prototype.valueOf() returns this boolean value")]
        public void S15_6_4_3_A1_T2()
        {
            RunFile(@"S15.6.4.3_A1_T2.js");
        }

        [TestMethod]
        [TestCategory("Sputnik Conformance")]
        [TestCategory("ECMA 15.6.4.3")]
        [Description("The valueOf function is not generic, it cannot be transferred to other kinds of objects for use as a method and there is should be a TypeError exception if its this value is not a Boolean object")]
        public void S15_6_4_3_A2_T1()
        {
            RunFile(@"S15.6.4.3_A2_T1.js");
        }

        [TestMethod]
        [TestCategory("Sputnik Conformance")]
        [TestCategory("ECMA 15.6.4.3")]
        [Description("The valueOf function is not generic, it cannot be transferred to other kinds of objects for use as a method and there is should be a TypeError exception if its this value is not a Boolean object")]
        public void S15_6_4_3_A2_T2()
        {
            RunFile(@"S15.6.4.3_A2_T2.js");
        }

        [TestMethod]
        [TestCategory("Sputnik Conformance")]
        [TestCategory("ECMA 15.6.4.3")]
        [Description("The valueOf function is not generic, it cannot be transferred to other kinds of objects for use as a method and there is should be a TypeError exception if its this value is not a Boolean object")]
        public void S15_6_4_3_A2_T3()
        {
            RunFile(@"S15.6.4.3_A2_T3.js");
        }

        [TestMethod]
        [TestCategory("Sputnik Conformance")]
        [TestCategory("ECMA 15.6.4.3")]
        [Description("The valueOf function is not generic, it cannot be transferred to other kinds of objects for use as a method and there is should be a TypeError exception if its this value is not a Boolean object")]
        public void S15_6_4_3_A2_T4()
        {
            RunFile(@"S15.6.4.3_A2_T4.js");
        }

        [TestMethod]
        [TestCategory("Sputnik Conformance")]
        [TestCategory("ECMA 15.6.4.3")]
        [Description("The valueOf function is not generic, it cannot be transferred to other kinds of objects for use as a method and there is should be a TypeError exception if its this value is not a Boolean object")]
        public void S15_6_4_3_A2_T5()
        {
            RunFile(@"S15.6.4.3_A2_T5.js");
        }

        [TestMethod]
        [TestCategory("Sputnik Conformance")]
        [TestCategory("ECMA 15.6.4")]
        [Description("The Boolean prototype object is itself a Boolean object (its [[Class]] is \"Boolean\") whose value is false")]
        public void S15_6_4_A1()
        {
            RunFile(@"S15.6.4_A1.js");
        }

        [TestMethod]
        [TestCategory("Sputnik Conformance")]
        [TestCategory("ECMA 15.6.4")]
        [Description("The value of the internal [[Prototype]] property of the Boolean prototype object is the Object prototype object")]
        public void S15_6_4_A2()
        {
            RunFile(@"S15.6.4_A2.js");
        }
    }
}