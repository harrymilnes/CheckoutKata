using CheckoutKata.Core.Models;
using NUnit.Framework;

namespace CheckoutKata.UnitTests.ItemTests
{
    [TestFixture]
    public class ItemCreateTests
    {
        [Test]
        public void PriceIsSet()
        {
            //Arrange
            var itemPrice = 10;

            //Act
            var createdItem = Item.Create(itemPrice);

            //Assert
            Assert.AreEqual(itemPrice, createdItem.Price);
        }
    }
}