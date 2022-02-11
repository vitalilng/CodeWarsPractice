using LearningCodeWars.Solutions;
using NUnit.Framework;

namespace LearningCodeWars.Tests
{
    internal class MultiplicationTableTests
    {
        [Test]
        [Description("Use 4 size array")]
        public void MyTest()
        {
            var expected = new[,] { { 1, 2, 3 }, { 2, 4, 6 }, { 3, 6, 9 } };
            Assert.AreEqual(expected, MultiplicationTable.CreateMultiplicationTable(3));
        }

        [Test]
        [Description("Use 4 size array")]
        public void MyTestOf4()
        {
            var expected = new[,] { { 1, 2, 3, 4 }, { 2, 4, 6, 8 }, { 3, 6, 9, 12 }, {4, 8, 12, 16} };
            Assert.AreEqual(expected, MultiplicationTable.CreateMultiplicationTable(4));
        }
    }
}
