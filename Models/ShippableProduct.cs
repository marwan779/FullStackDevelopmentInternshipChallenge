using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FawryChallenge.Models
{
    public class ShippableProduct : BaseProduct
    {
        public double Weight { get; set; }
        public ShippableProduct(string name, int quantity, double price, double weight)
            : base(name, quantity, price)
        {
            Weight = weight;
        }



    }
}
