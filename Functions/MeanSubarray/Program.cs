using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MeanSubarray
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter number of elements and number of queries (N Q):");
            var firstLine = ReadInts();
            int numberOfElements = firstLine[0];
            int numberOfQueries = firstLine[1];

            Console.WriteLine("Enter the array elements:");
            long[] numbers = ReadLongs();

            long[] prefix = PrefixSumBuilder.Create(numbers);

            Console.WriteLine("Enter the queries (L R):");
            while (numberOfQueries-- > 0)
            {
                var range = ReadInts();
                int left = range[0];
                int right = range[1];

                long mean = MeanCalculator.GetFloorMean(prefix, left, right);
                Console.WriteLine(mean);
            }
        }

        private static int[] ReadInts()
        {
            return Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
        }

        private static long[] ReadLongs()
        {
            return Array.ConvertAll(Console.ReadLine().Split(), long.Parse);
        }
    }

    class PrefixSumBuilder
    {
        public static long[] Create(long[] data)
        {
            long[] prefix = new long[data.Length + 1];

            for (int index = 0; index < data.Length; index++)
            {
                prefix[index + 1] = prefix[index] + data[index];
            }

            return prefix;
        }
    }

    class MeanCalculator
    {
        public static long GetFloorMean(long[] prefixSum, int leftIndex, int rightIndex)
        {
            long subarraySum = prefixSum[rightIndex] - prefixSum[leftIndex - 1];
            int subarrayLength = rightIndex - leftIndex + 1;

            return subarraySum / subarrayLength;
        }
    }
}