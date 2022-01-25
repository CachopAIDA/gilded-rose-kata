namespace csharp
{
    public class Item
    {
        public string Name { get; set; }
        public int SellIn { get; set; }
        public int Quality { get; set; }

        public override string ToString()
        {
            return this.Name + ", " + this.SellIn + ", " + this.Quality;
        }

        public void UpdateItemQuality()
        {
            if (Name == "Aged Brie")
            {
                if (Quality < 50)
                {
                    Quality += 1;
                }

                SellIn -= 1;

                if (SellIn < 0)
                {
                    if (Quality < 50)
                    {
                        Quality += 1;
                    }
                }
            }
            else if (Name == "Backstage passes to a TAFKAL80ETC concert")
            {
                if (Quality < 50)
                {
                    Quality += 1;
                    if (SellIn < 11)
                    {
                        if (Quality < 50)
                        {
                            Quality += 1;
                        }
                    }
                    if (SellIn < 6)
                    {
                        if (Quality < 50)
                        {
                            Quality += 1;
                        }
                    }
                }
                SellIn -= 1;
                if (SellIn < 0)
                {
                    Quality -= Quality;
                }
            }
            else if (Name == "Sulfuras, Hand of Ragnaros")
            {
            }
            else
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
}
