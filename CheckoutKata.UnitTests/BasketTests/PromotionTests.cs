using CheckoutKata.Core.Models;
using NUnit.Framework;

namespace CheckoutKata.UnitTests.BasketTests
{
    [TestFixture]
    public class PromotionTests
    {
        [Test]
        public void ItemBundleOffer()
        {
            //Arrange
            var basket = Basket.Create();
            var item = Item.Create(15, "B");

            basket.AddItem(item);
            basket.AddItem(item);
            basket.AddItem(item);
            
            //Act
            basket.ApplyPromotions(basket.TotalPrice);

            //Assert
            Assert.AreEqual(40, basket.TotalPrice);
        }
    }
}