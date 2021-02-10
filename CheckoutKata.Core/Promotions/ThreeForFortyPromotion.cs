using System.Collections.Generic;
using System.Linq;
using CheckoutKata.Core.Constants;
using CheckoutKata.Core.Models;

namespace CheckoutKata.Core.Promotions
{
    public class ThreeForFortyPromotion : IPromotion
    {
        public decimal Process(decimal totalPrice, IEnumerable<Item> items)
        {
            var itemsTotalPrice = items
                .Where(it => it.Sku == ItemConstants.ItemBSku)
                .Select(it => it.Price)
                .Sum();

            var promotionDiscount = 0;
            if (items.Count(it => it.Sku == ItemConstants.ItemBSku) == 3)
                promotionDiscount = 40;

            var priceDifference = itemsTotalPrice - promotionDiscount;
            return totalPrice - priceDifference;
        }
    }
}