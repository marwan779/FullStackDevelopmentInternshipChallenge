using FawryChallenge.Services.ShippingService;

namespace FawryChallenge.Models
{
    public class Cart
    {
        public List<CartItem> CartItems { get; set; } = new List<CartItem>();

        public void Add(BaseProduct product, int amount)
        {
            if(product.Quantity < amount)
            {
                Console.WriteLine($"Error: Cannot add {amount} of {product.Name}. Only {product.Quantity} available.");
                return;
            }
            if (product.IsExpired())
            {
                Console.WriteLine($"Error: Cannot add {product.Name} because it is expired.");
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

        //Collect the Shippable items
        public List<IShippable> GetShippables()
        {
            List<IShippable> shippables = new List<IShippable>();

            if (IsEmpty())
            {
                Console.WriteLine("Error: The cart is currently empty !");
            }
            else
            {
                foreach (CartItem item in CartItems)
                {
                    if(item.Product is IShippable shippable)
                    {
                        for(int i = 0; i < item.Quantity; i++)
                        {
                            shippables.Add(shippable);
                        }
                    }
                }
            }

            return shippables;
        }
    }
}
