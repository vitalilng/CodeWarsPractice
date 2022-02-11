using NUnit.Framework;

namespace LearningCodeWars.Tests
{
    [TestFixture]
    public class TitleCaseTests
    {
        [TestCase("a clash of KINGS", "a an the of", "A Clash of Kings")]
        [TestCase("THE WIND IN THE WILLOWS", "The In", "The Wind in the Willows")]
        [TestCase("aBC deF Ghi", null, "Abc Def Ghi")]
        public void MyTest(string sampleTitle, string sampleMinorWords, string expected)
        {
            Assert.AreEqual(expected, TitleCase.TitleCaseKata(sampleTitle, sampleMinorWords));
        }
        [Test]
        public void MyTest2()
        {
            Assert.AreEqual("", TitleCase.TitleCaseKata(""));
        }
        [Test]
        public void MyTest3()
        {
            Assert.AreEqual("The Quick Brown Fox", TitleCase.TitleCaseKata("the quick brown fox"));
        }
    }
}