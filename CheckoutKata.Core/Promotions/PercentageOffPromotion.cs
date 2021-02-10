using System;
using System.Collections.Generic;
using System.Linq;
using CheckoutKata.Core.Constants;
using CheckoutKata.Core.Models;

namespace CheckoutKata.Core.Promotions
{
    public class PercentageOffPromotion : IPromotion
    {
        public decimal Process(decimal totalPrice, IEnumerable<Item> items)
        {
            var itemsTotalPrice = items
                .Where(it => it.Sku == ItemConstants.ItemDSku)
                .Select(it => it.Price)
                .Sum();

            var itemPairCount = items.Count(it => it.Sku == ItemConstants.ItemDSku);

            var pairCount = Math.Floor((decimal) (itemPairCount / 2));
            
            var totalPercentage = 25 * pairCount;
            
            var promotionDiscount = (decimal) itemsTotalPrice / 100 * totalPercentage;
            return totalPrice - promotionDiscount;
        }
    }
}