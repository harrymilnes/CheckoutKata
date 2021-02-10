using System.Collections.Generic;
using System.Linq;
using CheckoutKata.Core.Promotions;

namespace CheckoutKata.Core.Models
{
    public class Basket
    {
        public static Basket Create()
        {
            return new Basket();
        }

        public void AddItem(Item item)
        {
            Items.Add(item);
        }

        public List<Item> Items { get; private set; } = new List<Item>();
        public decimal TotalPrice => GetTotalPriceFromItems();

        private decimal GetTotalPriceFromItems()
        {
            var basketTotalPrice = Items
                .Select(it => it.Price)
                .Sum();

            return ThreeForFortyPromotion.Process(basketTotalPrice, Items);
        }
    }
}