using System.Collections.Generic;
using CheckoutKata.Core.Models;

namespace CheckoutKata.Core.Promotions
{
    public interface IPromotion
    {
        decimal Process(decimal totalPrice, IEnumerable<Item> items);
    }
}