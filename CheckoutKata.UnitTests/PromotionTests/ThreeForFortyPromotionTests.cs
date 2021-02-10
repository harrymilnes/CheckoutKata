using System.Collections.Generic;
using System.Linq;
using CheckoutKata.Core.Constants;
using CheckoutKata.Core.Models;
using CheckoutKata.Core.Promotions;
using NUnit.Framework;

namespace CheckoutKata.UnitTests.PromotionTests
{
    [TestFixture]
    public class ThreeForFortyPromotionTests
    {
        [Test]
        public void ThreeForFortyPromotion_ReturnsTotalDiscountedPrice()
        {
            //Arrange
            var itemList = new List<Item>
            {
                Item.Create(ItemConstants.ItemBPrice, ItemConstants.ItemBSku),
                Item.Create(ItemConstants.ItemBPrice, ItemConstants.ItemBSku),
                Item.Create(ItemConstants.ItemBPrice, ItemConstants.ItemBSku)
            };
            var itemListTotal = itemList.Select(it => it.Price).Sum();

            //Act
            var totalPriceAfterPromotion = new ThreeForFortyPromotion().Process(itemListTotal, itemList);

            //Assert
            Assert.AreEqual(40, totalPriceAfterPromotion);
        }
    }
}