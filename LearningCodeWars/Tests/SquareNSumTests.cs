using LearningCodeWars.Solutions;
using NUnit.Framework;
using System.Collections.Generic;

namespace LearningCodeWars.Tests
{
    [TestFixture]
   public class SquareNSumTests
    {
        private static IEnumerable<TestCaseData> SampleTestCases
        {
            get
            {
                yield return new TestCaseData(new int[] { 1, 2, 2 }).Returns(9);
                yield return new TestCaseData(new int[] { 1, 2 }).Returns(5);
                yield return new TestCaseData(new int[] { 5, 3, 4 }).Returns(50);
                yield return new TestCaseData(new int[] { }).Returns(0);
            }
        }


        [Test, TestCaseSource("SampleTestCases"), Description("Sample Tests")]
        public int SampleTest(int[] n)
        {
            return SquareNSum.SquareSum(n);
        }
    }
}
