using NUnit.Framework;
using System;

namespace LearningCodeWars.DeleteNth
{
    [TestFixture]
    public class DeleteNthElementTests
    {
        [Test]
        public void TestSimple()
        {
            int[] expected = new int[] { 20, 37, 21 };

            int[] actual = DeleteNthElement.DeleteNth(new int[] { 20, 37, 20, 21 }, 1);

            CollectionAssert.AreEqual(expected, actual);
        }

        [Test]
        public void TestSimple2()
        {
            int[] expected = new int[] { 1, 1, 3, 3, 7, 2, 2, 2 };

            int[] actual = DeleteNthElement.DeleteNth(new int[] { 1, 1, 3, 3, 7, 2, 2, 2, 2 }, 3);

            CollectionAssert.AreEqual(expected, actual);
        }


        [Test]
        public void TestSimple3()
        {
            int[] expected = new int[] { 1, 2, 3 };

            int[] actual = DeleteNthElement.DeleteNth(new int[] { 1, 2, 1, 1, 3, 1, 1, 1, 3, 2 }, 1);

            CollectionAssert.AreEqual(expected, actual);
        }


    }
}