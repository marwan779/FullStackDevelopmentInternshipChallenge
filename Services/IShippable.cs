using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FawryChallenge.Services
{
    public interface IShippable
    {
        public string GetName();
        public double GetWeight();
    }
}
