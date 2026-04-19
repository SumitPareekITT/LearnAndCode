using System;

namespace DivisorPairs.Services
{
    public class DivisorService
    {
        public int CountValidN(int k)
        {
            if (k <= 2)
                return 0;

            int[] divisors = new int[k + 1];

            for (int i = 1; i <= k; i++)
            {
                for (int j = i; j <= k; j += i)
                {
                    divisors[j]++;
                }
            }

            int count = 0;

            for (int n = 2; n < k; n++)
            {
                if (divisors[n] == divisors[n + 1])
                {
                    count++;
                }
            }

            return count;
        }
    }
}