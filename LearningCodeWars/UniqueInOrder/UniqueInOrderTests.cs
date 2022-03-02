using NUnit.Framework;

namespace LearningCodeWars.UniqueInOrder
{
    [TestFixture]
    public class UniqueInOrderTests
    {
        [Test]
        public void EmptyTest()
        {
            Assert.AreEqual("", UniqueInOrder.GetUniqueInOrder(""));
        }

        [Test]
        public void Test1()
        {
            Assert.AreEqual("ABCDAB", UniqueInOrder.GetUniqueInOrder("AAAABBBCCDAABBB"));
            Assert.AreEqual("ABCcAD", UniqueInOrder.GetUniqueInOrder("ABBCcAD"));
        }
    }
}