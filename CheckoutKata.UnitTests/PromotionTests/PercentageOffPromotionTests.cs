using System.Collections.Generic;
using System.Linq;
using CheckoutKata.Core.Constants;
using CheckoutKata.Core.Models;
using CheckoutKata.Core.Promotions;
using NUnit.Framework;

namespace CheckoutKata.UnitTests.PromotionTests
{
    [TestFixture]
    public class PercentageOffPromotionTests
    {
        [Test]
        public void PercentageOffPromotion_MultipleD_ReturnsTotalDiscountedPrice()
        {
            //Arrange
            var itemList = new List<Item>
            {
                Item.Create(ItemConstants.ItemDPrice, ItemConstants.ItemDSku),
                Item.Create(ItemConstants.ItemDPrice, ItemConstants.ItemDSku),
            };
            var itemListTotal = itemList.Select(it => it.Price).Sum();
     
            //Act
            var totalPriceAfterPromotion = new PercentageOffPromotion().Process(itemListTotal, itemList);

            //Assert
            Assert.AreEqual(82.50, totalPriceAfterPromotion);
        }
        
        [Test]
        public void PercentageOffPromotion_SingularD_ReturnsTotalDiscountedPrice()
        {
            //Arrange
            var itemList = new List<Item>
            {
                Item.Create(ItemConstants.ItemDPrice, ItemConstants.ItemDSku),
            };
     
            //Act
            var totalPriceAfterPromotion =  new PercentageOffPromotion().Process(ItemConstants.ItemDPrice, itemList);

            //Assert
            Assert.AreEqual(ItemConstants.ItemDPrice, totalPriceAfterPromotion);
        }
        
        [Test]
        public void PercentageOffPromotion_QuadD_ReturnsTotalDiscountedPrice()
        {
            //Arrange
            var itemList = new List<Item>
            {
                Item.Create(ItemConstants.ItemDPrice, ItemConstants.ItemDSku),
                Item.Create(ItemConstants.ItemDPrice, ItemConstants.ItemDSku),
                Item.Create(ItemConstants.ItemDPrice, ItemConstants.ItemDSku),
                Item.Create(ItemConstants.ItemDPrice, ItemConstants.ItemDSku),
            };
            var itemListTotal = itemList.Select(it => it.Price).Sum();

            //Act
            var totalPriceAfterPromotion =  new PercentageOffPromotion().Process(itemListTotal, itemList);

            //Assert
            Assert.AreEqual(110, totalPriceAfterPromotion);
        }
    }
}