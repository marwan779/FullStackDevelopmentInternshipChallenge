using FawryChallenge.Models;

namespace FawryChallenge
{
    public class Program
    {
        static void Main(string[] args)
        {
            Customer customer = new Customer("Marwan Mohamed", 1000);

            var cheese = new ExpirableShippableProduct("Cheese", 100, 5, 400, DateOnly.FromDateTime(DateTime.Today.AddDays(1)));
            var biscuits = new ExpirableProduct("Biscuits", 150, 2, DateOnly.FromDateTime(DateTime.Today.AddDays(2)));
            var tv = new ShippableProduct("TV", 100, 3, 700);
            var scratchCard = new BaseProduct("Scratch Card", 50, 10);


        }
    }
}
