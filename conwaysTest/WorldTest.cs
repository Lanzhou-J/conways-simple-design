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
            world.set_living_at(1, 1);
            Assert.True(world.alive_at(1,1));
            
        }
    }
}