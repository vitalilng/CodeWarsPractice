using LearningCodeWars.Solutions;
using NUnit.Framework;

namespace LearningCodeWars.Tests
{
    [TestFixture]
    public class DirReductionTests
    {

        [Test]
        public void Test1()
        {
            var a = new[] { "NORTH", "SOUTH", "SOUTH", "EAST", "WEST", "NORTH", "WEST" };
            var b = new[] { "WEST" };
            Assert.AreEqual(b, DirReduction.DirectionReduction(a));
        }
        
        [Test]
        public void Test2()
        {
            var a = new[] { "NORTH", "WEST", "SOUTH", "EAST" };
            var b = new[] { "NORTH", "WEST", "SOUTH", "EAST" };
            Assert.AreEqual(b, DirReduction.DirectionReduction(a));
        }

        [Test]
        public void Test3()
        {
            var a = new[] { "NORTH", "WEST", "WEST", "EAST" };
            var b = new[] { "NORTH", "WEST" };
            Assert.AreEqual(b, DirReduction.DirectionReduction(a));
        }
    }

}
