
using FawryChallenge.Services.ShippingService;

namespace FawryChallenge.Models
{
    public class ShippableProduct : BaseProduct, IShippable
    {
        public double Weight { get; set; }
        public ShippableProduct(string name, int quantity, double price, double weight)
            : base(name, quantity, price)
        {
            Weight = weight;
        }

        public string GetName()
        {
           return Name;
        }

        public double GetWeight()
        {
            return Weight;
        }
    }
}
