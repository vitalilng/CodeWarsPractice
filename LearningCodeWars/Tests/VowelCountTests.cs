using System;
using LearningCodeWars.Solutions;
using NUnit.Framework;

namespace LearningCodeWars.Tests
{
    [TestFixture]
    public class VowelCountTests
    {
        [Test]
        public void TestCase1()
        {
            Assert.AreEqual(5, VowelCount.GetVowelCount("abracadabra"), "Nope!");
        }
    }
}