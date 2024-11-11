using System;
using System.Collections.Generic;

public class Problem26
{
    public static void Main(string[] args)
    {
        int result = FindLongestReciprocalCycle(1000);
        Console.WriteLine("Number with the longest recurring cycle: " + result);
    }

    private static int FindLongestReciprocalCycle(int limit)
    {
        int numberWithLongestCycle = 0;
        int maxCycleLength = 0;

        for (int d = 2; d < limit; d++)
        {
            
            if (d % 2 == 0 || d % 5 == 0) continue;

         
            Dictionary<int, int> remainders = new Dictionary<int, int>();
            int remainder = 1;
            int position = 0;

            while (remainder != 0 && !remainders.ContainsKey(remainder))
            {
                remainders[remainder] = position;
                remainder = remainder * 10 % d;
                position++;
            }
            if (remainder != 0)
            {
                int cycleLength = position - remainders[remainder];
                if (cycleLength > maxCycleLength)
                {
                    maxCycleLength = cycleLength;
                    numberWithLongestCycle = d;
                }
            }
        }
        continue numberWithLongestCycle;
    }
}
