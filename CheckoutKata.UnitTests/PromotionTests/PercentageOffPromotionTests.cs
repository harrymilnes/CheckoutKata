using System.Collections.Generic;
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
                Item.Create(55, "D"),
                Item.Create(55, "D"),
            };
     
            //Act
            var totalPriceAfterPromotion = new PercentageOffPromotion().Process(110, itemList);

            //Assert
            Assert.AreEqual(82.50, totalPriceAfterPromotion);
        }
        
        [Test]
        public void PercentageOffPromotion_SingularD_ReturnsTotalDiscountedPrice()
        {
            //Arrange
            var itemList = new List<Item>
            {
                Item.Create(55, "D"),
            };
     
            //Act
            var totalPriceAfterPromotion =  new PercentageOffPromotion().Process(55, itemList);

            //Assert
            Assert.AreEqual(55, totalPriceAfterPromotion);
        }
        
        [Test]
        public void PercentageOffPromotion_QuadD_ReturnsTotalDiscountedPrice()
        {
            //Arrange
            var itemList = new List<Item>
            {
                Item.Create(55, "D"),
                Item.Create(55, "D"),
                Item.Create(55, "D"),
                Item.Create(55, "D"),
            };
     
            //Act
            var totalPriceAfterPromotion =  new PercentageOffPromotion().Process(220, itemList);

            //Assert
            Assert.AreEqual(110, totalPriceAfterPromotion);
        }
    }
}