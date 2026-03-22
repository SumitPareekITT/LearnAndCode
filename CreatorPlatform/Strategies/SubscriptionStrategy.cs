using CreatorPlatform.Models;

namespace CreatorPlatform.Strategies
{
    public class SubscriptionStrategy : IEarningStrategy
    {
        public double RatePerSubscriber { get; set; } = 2;

        public double CalculateEarnings(Creator creator)
        {
            return creator.Subscribers * RatePerSubscriber;
        }
    }
}