using CreatorPlatform.Models;

namespace CreatorPlatform.Strategies
{
    public class AdRevenueStrategy : IEarningStrategy
    {
        public double RatePerView { get; set; } = 0.05;

        public double CalculateEarnings(Creator creator)
        {
            return creator.Views * RatePerView;
        }
    }
}