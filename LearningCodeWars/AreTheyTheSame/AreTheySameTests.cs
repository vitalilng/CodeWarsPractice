using System;
using NUnit.Framework;

namespace LearningCodeWars.AreTheyTheSame
{
    [TestFixture]
    public class AreTheySameTests
    {

        [Test]
        public void Test1()
        {
            int[] a = new int[] { 121, 144, 19, 161, 19, 144, 19, 11 };
            int[] b = new int[] { 11 * 11, 121 * 121, 144 * 144, 19 * 19, 161 * 161, 19 * 19, 144 * 144, 19 * 19 };
            bool r = AreTheySame.CompareUsingArrays(a, b); // True
            Assert.AreEqual(true, r);
        }


        [Test]
        public void Test1A()
        {
            int[] a = new int[] { 2, 2, 3 };
            int[] b = new int[] { 4, 9, 9 };
            bool r = AreTheySame.CompareUsingArrays(a, b); // True
            Assert.AreEqual(false, r);
        }


    }
}