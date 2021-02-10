using System.Collections.Generic;
using CheckoutKata.Core.Models;
using CheckoutKata.Core.Promotions;
using NUnit.Framework;

namespace CheckoutKata.UnitTests.PromotionTests
{
    [TestFixture]
    public class PromotionTests
    {
        [Test]
        public void ThreeForFortyPromotion_ReturnsBundlePrice()
        {
            //Arrange
            var itemList = new List<Item>
            {
                Item.Create(15, "B"),
                Item.Create(15, "B"),
                Item.Create(15, "B")
            };
     
            //Act
            var totalPriceAfterPromotion = ThreeForFortyPromotion.Process(45, itemList);

            //Assert
            Assert.AreEqual(40, totalPriceAfterPromotion);
        }
    }
}