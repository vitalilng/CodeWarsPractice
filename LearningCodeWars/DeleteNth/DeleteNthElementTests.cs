using NUnit.Framework;

namespace LearningCodeWars.DeleteNth
{
    [TestFixture]
    public class DeleteNthElementTests
    {
        [Test]
        public void TestSimple()
        {
            int[] expected = new int[] { 20, 37, 21 };

            int[] actual = DeleteNthElement.DeleteNthUsingArray(new int[] { 20, 37, 20, 21 }, 1);

            CollectionAssert.AreEqual(expected, actual);
        }

        [Test]
        public void TestSimple2()
        {
            int[] expected = new int[] { 1, 1, 3, 3, 7, 2, 2, 2 };

            int[] actual = DeleteNthElement.DeleteNthUsingArray(new int[] { 1, 1, 3, 3, 7, 2, 2, 2, 2 }, 3);

            CollectionAssert.AreEqual(expected, actual);
        }

        [Test]
        public void TestSimple3()
        {
            int[] expected = new int[] { 1, 2, 3 };

            int[] actual = DeleteNthElement.DeleteNthUsingArray(new int[] { 1, 2, 1, 1, 3, 1, 1, 1, 3, 2 }, 1);

            CollectionAssert.AreEqual(expected, actual);
        }

        [Test]
        public void TestSimple4()
        {
            int[] expected = new int[] { 3, 3, 2, 3, 1, 2, 1, 2 };

            int[] actual = DeleteNthElement.DeleteNthUsingArray(new int[] { 3, 3, 2, 3, 1, 2, 1, 2, 3, 2 }, 3);

            CollectionAssert.AreEqual(expected, actual);
        }

        [Test]
        public void TestSimple5()
        {
            int[] expected = new int[] { 3, 2, 1, 1, 2, 3 };

            int[] actual = DeleteNthElement.DeleteNthUsingArray(new int[] { 3, 2, 1, 1, 2, 3, 1, 2, 3, 2 }, 2);

            CollectionAssert.AreEqual(expected, actual);
        }
    }
}