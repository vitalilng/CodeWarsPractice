using LearningCodeWars.Solutions;
using NUnit.Framework;

namespace LearningCodeWars.Tests
{
    [TestFixture]
    public class SumOfNumbersTests
    {
        private readonly SumOfNumbers s = new();

        [Test]
        public void Test1()
        {
            Assert.AreEqual(9, SumOfNumbers.GetSum(-1, 4));
            Assert.AreEqual(1, SumOfNumbers.GetSum(0, 1));
            Assert.AreEqual(-1, SumOfNumbers.GetSum(0, -1));
            Assert.AreEqual(9, SumOfNumbers.GetSum(4, -1));
            Assert.AreEqual(-3, SumOfNumbers.GetSum(-2, -1));
            Assert.AreEqual(5, SumOfNumbers.GetSum(-1, 3));
        }
    }
}