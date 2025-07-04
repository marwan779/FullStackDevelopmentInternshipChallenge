using FawryChallenge.Models;
using FawryChallenge.Services;
using FawryChallenge.TestingClasses;

namespace FawryChallenge
{
    public class Program
    {
        static void Main(string[] args)
        {
            //Customer customer = new Customer("Marwan Mohamed", 1000);

            //var cheese = new ExpirableShippableProduct("Cheese", 100, 5, 400, DateOnly.FromDateTime(DateTime.Today.AddDays(1)));
            //var biscuits = new ExpirableShippableProduct("Biscuits", 150, 2, 500, DateOnly.FromDateTime(DateTime.Today.AddDays(2)));
            //var tv = new ShippableProduct("TV", 100, 3, 700);
            //var scratchCard = new BaseProduct("Scratch Card", 50, 10);

            //Cart cart = new Cart();

            //cart.Add(cheese, 2);
            //cart.Add(biscuits, 1);
            //cart.Add(scratchCard, 1);

            //CheckOutService.CheckOut(customer, cart);


            TestingCases.TestSuccessfulCheckout();
            Console.WriteLine("\n\n");
            TestingCases.TestAddMoreThanAvailable();
            Console.WriteLine("\n\n");
            TestingCases.TestEmptyCartCheckout();
            Console.WriteLine("\n\n");
            TestingCases.TestExpiredProduct();
            Console.WriteLine("\n\n");
            TestingCases.TestInsufficientBalance();
            Console.WriteLine("\n\n");
            TestingCases.TestMixedProductsCheckout();
            Console.WriteLine("\n\n");
            TestingCases.TestZeroQuantity();
            Console.WriteLine("\n\n");
            TestingCases.TestStockDecreasesAfterCheckout();
            Console.WriteLine("\n\n");
            TestingCases.TestNoShippingNeeded();
            Console.WriteLine("\n\n");
            TestingCases.TestRepeatedProductCheckout();
        }
    }
}
