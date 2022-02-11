using NUnit.Framework;
using System;
using LearningCodeWars.Solutions;

namespace LearningCodeWars.Tests
{
    /// <summary>
    /// Find the middle element
    /// returns the index of the numerical element that lies between the other two elements.
    /// gimme([2, 3, 1]) => 0
    /// gimme([5, 10, 14]) => 1
    /// </summary>
    [TestFixture]
    public class GimeTests
    {
        [Test]
        public void SampleTests()
        {
            Assert.AreEqual(0, Gimme.GimmeKata(new double[] { 2, 3, 1 }));
            Assert.AreEqual(1, Gimme.GimmeKata(new double[] { 5, 10, 14 }));
        }

        [Test]
        public void FloatTests()
        {
            Assert.AreEqual(0, Gimme.GimmeKata(new double[] { 2.1, 3.2, 1.4 }));
            Assert.AreEqual(1, Gimme.GimmeKata(new double[] { 5.9, 10.4, 14.2 }));
        }

        [Test]
        public void NegativeTests()
        {
            Assert.AreEqual(0, Gimme.GimmeKata(new double[] { -2, -3, -1 }));
            Assert.AreEqual(1, Gimme.GimmeKata(new double[] { -5, -10, -14 }));
        }

        [Test]
        public void MixedTests()
        {
            Assert.AreEqual(0, Gimme.GimmeKata(new double[] { -2, -3.2, 1 }));
            Assert.AreEqual(0, Gimme.GimmeKata(new double[] { -5.2, -10.6, 14 }));
        }

        public static int Solution(double[] inputArray)
        {
            double[] sorted = (double[])inputArray.Clone();
            Array.Sort(sorted);
            return Array.IndexOf(inputArray, sorted[1]);
        }

        private static readonly Random rnd = new();

        [Test]
        public void RandomTests()
        {
            for (int i = 0; i < 40; ++i)
            {
                double[] testCase = new double[] { rnd.NextDouble(), rnd.NextDouble(), rnd.NextDouble() };
                Assert.AreEqual(Solution(testCase), Gimme.GimmeKata(testCase));
            }
        }

    }
}
