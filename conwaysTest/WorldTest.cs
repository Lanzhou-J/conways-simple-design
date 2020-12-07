using System;
using conways_simple_design;
using Xunit;

namespace conwaysTest
{
    public class WorldTest
    {
        [Fact]
        public void TestANewWorldIsEmpty()
        {
            var world = new World();
            Assert.True(world.Empty);
        }

        [Fact]
        public void TestACellCanBeAddedToTheWorld()
        {
            var world = new World();
            world.SetLivingAt(1, 1);
            Assert.True(world.AliveAt(1,1));
            
        }
    }
}