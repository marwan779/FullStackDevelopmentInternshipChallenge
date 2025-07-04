namespace FawryChallenge.Models
{
    public class CartItem
    {
        BaseProduct Product;
        public int Amount { get; set; }
        public CartItem(BaseProduct product, int amount)
        {
            Product = product;
            Amount = amount;
        }

        //Calculate the total price of the cart Item
        public double ItemPrice() => Product.Price * Amount;
    }
}
