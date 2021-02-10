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
            var itemSku = "A";

            //Act
            var createdItem = Item.Create(itemPrice, itemSku);

            //Assert
            Assert.AreEqual(itemPrice, createdItem.Price);
        }
        
        [Test]
        public void SkuIsSet()
        {
            //Arrange
            var itemPrice = 10;
            var itemSku = "A";

            //Act
            var createdItem = Item.Create(itemPrice, itemSku);

            //Assert
            Assert.AreEqual(itemSku, createdItem.Sku);
        }
    }
}