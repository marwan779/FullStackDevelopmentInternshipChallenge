using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FawryChallenge.Models
{
    public class Customer
    {
        public string Name { get; set; } = string.Empty;
        public double Balance { get; set; }
        public Customer(string name, double balance)
        {
            Name = name;
            Balance = balance;
        }
    }
}
