using CheckoutKata.Core.Constants;
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
            const int itemPrice = 10;
            const string itemSku = ItemConstants.ItemASku;

            //Act
            var createdItem = Item.Create(itemPrice, itemSku);

            //Assert
            Assert.AreEqual(itemPrice, createdItem.Price);
        }
        
        [Test]
        public void SkuIsSet()
        {
            //Arrange
            const int itemPrice = 10;
            const string itemSku = ItemConstants.ItemASku;

            //Act
            var createdItem = Item.Create(itemPrice, itemSku);

            //Assert
            Assert.AreEqual(itemSku, createdItem.Sku);
        }
    }
}