using Xunit;
using System.Collections.Generic;

namespace GildedRoseKata.Tests
{
    public class GildedRoseTest
    {
        [Fact]
        public void Foo()
        {
            var items = new List<Item> {new Item("foo", 0, 0)};
            var app = new GildedRose(items);

            app.UpdateQuality();

            Assert.Equal("fixme", items[0].Name);
        }
    }
}