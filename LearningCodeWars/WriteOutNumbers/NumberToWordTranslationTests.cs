using NUnit.Framework;

namespace LearningCodeWars.WriteOutNumbers
{
    [TestFixture]
    public class NumberToWordTranslationTests
    {
        [Test]
        public void Number2WordsTest()
        {
            Assert.AreEqual("zero", NumberToWordTranslation.NumberToWords(0));
            Assert.AreEqual("one", NumberToWordTranslation.NumberToWords(1));
            Assert.AreEqual("three", NumberToWordTranslation.NumberToWords(3));
            Assert.AreEqual("five", NumberToWordTranslation.NumberToWords(5));
            Assert.AreEqual("eight", NumberToWordTranslation.NumberToWords(8));
            Assert.AreEqual("ten", NumberToWordTranslation.NumberToWords(10));
            Assert.AreEqual("eleven", NumberToWordTranslation.NumberToWords(11));
            Assert.AreEqual("three hundred one", NumberToWordTranslation.NumberToWords(301));
            Assert.AreEqual("seven hundred ninety-three", NumberToWordTranslation.NumberToWords(793));
            Assert.AreEqual("eight hundred", NumberToWordTranslation.NumberToWords(800));
            Assert.AreEqual("six hundred fifty", NumberToWordTranslation.NumberToWords(650));
            Assert.AreEqual("one thousand", NumberToWordTranslation.NumberToWords(1000));
            Assert.AreEqual("one thousand three", NumberToWordTranslation.NumberToWords(1003));
            Assert.AreEqual("eleven thousand thirteen", NumberToWordTranslation.NumberToWords(11013));
            Assert.AreEqual("nine hundred ninety-nine thousand nine hundred ninety-nine", NumberToWordTranslation.NumberToWords(999999));
        }
    }
}
