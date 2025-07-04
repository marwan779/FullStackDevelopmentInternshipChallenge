namespace FawryChallenge.Models
{
    public class CartItem
    {
        public BaseProduct Product;
        public int Quantity { get; set; }
        public CartItem(BaseProduct product, int quantity)
        {
            Product = product;
            Quantity = quantity;
        }

        //Calculate the total price of the cart Item
        public double ItemPrice() => Product.Price * Quantity;
    }
}
