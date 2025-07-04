namespace FawryChallenge.Services
{
    public static class ShippingService
    {
        public static void GetShipmentNotice(List<IShippable> shippingList)
        {
            if(shippingList.Count == 0) return;

            var groupedItems = shippingList.GroupBy(i => i.GetName()).ToList();
            double totalWeight = 0;

            Console.WriteLine("** Shipment notice **");
            foreach ( var item in groupedItems)
            {
                Console.WriteLine($"{item.Count()}x {item.Key}");
                totalWeight += item.Sum(i => i.GetWeight());
            }

            Console.WriteLine($"Total package weight {totalWeight / 1000:F1}kg\n");

        }

        public static double CalculateShippingFees(List<IShippable> shippingList)
        {
            double totalWeight = shippingList.Sum(i => i.GetWeight());
            return Math.Ceiling(totalWeight / 100);
        }
    }
}
