using NUnit.Framework;
using LearningCodeWars.Solutions;

namespace LearningCodeWars.Tests
{

    [TestFixture]
    public class SolutionTest
    {
        [Test]
        public void Tests()
        {
            Assert.AreEqual(0, OddIntKata.Find_it(new[] { 0, 1, 0, 1, 0 }));
            Assert.AreEqual(5, OddIntKata.Find_it(new[] { 20, 1, -1, 2, -2, 3, 3, 5, 5, 1, 2, 4, 20, 4, -1, -2, 5 }));
            Assert.AreEqual(4, OddIntKata.Find_it(new[] { 1, 2, 2, 3, 3, 3, 4, 3, 3, 3, 2, 2, 1 }));
        }
    }
}