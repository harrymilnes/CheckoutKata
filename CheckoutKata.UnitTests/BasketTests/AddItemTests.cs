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
    }
}