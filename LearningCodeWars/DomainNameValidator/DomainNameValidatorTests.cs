using NUnit.Framework;
//nOT FINISHED
namespace LearningCodeWars.DomainNameValidator
{
    [TestFixture]
    public class DomainNameValidatorTests
    {
        private readonly DomainNameValidator nameValidator = new DomainNameValidator();

        [Test]
        public void DomainTests()
        {
            Assert.AreEqual(false, nameValidator.Validate("codewars"));
            Assert.AreEqual(true, nameValidator.Validate("g.co"));
            Assert.AreEqual(true, nameValidator.Validate("codewars.com"));
            Assert.AreEqual(true, nameValidator.Validate("CODEWARS.COM"));
            Assert.AreEqual(true, nameValidator.Validate("sub.CODEWARS.COM"));
            Assert.AreEqual(false, nameValidator.Validate("codewars.com-"));
            Assert.AreEqual(false, nameValidator.Validate(".codewars.com"));
            Assert.AreEqual(false, nameValidator.Validate("example@codewars.com"));
            Assert.AreEqual(false, nameValidator.Validate("127.0.0.1"));
            Assert.AreEqual(true, nameValidator.Validate("127.0.0.co"));
            Assert.AreEqual(true, nameValidator.Validate("bar.ba.test.co.uk"));
            Assert.AreEqual(false, nameValidator.Validate("g-.com"));
            Assert.AreEqual(true, nameValidator.Validate("xn--example-kva.meow"));
            Assert.AreEqual(false, nameValidator.Validate("."));
            Assert.AreEqual(false, nameValidator.Validate(".com"));
            Assert.AreEqual(false, nameValidator.Validate("example."));
            Assert.AreEqual(false, nameValidator.Validate("example.com."));
            Assert.AreEqual(false, nameValidator.Validate("example..com"));
            Assert.AreEqual(false, nameValidator.Validate("abcdefghijklmnopqrstuvwxyz.ABCDEFGHIJKLMNOPQRSTUVWXYZ"));
            Assert.AreEqual(true, nameValidator.Validate("subdomain.codewars.com"));
            Assert.AreEqual(false, nameValidator.Validate("some-horribly-long-domain-name-but-still-shorter-than-63-ch.zzz"));
            Assert.AreEqual(false, nameValidator.Validate("some-horribly-long-domain-name-this-time-longer-than-63-charaters.zzz"));
            Assert.AreEqual(true, nameValidator.Validate("example.a1b"));


        }
    }
}
