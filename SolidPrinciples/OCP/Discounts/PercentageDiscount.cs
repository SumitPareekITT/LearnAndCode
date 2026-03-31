namespace OCP.Discounts
{
    public class PercentageDiscount : IDiscount
    {
        private readonly double _percentage;

        public PercentageDiscount(double percentage)
        {
            _percentage = percentage;
        }

        public double ApplyDiscount(double amount)
        {
            return amount - (amount * _percentage / 100);
        }
    }
}
