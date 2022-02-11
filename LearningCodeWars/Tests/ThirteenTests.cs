using System;
using LearningCodeWars.Solutions;
using NUnit.Framework;

namespace LearningCodeWars.Tests
{   
    /// <summary>
    /// codewars.com/kata/564057bc348c7200bd0000ff/csharp
    /// Thirteen
    /// </summary>
    [TestFixture]
    public static class ThirteenTests
    {

        private static void testing(long actual, long expected)
        {
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public static void test1()
        {
            Console.WriteLine("Testing Thirt");
            testing(Thirteen.Thirt(8529), 79);
            testing(Thirteen.Thirt(85299258), 31);
            testing(Thirteen.Thirt(5634), 57);
            testing(Thirteen.Thirt(1111111111), 71);
            testing(Thirteen.Thirt(987654321), 30);
        }
    }
}