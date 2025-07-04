namespace FawryChallenge.Models
{
    public class BaseProduct
    {
        public string Name { get; set; }
        public int Quantity { get; set; }
        public double Price { get; set; }

        public BaseProduct(string name, int quantity, double price)
        {
            Name = name;
            Quantity = quantity;
            Price = price;
        }


        //Will be overridden by the ExpirableProduct
        public virtual bool IsExpired() => false;

        // Reduce the Quantity of the product after customer order
        public void ReduceQuantity(int orderedAmount)
        {
            if (orderedAmount < 0)
            {
                Console.WriteLine("Error: Ordered amount can't be negative !");
                return;
            }
            if (orderedAmount > Quantity)
            {
                Console.WriteLine("Error: Ordered amount exceeds the available quantity !");
                return;
            }

            Quantity -= orderedAmount;
        }
    }
}
