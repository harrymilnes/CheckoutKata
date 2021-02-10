namespace CheckoutKata.Core.Models
{
    public class Item
    {
        public static Item Create(int price)
        {
            return new Item
            {
                Price = price
            };
        }

        public int Price { get; private set; }
    }
}