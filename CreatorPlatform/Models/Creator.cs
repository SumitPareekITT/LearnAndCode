using System.Collections.Generic;
using CreatorPlatform.Strategies;

namespace CreatorPlatform.Models
{
    public class Creator
    {
        private readonly List<IEarningStrategy> earningStrategies = new();

        public string Name { get; private set; }
        public int Views { get; private set; }
        public int Subscribers { get; private set; }
        public double BaseAmount { get; private set; }

        public Creator(string name, int views, int subscribers, double baseAmount)
        {
            Name = name;
            Views = views;
            Subscribers = subscribers;
            BaseAmount = baseAmount;
        }

        public void AddEarningStrategy(IEarningStrategy strategy)
        {
            earningStrategies.Add(strategy);
        }

        public double CalculateTotalEarnings()
        {
            double total = 0;

            foreach (var strategy in earningStrategies)
            {
                total += strategy.CalculateEarnings(this);
            }

            return total;
        }
    }
}