using CreatorPlatform.Models;

namespace CreatorPlatform.Strategies
{
    public interface IEarningStrategy
    {
        double CalculateEarnings(Creator creator);
    }
}