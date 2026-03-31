using OCP.Discounts;
using OCP.Services;

namespace OCP
{
    class Program
    {
        static void Main(string[] args)
        {
            double amount = 1000;

            IDiscount discount = new PercentageDiscount(10);
            // IDiscount discount = new NoDiscount();

            DiscountCalculator calculator = new DiscountCalculator();
            double finalAmount = calculator.Calculate(amount, discount);

            Console.WriteLine($"Final Amount: {finalAmount}");
            Console.ReadLine();
        }
    }
}
