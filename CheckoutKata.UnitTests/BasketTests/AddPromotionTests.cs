using CheckoutKata.Core.Models;
using CheckoutKata.Core.Promotions;
using NUnit.Framework;

namespace CheckoutKata.UnitTests.BasketTests
{
    [TestFixture]
    public class AddPromotionTests
    {
        [Test]
        public void ThreeForFortyPromotionAdded()
        {
            //Arrange
            var basket = new Basket();

            //Act
            basket.AddPromotion(new ThreeForFortyPromotion());

            //Assert
            Assert.IsNotEmpty(basket.Promotions);
        }
        
        [Test]
        public void PercentageOffPromotionAdded()
        {
            //Arrange
            var basket = new Basket();

            //Act
            basket.AddPromotion(new PercentageOffPromotion());

            //Assert
            Assert.IsNotEmpty(basket.Promotions);
        }
    }
}