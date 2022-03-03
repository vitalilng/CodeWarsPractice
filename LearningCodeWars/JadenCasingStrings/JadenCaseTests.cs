using NUnit.Framework;

namespace LearningCodeWars.JadenCasingStrings
{
    [TestFixture]
    public class JadenCaseTests
    {
        [Test]
        public void FixedTest()
        {
            Assert.AreEqual("How Can Mirrors Be Real If Our Eyes Aren't Real",
                    "How can mirrors be real if our eyes aren't real".ToJadenCase(),
                    "Strings didn't match.");
        }

        [Test]
        [Description("starting with lower case")]
        public void RandomTest()
        {
            Assert.AreEqual("Tfif Vbt Xm Tmmhtgkhqr Ydjbjabe Sdvvszul Zrdpxz Vlm Pnqbm Butst Tt Prq",
                            "tfif vbt xm tmmhtgkhqr ydjbjabe sdvvszul zrdpxz vlm pnqbm butst tt prq".ToJadenCase(),
                            "Strings didn't match.");
        }
    }
}