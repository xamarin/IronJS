// <auto-generated />
namespace IronJS.Tests.UnitTests.Sputnik.Conformance.NativeECMAScriptObjects.DateObjects.PropertiesOfTheDatePrototypeObject
{
    using System;
    using NUnit.Framework;

    [TestFixture]
    public class DatePrototypeSetUTCMonthTests : SputnikTestFixture
    {
        public DatePrototypeSetUTCMonthTests()
            : base(@"Conformance\15_Native_ECMA_Script_Objects\15.9_Date_Objects\15.9.5_Properties_of_the_Date_Prototype_Object\15.9.5.39_Date.prototype.setUTCMonth")
        {
        }

        [Test]
        [Category("Sputnik Conformance")]
        [Category("ECMA 15.9.5.39")]
        [TestCase("S15.9.5.39_A1_T1.js", Description = "The Date.prototype property \"setUTCMonth\" has { DontEnum } attributes")]
        [TestCase("S15.9.5.39_A1_T2.js", Description = "The Date.prototype property \"setUTCMonth\" has { DontEnum } attributes")]
        [TestCase("S15.9.5.39_A1_T3.js", Description = "The Date.prototype property \"setUTCMonth\" has { DontEnum } attributes")]
        public void TheDatePrototypePropertySetUTCMonthHasDontEnumAttributes(string file)
        {
            RunFile(file);
        }

        [Test]
        [Category("Sputnik Conformance")]
        [Category("ECMA 15.9.5.39")]
        [TestCase("S15.9.5.39_A2_T1.js", Description = "The \"length\" property of the \"setUTCMonth\" is 2")]
        public void TheLengthPropertyOfTheSetUTCMonthIs2(string file)
        {
            RunFile(file);
        }

        [Test]
        [Category("Sputnik Conformance")]
        [Category("ECMA 15.9.5.39")]
        [TestCase("S15.9.5.39_A3_T1.js", Description = "The Date.prototype.setUTCMonth property \"length\" has { ReadOnly, DontDelete, DontEnum } attributes")]
        [TestCase("S15.9.5.39_A3_T2.js", Description = "The Date.prototype.setUTCMonth property \"length\" has { ReadOnly, DontDelete, DontEnum } attributes")]
        [TestCase("S15.9.5.39_A3_T3.js", Description = "The Date.prototype.setUTCMonth property \"length\" has { ReadOnly, DontDelete, DontEnum } attributes")]
        public void TheDatePrototypeSetUTCMonthPropertyLengthHasReadOnlyDontDeleteDontEnumAttributes(string file)
        {
            RunFile(file);
        }
    }
}