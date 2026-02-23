using System;
using System.Collections.Generic;
using System.Linq;
using ClassesAssignment.Models;

namespace ClassesAssignment.Services
{
    public class StatisticsCalculator
    {
        public void PrintStats(List<DataRecord> records)
        {
            Console.WriteLine("\n=== Statistics ===");
            Console.WriteLine($"Total Records: {records.Count}");
            Console.WriteLine($"Total Value: {records.Sum(r => r.Value)}");
            Console.WriteLine($"Average Value: {records.Average(r => r.Value):F2}");
        }
    }
}
