using Xunit;
using System.Collections.Generic;

namespace csharpcore
{
    public class GildedRoseTest
    {
        [Fact]
        public void Foo()
        {
            IList<Item> items = new List<Item> {new Item("foo", 0, 0)};
            GildedRose app = new GildedRose(items);
            app.UpdateQuality();
            Assert.Equal("fixme", items[0].Name);
        }
    }
}