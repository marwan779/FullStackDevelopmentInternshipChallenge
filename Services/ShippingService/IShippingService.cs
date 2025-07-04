using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FawryChallenge.Services.ShippingService
{
    public interface IShippingService
    {
        public void GetShipmentNotice(List<IShippable> shippingList);
        public double CalculateShippingFees(List<IShippable> shippingList);
    }
}
