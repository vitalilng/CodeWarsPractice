using LearningCodeWars.Int23ToIPv4;
using NUnit.Framework;

namespace LearningCodeWars.Int32ToIPv4
{
    [TestFixture]
    public class Sample_Test
    {
        [Test, Description("Sample Tests")]
        public void Test()
        {
            Assert.AreEqual("0.14.17.14", Int32ToIpV4.UInt32ToIP(921870));
            Assert.AreEqual("0.0.15.255", Int32ToIpV4.UInt32ToIP(4095));
            Assert.AreEqual("0.0.0.32", Int32ToIpV4.UInt32ToIP(32));
            Assert.AreEqual("128.114.17.104", Int32ToIpV4.UInt32ToIP(2154959208));
            Assert.AreEqual("0.0.0.0", Int32ToIpV4.UInt32ToIP(0));
            Assert.AreEqual("128.32.10.1", Int32ToIpV4.UInt32ToIP(2149583361));
        }
    }
}