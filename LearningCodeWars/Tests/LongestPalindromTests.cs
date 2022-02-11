﻿using LearningCodeWars.Solutions;
using NUnit.Framework;

namespace LearningCodeWars.Tests
{
    public class LongestPalindromTests
    {
        [TestCase("", ExpectedResult = 0, Description = "empty string test")]
        [TestCase(null, ExpectedResult = 0, Description = "'null' value test")]
        [TestCase("a", ExpectedResult = 1, Description = "'a' value test")]
        [TestCase("aa", ExpectedResult = 2, Description = "'aa' value test")]
        [TestCase("ab", ExpectedResult = 1, Description = "'ab' value test")]
        [TestCase("baa", ExpectedResult = 2, Description = "'baa' value test")]
        [TestCase("abc0cba1", ExpectedResult = 7, Description = "'abc0cba1' value test")]
        [TestCase("12 21glg", ExpectedResult = 5, Description = "'12 21glg' value test")]
        [TestCase("12 21glaalg", ExpectedResult = 6, Description = "'12 21glaalg' value test")]
        [TestCase("   ", ExpectedResult = 3, Description = "empty space test")]
        public int SampleTest(string str)
        {
            return LongestPalindrom.GetLongestPalindrom(str);
        }
    }
}
