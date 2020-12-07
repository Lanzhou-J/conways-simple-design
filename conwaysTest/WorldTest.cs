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
            Assert.Equal(0, world.Living_cells.count);
        }
    }
}