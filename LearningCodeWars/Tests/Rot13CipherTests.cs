using NUnit.Framework;
using LearningCodeWars.Solutions;

namespace LearningCodeWars.Tests
{
    [TestFixture]
    public class Rot13CipherTests
    {
        [Test, Description("test")]
        public void TestLowerCase()
        {
            Assert.AreEqual("grfg", Rot13Cipher.Rot13("test"), string.Format("Input: test, Expected Output: grfg, Actual Output: {0}", Rot13Cipher.Rot13("test")));
        }

        [Test, Description("Test")]
        public void TestUppercase()
        {
            Assert.AreEqual("Grfg", Rot13Cipher.Rot13("Test"), string.Format("Input: Test, Expected Output: Grfg, Actual Output: {0}", Rot13Cipher.Rot13("Test")));
        }

        [Test, Description("A long phrase")]
        public void TestLongPhrase()
        {
            Assert.AreEqual("Gur ncnegzrag vf 700 fdhner srrg.", Rot13Cipher.Rot13("The apartment is 700 square feet."));
        }
    }
}
