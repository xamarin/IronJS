// <auto-generated />
namespace IronJS.Tests.UnitTests.IE9.chapter11._11_1
{
    using System;
    using NUnit.Framework;

    [TestFixture]
    public class _11_1_4_Tests : IE9TestFixture
    {
        public _11_1_4_Tests() : base(@"chapter11\11.1\11.1.4") { }

        [Test(Description = "Initialize array using ElementList (Elisionopt AssignmentExpression) when index property (read-only) exists in Array.prototype (step 5)")] public void _11_1_4_4__5__1() { RunFile(@"11.1.4_4-5-1.js"); }
        [Test(Description = "Initialize array using ElementList (ElementList , Elisionopt AssignmentExpression) when index property (read-only) exists in Array.prototype (step 6)")] public void _11_1_4_5__6__1() { RunFile(@"11.1.4_5-6-1.js"); }
        [Test(Description = "elements elided at the end of an array do not contribute to its length")] public void _11_1_4__0() { RunFile(@"11.1.4-0.js"); }
    }
}