using ISP.Interfaces;
using ISP.Machines;

namespace ISP
{
    class Program
    {
        static void Main(string[] args)
        {
            IPrinter printer = new SimplePrinter();
            printer.Print();

            IPrinter multiPrinter = new MultiFunctionPrinter();
            multiPrinter.Print();

            IScanner scanner = new MultiFunctionPrinter();
            scanner.Scan();

            Console.ReadLine();
        }
    }
}
