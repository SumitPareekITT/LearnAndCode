using SRP.Models;
using SRP.Services;
using SRP.Presentation;

namespace SRP
{
    class Program
    {
        static void Main(string[] args)
        {
            Shape rectangle = new Rectangle(10, 5);

            AreaCalculator calculator = new AreaCalculator();
            double area = calculator.CalculateArea(rectangle);

            AreaPrinter printer = new AreaPrinter();
            printer.Print(area);

            Console.ReadLine();
        }
    }
}
