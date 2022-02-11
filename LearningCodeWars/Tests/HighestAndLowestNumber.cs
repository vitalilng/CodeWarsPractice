using LearningCodeWars.Solutions;
using NUnit.Framework;

namespace LearningCodeWars.Tests
{
    [TestFixture]
    public class Tests
    {
        [Test]
        public void Test1()
        {
            Assert.AreEqual("42 -9", HighestAndLowestNumber.HighAndLow("8 3 -5 42 -1 0 0 -9 4 7 4 -4"));
        }
    }
}