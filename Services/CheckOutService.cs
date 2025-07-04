using FawryChallenge.Models;
namespace FawryChallenge.Services
{
    public static class CheckOutService
    {
        public static void CheckOut(Customer customer, Cart cart)
        {
            if (cart.IsEmpty())
            {
                Console.WriteLine("Error: The cart is currently empty !");
                return;
            }

            double cartSubTotal = cart.OrderSubtotal();
            var shippingList = cart.GetShippables();
            double shippingFees = ShippingService.CalculateShippingFees(shippingList);

            double totalAmount = cartSubTotal + shippingFees;

            if (totalAmount > customer.Balance)
            {
                Console.WriteLine("Error: Insufficient balance.");
                return;
            }

            ShippingService.GetShipmentNotice(shippingList);

            //update customer balance
            customer.UpdateBalance(totalAmount);

            Console.WriteLine("** Checkout receipt **");
            foreach (CartItem item in cart.CartItems)
            {
                Console.WriteLine($"{item.Quantity}x {item.Product.Name}\t{item.ItemPrice()}");
            }

            Console.WriteLine("----------------------");
            Console.WriteLine($"Subtotal\t{cartSubTotal:F0}");
            Console.WriteLine($"Shipping\t{shippingFees:F0}");
            Console.WriteLine($"Amount\t\t{totalAmount:F0}");
            Console.WriteLine($"Balance left\t{customer.Balance:F0}");

        }
    }
}
