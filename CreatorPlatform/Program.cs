using System;
using CreatorPlatform.Models;
using CreatorPlatform.Strategies;

namespace CreatorPlatform
{
    class Program
    {
        static void Main()
        {
            var creator = new Creator(
                name: "Sumit",
                views: 10000,
                subscribers: 500,
                baseAmount: 2000
            );

            creator.AddEarningStrategy(new AdRevenueStrategy());
            creator.AddEarningStrategy(new SubscriptionStrategy());
            creator.AddEarningStrategy(new BrandDealStrategy());

            double earnings = creator.CalculateTotalEarnings();

            Console.WriteLine($"Total Earnings: ${earnings}");
        }
    }
}