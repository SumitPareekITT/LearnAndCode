using SRP.Models;

namespace SRP.Services
{
    public class AreaCalculator
    {
        public double CalculateArea(Shape shape)
        {
            return shape.GetArea();
        }
    }
}
