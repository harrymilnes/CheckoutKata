using CheckoutKata.Core.Constants;
using CheckoutKata.Core.Models;
using NUnit.Framework;

namespace CheckoutKata.UnitTests.BasketTests
{
    [TestFixture]
    public class TotalPriceTests
    {
        [Test]
        public void ItemAdded_TotalPrice_Increased()
        {
            //Arrange
            var basket = Basket.Create();
            var item = Item.Create(ItemConstants.ItemAPrice, ItemConstants.ItemASku);
            
            //Act
            basket.AddItem(item);
            
            //Assert
            Assert.AreEqual(item.Price, basket.TotalPrice);
        }
        
        [Test]
        public void NoItems_TotalPrice_IsZero()
        {
            //Arrange
            var basket = Basket.Create();
            
            //Assert
            Assert.AreEqual(0, basket.TotalPrice);
        }
    }
}