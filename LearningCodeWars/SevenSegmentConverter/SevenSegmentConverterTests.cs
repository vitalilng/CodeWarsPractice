using NUnit.Framework;
using System;

namespace LearningCodeWars.SevenSegmentConverter
{
    [TestFixture]
    public class SevenSegmentConverterTests
    {
        [Test]
        public void ZeroTest()
        {
            Assert.AreEqual(125, SevenSegmentConverter.SevenSegmentNumber(0));
        }

        [Test]
        public void NineTest()
        {
            Assert.AreEqual(95, SevenSegmentConverter.SevenSegmentNumber(9));
        }

        [Test]
        public void EightTest()
        {
            Assert.AreEqual(127, SevenSegmentConverter.SevenSegmentNumber(8));
        }

        [Test]
        public void InvalidNumberTest()
        {
            Assert.Throws<Exception>(() => SevenSegmentConverter.SevenSegmentNumber(99));
        }
    }
}
