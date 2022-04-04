using NUnit.Framework;
using System.Collections;

namespace LearningCodeWars.HelpGrannyTour
{
    [TestFixture]
    public class GrannyTourTests
    {
        [Test]
        public void Test1()
        {
            string[] friends1 = new string[] { "A1", "A2", "A3", "A4", "A5" };
            string[][] fTowns1 = { new string[] { "A1", "X1" }, new string[] { "A2", "X2" }, new string[] { "A3", "X3" }, new string[] { "A4", "X4" } };
            Hashtable distTable1 = new() { { "X1", 100.0 }, { "X2", 200.0 }, { "X3", 250.0 }, { "X4", 300.0 } };
            Assert.AreEqual(889, GrannyTour.Tour(friends1, fTowns1, distTable1));
        }

        [Test]
        public void Test2()
        {
            string[] friends1 = new string[] { "B1", "B2" };
            string[][] fTowns1 = { new string[] { "B1", "Y1" }, new string[] { "B2", "Y2" }, new string[] { "B3", "Y3" }, new string[] { "B4", "Y4" }, new string[] { "B5", "Y5" } };
            Hashtable distTable1 = new() { { "Y1", 50.0 }, { "Y2", 70.0 }, { "Y3", 90.0 }, { "Y4", 110.0 }, { "Y5", 150.0 } };
            Assert.AreEqual(168, GrannyTour.Tour(friends1, fTowns1, distTable1));
        }

        [Test]
        public void Test3()
        {
            string[] friends1 = new string[] { "B1", "B2", "B3" };
            string[][] fTowns1 = { new string[] { "B1", "Y1" }, new string[] { "B2", "Y2" }, new string[] { "B3", "Y3" }, new string[] { "B4", "Y4" }, new string[] { "B5", "Y5" } };
            Hashtable distTable1 = new() { { "Y1", 60.0 }, { "Y2", 80.0 }, { "Y3", 100.0 }, { "Y4", 110.0 }, { "Y5", 150.0 } };
            Assert.AreEqual(272, GrannyTour.Tour(friends1, fTowns1, distTable1));
        }

        [Test]
        public void Test4()
        {
            string[] friends1 = new string[] { "B1", "B2", "B4", "B5", "B6" };
            string[][] fTowns1 = { new string[] { "B1", "Y1" }, new string[] { "B2", "Y2" }, new string[] { "B3", "Y3" }, new string[] { "B4", "Y4" }, new string[] { "B5", "Y5" } };
            Hashtable distTable1 = new() { { "Y1", 60.0 }, { "Y2", 80.0 }, { "Y3", 100.0 }, { "Y4", 110.0 }, { "Y5", 150.0 } };
            Assert.AreEqual(440, GrannyTour.Tour(friends1, fTowns1, distTable1));
        }
    }
}