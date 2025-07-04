namespace FawryChallenge.Models
{
    public class Cart
    {
        public List<CartItem> CartItems { get; set; } = new List<CartItem>();

        public void Add(BaseProduct product, int amount)
        {
            if(product.Quantity < amount)
            {
                Console.WriteLine($"Cannot add {amount} of {product.Name}. Only {product.Quantity} available.");
                return;
            }
            if (product.IsExpired())
            {
                Console.WriteLine($"Cannot add {product.Name} because it is expired.");
                return;
            }

            CartItems.Add(new CartItem(product, amount));
        }
        
        // Checks if the cart is empty 
        public bool IsEmpty() => CartItems.Count == 0;

        // Calculate the Order Subtotal
        public double OrderSubtotal()
        {
            if(IsEmpty()) return 0;

            double total = 0;
            foreach (CartItem item in CartItems)
            {
                total += item.ItemPrice();
            }

            return total;
        }
    }
}
