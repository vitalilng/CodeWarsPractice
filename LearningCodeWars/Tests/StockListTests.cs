using LearningCodeWars.Solutions;
using NUnit.Framework;

namespace LearningCodeWars.Tests
{
    [TestFixture]
    public class StockListTests
    {
        [Test]
        public void Test1()
        {
            string[] art = new string[] { "...", "ABAR 200", "ABSSR 0290", "CDXE 500", "BKWR 0250", "...", "BTSQ 890", "DRTY 060" };
            string[] cd = new string[] { "...", "A", "B", "D", "X" };
            Assert.AreEqual("... - (A : 490) - (B : 1140) - (D : 60) - (X : 0)", StockList.StockSummary(art, cd));
        }

        [Test]
        public void Test2()
        {
            string[] art = new string[] { "ABART 20", "CDXEF 50", "BKWRK 25", "BTSQZ 89", "DRTYM 60" };
            string[] cd = new string[] { "A", "B", "C", "W" };
            Assert.AreEqual("(A : 20) - (B : 114) - (C : 50) - (W : 0)", StockList.StockSummary(art, cd));
        }

        [Test]
        public void Test3()
        {
            string[] art = new string[] { "CDXEF 50", "BKWRK 25", "BTSQZ 89", "DRTYM 60", "CKDSS 20" };
            string[] cd = new string[] { "A", "B", "C", "W" };
            Assert.AreEqual("(A : 0) - (B : 114) - (C : 70) - (W : 0)", StockList.StockSummary(art, cd));
        }

        [Test]
        public void Test4()
        {
            string[] art = new string[] { "...", "CDXEF 515", "BKWRK 250", "BTSQZ 890", "BGGFD 150", "...", "DRTYM 600", "...", "BIODD 100" };
            string[] cd = new string[] { "...", "B", "C", "D" };
            Assert.AreEqual("... - (B : 1390) - (C : 515) - (D : 600)", StockList.StockSummary(art, cd));
        }
    }
}