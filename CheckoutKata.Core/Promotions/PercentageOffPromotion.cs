using System;
using System.Collections.Generic;
using System.Linq;
using CheckoutKata.Core.Models;

namespace CheckoutKata.Core.Promotions
{
    public class PercentageOffPromotion
    {
        public static decimal Process(decimal totalPrice, IEnumerable<Item> items)
        {
            var itemsTotalPrice = items
                .Where(it => it.Sku == "D")
                .Select(it => it.Price)
                .Sum();

            var itemPairCount = items.Count(it => it.Sku == "D");

            var pairCount = Math.Floor((decimal) (itemPairCount / 2));
            
            var totalPercentage = 25 * pairCount;
            
            var promotionDiscount = ((decimal) itemsTotalPrice / 100) * totalPercentage;
            return totalPrice - promotionDiscount;
        }
    }
}