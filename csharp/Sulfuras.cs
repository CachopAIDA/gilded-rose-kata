namespace csharp {
    public class Sulfuras : Item {
        protected internal Sulfuras(string name, int sellIn, int quality) : base(name, sellIn, quality) { }

        public override void UpdateItemQuality() { }
    }
}