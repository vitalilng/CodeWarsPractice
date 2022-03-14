using System;
using NUnit.Framework;

namespace LearningCodeWars.SumStringsAsNumbers
{
    [TestFixture]
    public class SumStringsTests
    {
        [Test]
        public void Given123And456Returns579()
        {
            Assert.AreEqual("579", SumStrings.SumString("123", "456"));
            Assert.AreEqual("2147484105", SumStrings.SumString("2147483649", "456"));
            Assert.AreEqual("5", SumStrings.SumString("5", ""));
            Assert.AreEqual("712577413488402631964821329", SumStrings.SumString("712569312664357328695151392", "8100824045303269669937"));
        }
    }
}