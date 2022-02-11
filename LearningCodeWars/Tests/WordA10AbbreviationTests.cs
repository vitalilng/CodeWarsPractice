using LearningCodeWars.Solutions;
using NUnit.Framework;

namespace LearningCodeWars.Tests
{
    public class WordA10AbbreviationTests
    {
        [Test]
        public void TestInternationalization()
        {
            Assert.AreEqual("i18n", WordA10Abbreviation.Abbreviate("internationalization"));
        }
        [Test]
        public void TestShortSentence()
        {
            Assert.AreEqual("my. dog, isn't f5g v2y w2l.", WordA10Abbreviation.Abbreviate("my. dog, isn't feeling very well."));
        }


        [Test]
        public void TestWordsWithOneSymbol()
        {
            Assert.AreEqual("e6t-r3s are'r4y f7c! fun!", WordA10Abbreviation.Abbreviate("elephant-rides are'really fantastic! fun!"));
        }


        [Test]
        public void TestWordsWithDash()
        {
            Assert.AreEqual("e6t-r3s are r4y fun!", WordA10Abbreviation.Abbreviate("elephant-rides are really fun!"));
        }

        [Test]
        public void TestWordsWithDoubleDash()
        {
            Assert.AreEqual("is'mat, b5n the'd3y; m8c. b5n sat; the-mat", WordA10Abbreviation.Abbreviate("is'mat, between the'doggy; marinistic. between sat; the-mat"));
        }
        
        
        [Test]
        public void TestWordsWithDoubleDashAndSymbolInTheMiddle()
        {
            Assert.AreEqual("d4e-b6d; b5n'on'd4e-b6d d3y. sat'mat. sat-mat-on", WordA10Abbreviation.Abbreviate("donate-backbend; between'on'donate-backbend doggy. sat'mat. sat-mat-on"));
        }


        [Test]
        public void TestWithSmallWords()
        {
            Assert.AreEqual("on on", WordA10Abbreviation.Abbreviate("on on"));
        }
    }
}
