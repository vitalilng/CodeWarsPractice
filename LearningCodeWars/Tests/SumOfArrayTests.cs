using LearningCodeWars.Solutions;
using NUnit.Framework;

namespace LearningCodeWars.Tests
{
    [TestFixture]
    public class SumOfArrayTests
    {
        [Test]
        public void TestNullArray()
        {
            Assert.AreEqual(0, SumOfArray.SumOfArrayElements(new int[]{}));
        }

        [Test]
        public void TestOneValueArray()
        {
            Assert.AreEqual(3, SumOfArray.SumOfArrayElements(new []{3}));
        }

        [Test]
        public void TestMultipleValuesArray()
        {
            Assert.AreEqual(138, SumOfArray.SumOfArrayElements (new[] { 3, 33, 12, 1, 0, 89 }));
        }


    }
}
