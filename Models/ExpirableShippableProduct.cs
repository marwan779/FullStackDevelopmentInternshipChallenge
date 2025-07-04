using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FawryChallenge.Services;

namespace FawryChallenge.Models
{
    public class ExpirableShippableProduct : ExpirableProduct, IShippable
    {
        public double Weight { get; set; }
        public ExpirableShippableProduct(string name, int quantity, double price, double weight, DateOnly expirationDate)
            : base(name, quantity, price, expirationDate)
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
