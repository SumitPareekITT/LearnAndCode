namespace OCP.Discounts
{
    public class NoDiscount : IDiscount
    {
        public double ApplyDiscount(double amount)
        {
            return amount;
        }
    }
}
