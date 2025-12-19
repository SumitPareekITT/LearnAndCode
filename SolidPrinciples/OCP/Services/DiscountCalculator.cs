using OCP.Discounts;

namespace OCP.Services
{
    public class DiscountCalculator
    {
        public double Calculate(double amount, IDiscount discount)
        {
            return discount.ApplyDiscount(amount);
        }
    }
}
