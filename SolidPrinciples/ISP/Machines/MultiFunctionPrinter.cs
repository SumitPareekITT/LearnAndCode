using System;
using ISP.Interfaces;

namespace ISP.Machines
{
    public class MultiFunctionPrinter : IPrinter, IScanner
    {
        public void Print()
        {
            Console.WriteLine("Printing document...");
        }

        public void Scan()
        {
            Console.WriteLine("Scanning document...");
        }
    }
}
