using CheckoutKata.Core.Models;
using NUnit.Framework;

namespace CheckoutKata.UnitTests.BasketTests
{
    [TestFixture]
    public class AddItemTests
    {
        [Test]
        public void AddItem()
        {
            //Arrange
            var basket = Basket.Create();

            //Act
            basket.AddItem(Item.Create(10, "A"));

            //Assert
            Assert.IsNotEmpty(basket.Items);
        }

        [Test]
        public void ItemAdded_TotalPrice_Increased()
        {
            //Arrange
            var basket = Basket.Create();
            var item = Item.Create(10, "A");
            
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