using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FawryChallenge.Models;
using FawryChallenge.Services;

namespace FawryChallenge.TestingClasses
{
    public static class TestingCases
    {
        public static void TestSuccessfulCheckout()
        {
            Console.WriteLine("\n--- Test: Successful Checkout ---");

            var customer = new Customer("TestUser", 1000);

            var cheese = new ExpirableShippableProduct("Cheese", 100, 5, 400, DateOnly.FromDateTime(DateTime.Today.AddDays(1)));
            var scratchCard = new BaseProduct("Scratch Card", 50, 10);

            var cart = new Cart();
            cart.Add(cheese, 2);
            cart.Add(scratchCard, 1);

            CheckOutService.CheckOut(customer, cart);
        }


        public static void TestAddMoreThanAvailable()
        {
            Console.WriteLine("\n--- Test: Add More Than Available ---");

            var cart = new Cart();
            var tv = new ShippableProduct("TV", 500, 2, 700);
            cart.Add(tv, 3);
        }

        public static void TestEmptyCartCheckout()
        {
            Console.WriteLine("\n--- Test: Empty Cart Checkout ---");

            var customer = new Customer("TestUser", 500);
            var cart = new Cart();

            CheckOutService.CheckOut(customer, cart);
        }

        public static void TestExpiredProduct()
        {
            Console.WriteLine("\n--- Test: Checkout With Expired Product ---");

            var customer = new Customer("TestUser", 500);
            var expiredMilk = new ExpirableProduct("Milk", 100, 2, DateOnly.FromDateTime(DateTime.Today.AddDays(-1)));

            var cart = new Cart();
            cart.Add(expiredMilk, 1);

            CheckOutService.CheckOut(customer, cart);
        }

        public static void TestInsufficientBalance()
        {
            Console.WriteLine("\n--- Test: Insufficient Balance ---");

            var customer = new Customer("PoorGuy", 100);
            var tv = new ShippableProduct("TV", 200, 1, 500);

            var cart = new Cart();
            cart.Add(tv, 1);

            CheckOutService.CheckOut(customer, cart); 
        }

        public static void TestMixedProductsCheckout()
        {
            Console.WriteLine("\n--- Test: Mixed Expirable & Shippable Products ---");

            var customer = new Customer("MixedCustomer", 2000);

            var cheese = new ExpirableShippableProduct("Cheese", 120, 3, 400, DateOnly.FromDateTime(DateTime.Today.AddDays(2)));
            var biscuits = new ExpirableProduct("Biscuits", 150, 2, DateOnly.FromDateTime(DateTime.Today.AddDays(2)));
            var tv = new ShippableProduct("TV", 600, 2, 1000);
            var scratchCard = new BaseProduct("Scratch Card", 50, 5);

            var cart = new Cart();
            cart.Add(cheese, 2);
            cart.Add(biscuits, 1);
            cart.Add(tv, 1);
            cart.Add(scratchCard, 1);

            CheckOutService.CheckOut(customer, cart);
        }

        public static void TestZeroQuantity()
        {
            Console.WriteLine("\n--- Test: Add Zero Quantity ---");

            var cart = new Cart();
            var product = new BaseProduct("TestItem", 100, 10);

            cart.Add(product, 0); 
        }

        public static void TestStockDecreasesAfterCheckout()
        {
            Console.WriteLine("\n--- Test: Stock Decreases After Checkout ---");

            var product = new BaseProduct("Battery", 30, 5);
            var customer = new Customer("Tester", 500);

            var cart = new Cart();
            cart.Add(product, 2);

            CheckOutService.CheckOut(customer, cart);

            Console.WriteLine($"Remaining stock for Battery: {product.Quantity} (Expected: 3)");
        }

        public static void TestNoShippingNeeded()
        {
            Console.WriteLine("\n--- Test: No Shippable Items ---");

            var customer = new Customer("DigitalOnly", 500);
            var scratchCard = new BaseProduct("Scratch Card", 100, 5);

            var cart = new Cart();
            cart.Add(scratchCard, 2);

            CheckOutService.CheckOut(customer, cart); 
        }

        public static void TestRepeatedProductCheckout()
        {
            Console.WriteLine("\n--- Test: Multiple Same Product ---");

            var customer = new Customer("RepeatBuyer", 1000);
            var tv = new ShippableProduct("TV", 300, 5, 800);

            var cart = new Cart();
            cart.Add(tv, 2);
            cart.Add(tv, 2); 

            CheckOutService.CheckOut(customer, cart);
        }

    }


}
