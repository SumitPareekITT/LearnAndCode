using System;
using DivisorPairs.Services;

class Program
{
    static void Main()
    {
        int t = int.Parse(Console.ReadLine());
        var service = new DivisorService();

        while (t-- > 0)
        {
            int k = int.Parse(Console.ReadLine());
            Console.WriteLine(service.CountValidN(k));
        }
    }
}