using LearningCodeWars.Solutions;
using NUnit.Framework;

namespace LearningCodeWars.Tests
{
    [TestFixture]
    public class PangramTests
    {
        [Test]
        public void SampleTests()
        {
            Assert.AreEqual(true, PangramKata.IsPangram("The quick brown fox jumps over the lazy dog."));
            Assert.AreEqual(true, PangramKata.IsPangram("ABCD45EFGH,IJK,LMNOPQR56STUVW3XYZ"));
            Assert.AreEqual(false, PangramKata.IsPangram("aaaaaaaaaaaaaaaaaaaaaaaaaa"));
            Assert.AreEqual(true, PangramKata.IsPangram("How quickly daft jumping zebras vex."));
            Assert.AreEqual(false, PangramKata.IsPangram("This isn't a pangram!"));
            Assert.AreEqual(true, PangramKata.IsPangram("Raw Danger! (Zettai Zetsumei Toshi 2) for the PlayStation 2 is a bit queer, but an alright game I guess, uh... CJ kicks and vexes Tenpenny precariously? This should be a pangram now, probably."));
            Assert.AreEqual(false, PangramKata.IsPangram("A pangram is a sentence that contains every single letter of the alphabet at least once."));
        }
    }
}