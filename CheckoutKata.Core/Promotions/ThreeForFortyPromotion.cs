using System.Collections.Generic;
using System.Linq;
using CheckoutKata.Core.Models;

namespace CheckoutKata.Core.Promotions
{
    public class ThreeForFortyPromotion
    {
        public static decimal Process(decimal totalPrice, IEnumerable<Item> items)
        {
            var itemsTotalPrice = items
                .Where(it => it.Sku == "B")
                .Select(it => it.Price)
                .Sum();

            var promotionDiscount = 0;
            if (items.Count(it => it.Sku == "B") == 3)
            { 
                promotionDiscount = 40;
            }

            var priceDifference = itemsTotalPrice - promotionDiscount;
            return totalPrice - priceDifference;
        }
    }
}