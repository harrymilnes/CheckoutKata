using CheckoutKata.Core.Constants;
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
            var item = Item.Create(ItemConstants.ItemAPrice, ItemConstants.ItemASku);
            
            //Act
            basket.AddItem(item);

            //Assert
            Assert.IsNotEmpty(basket.Items);
        }
    }
}