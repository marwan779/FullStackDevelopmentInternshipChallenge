using FawryChallenge.Models;
using FawryChallenge.Services;

namespace FawryChallenge
{
    public class Program
    {
        static void Main(string[] args)
        {
            Customer customer = new Customer("Marwan Mohamed", 1000);

            var cheese = new ExpirableShippableProduct("Cheese", 100, 5, 400, DateOnly.FromDateTime(DateTime.Today.AddDays(1)));
            var biscuits = new ExpirableShippableProduct("Biscuits", 150, 2, 500, DateOnly.FromDateTime(DateTime.Today.AddDays(2)));
            var tv = new ShippableProduct("TV", 100, 3, 700);
            var scratchCard = new BaseProduct("Scratch Card", 50, 10);

            Cart cart = new Cart();

            cart.Add(cheese, 2);
            cart.Add(biscuits, 1);
            cart.Add(scratchCard, 1);

            CheckOutService.CheckOut(customer, cart);
        }
    }
}
