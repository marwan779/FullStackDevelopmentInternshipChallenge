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


        //Will be overridden with the ExpirableProduct only
        public virtual bool IsExpired() => false;

        // Reduce the Quantity of the product after customer order
        public void ReduceQuantity(int orderedAmount) => Quantity -= orderedAmount;
    }
}
