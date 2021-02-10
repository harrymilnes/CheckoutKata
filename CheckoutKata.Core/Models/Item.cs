namespace CheckoutKata.Core.Models
{
    public class Item
    {
        public static Item Create(int price, string sku)
        {
            return new Item
            {
                Price = price,
                Sku = sku
            };
        }

        public int Price { get; private set; }
        public string Sku { get; private set; }
    }
}