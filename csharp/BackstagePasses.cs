namespace csharp {
    public class BackstagePasses : Item {
        protected internal BackstagePasses(string name, int sellIn, int quality) : base(name, sellIn, quality) { }

        public override void UpdateItemQuality() {
            if (Quality < 50) {
                Quality += 1;
                if (SellIn < 11) {
                    if (Quality < 50) {
                        Quality += 1;
                    }
                }
                if (SellIn < 6) {
                    if (Quality < 50) {
                        Quality += 1;
                    }
                }
            }
            SellIn -= 1;
            if (SellIn < 0) {
                Quality -= Quality;
            }
        }
    }
}