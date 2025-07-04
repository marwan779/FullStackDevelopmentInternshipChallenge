using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FawryChallenge.Models
{
    public class ExpirableShippableProduct : ExpirableProduct
    {
        public double Weight { get; set; }
        public ExpirableShippableProduct(string name, int quantity, double price, double weight, DateOnly expirationDate)
            : base(name, quantity, price, expirationDate)
        {
            Weight = weight;
        }
    }
}
