using System.Collections.Generic;
using System.Linq;

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
            return Items
                .Select(it => it.Price)
                .Sum();
        }
    }
}