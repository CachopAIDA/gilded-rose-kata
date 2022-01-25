namespace csharp {
    public class AgedBried : Item {
        protected internal AgedBried(string name, int sellIn, int quality) : base(name, sellIn, quality) { }

        public override void UpdateItemQuality() {
            if (Quality < 50) {
                Quality += 1;
            }

            SellIn -= 1;

            if (SellIn < 0) {
                if (Quality < 50) {
                    Quality += 1;
                }
            }
        }
    }
}