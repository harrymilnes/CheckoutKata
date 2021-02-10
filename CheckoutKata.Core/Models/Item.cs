namespace CheckoutKata.Core.Models
{
    public class Item
    {
        public int Price { get; private init; }
        public string Sku { get; private init; }
        
        public static Item Create(int price, string sku)
        {
            return new Item
            {
                Price = price,
                Sku = sku
            };
        }
    }
}