namespace csharp
{
    public class Item
    {
        protected Item(string name, int sellIn, int quality) {
            Name = name;
            SellIn = sellIn;
            Quality = quality;
        }

        public static Item CreateInstance(string name, int sellIn, int quality) {
            if (name == "Aged Brie") {
                return new AgedBried(name, sellIn, quality);
            }

            if (name == "Backstage passes to a TAFKAL80ETC concert") {
                return new BackstagePasses(name, sellIn, quality);
            }

            if (name == "Sulfuras, Hand of Ragnaros") {
                return new Sulfuras(name, sellIn, quality);
            }

            return new Item(name, sellIn, quality);
        }

        public string Name { get; set; }
        public int SellIn { get; set; }
        public int Quality { get; set; }

        public override string ToString()
        {
            return this.Name + ", " + this.SellIn + ", " + this.Quality;
        }

        public virtual void UpdateItemQuality()
        {
            if (Quality > 0)
            {
                Quality -= 1;
            }

            SellIn -= 1;

            if (SellIn < 0)
            {
                if (Quality > 0)
                {
                    Quality -= 1;
                }
            }
        }
    }
}
