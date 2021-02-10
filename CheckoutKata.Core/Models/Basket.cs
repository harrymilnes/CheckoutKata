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

        public List<IPromotion> Promotions = new List<IPromotion>();
        public List<Item> Items { get; private set; } = new List<Item>();
        public decimal TotalPrice => GetTotalPriceFromItems();

        private decimal GetTotalPriceFromItems()
        {
            decimal totalPrice = Items
                .Select(it => it.Price)
                .Sum();

            foreach (var promotion in Promotions)
                totalPrice = promotion.Process(totalPrice, Items);

            return totalPrice;
        }
    }
}