using System;
using ISP.Interfaces;

namespace ISP.Machines
{
    public class SimplePrinter : IPrinter
    {
        public void Print()
        {
            Console.WriteLine("Printing document...");
        }
    }
}
