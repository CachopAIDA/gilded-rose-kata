using System.Collections.Generic;

namespace GildedRoseKata
{
    public class GildedRose
    {
        private IList<Item> items;

        public GildedRose(IList<Item> items)
        {
            this.items = items;
        }

        public void UpdateQuality()
        {
            foreach (var item in items)
            {
                UpdateItem(item);
            }
        }

        private static void UpdateItem(Item item)
        {
            if (item.Name == "Aged Brie")
            {
                HandleAgedBrie(item);
            }
            else if (item.Name == "Backstage passes to a TAFKAL80ETC concert")
            {
                HandleBackstagePasses(item);
            }
            else if (item.Name == "Sulfuras, Hand of Ragnaros")
            {
                HandleSulfurasItem(item);
            }
            else
            {
                HandleDefaultItem(item);
            }
        }

        private static void HandleSulfurasItem(Item item)
        {

        }

        private static void HandleDefaultItem(Item item)
        {
            if (item.Quality > 0)
            {
                item.Quality = item.Quality - 1;
            }

            item.SellIn = item.SellIn - 1;

            if (item.SellIn < 0)
            {
                if (item.Quality > 0)
                {
                    item.Quality = item.Quality - 1;
                }
            }
        }

        private static void HandleBackstagePasses(Item item)
        {
            if (item.Quality < 50)
            {
                item.Quality = item.Quality + 1;

                if (item.SellIn < 11)
                {
                    if (item.Quality < 50)
                    {
                        item.Quality = item.Quality + 1;
                    }
                }

                if (item.SellIn < 6)
                {
                    if (item.Quality < 50)
                    {
                        item.Quality = item.Quality + 1;
                    }
                }
            }

            item.SellIn = item.SellIn - 1;

            if (item.SellIn < 0)
            {
                item.Quality = item.Quality - item.Quality;
            }
        }

        private static void HandleAgedBrie(Item item)
        {
            if (item.Quality < 50)
            {
                item.Quality = item.Quality + 1;
            }

            item.SellIn = item.SellIn - 1;

            if (item.SellIn < 0)
            {
                if (item.Quality < 50)
                {
                    item.Quality = item.Quality + 1;
                }
            }
        }
    }
}