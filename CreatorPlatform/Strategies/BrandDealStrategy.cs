using CreatorPlatform.Models;

namespace CreatorPlatform.Strategies
{
    public class BrandDealStrategy : IEarningStrategy
    {
        public double CalculateEarnings(Creator creator)
        {
            return creator.BaseAmount;
        }
    }
}