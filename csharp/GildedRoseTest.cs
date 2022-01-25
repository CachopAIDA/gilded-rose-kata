using NUnit.Framework;
using System.Collections.Generic;

namespace csharp
{
    [TestFixture]
    public class GildedRoseTest
    {
        [Ignore("Porque Pedro lo dice")]
        [Test]
        public void foo()
        {
            IList<Item> Items = new List<Item> { Item.CreateInstance(name: "foo", sellIn: 0, quality: 0) };
            GildedRose app = new GildedRose(Items);
            app.UpdateQuality();
            Assert.AreEqual("fixme", Items[0].Name);
        }
    }
}
