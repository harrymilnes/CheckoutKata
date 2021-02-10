using System.Collections.Generic;
using System.Linq;
using CheckoutKata.Core.Promotions;

namespace CheckoutKata.Core.Models
{
    public class Basket
    {
        public readonly List<IPromotion> Promotions = new();
        public List<Item> Items { get; } = new();
        public decimal TotalPrice => GetTotalPriceFromItems();
        
        public static Basket Create()
        {
            return new Basket();
        }

        public void AddItem(Item item)
        {
            Items.Add(item);
        }

        private decimal GetTotalPriceFromItems()
        {
            decimal totalPrice = Items
                .Select(it => it.Price)
                .Sum();

            foreach (var promotion in Promotions)
                totalPrice = promotion.Process(totalPrice, Items);

            return totalPrice;
        }

        public void AddPromotion(IPromotion promotion)
        {
            Promotions.Add(promotion);
        }
    }
}