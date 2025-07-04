namespace FawryChallenge.Models
{
    public class ExpirableProduct : BaseProduct
    {
        public DateOnly ExpirationDate { get; set; }
        public ExpirableProduct(string name, int quantity, double price, DateOnly expirationDate)
            : base(name, quantity, price)
        {
            ExpirationDate = expirationDate;
        }

        public override bool IsExpired() => ExpirationDate < DateOnly.FromDateTime(DateTime.Today);
    }

}
