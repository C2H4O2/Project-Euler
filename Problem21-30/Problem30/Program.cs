using System;
using System.Collections.Generic;
using System.Numerics;

public class Problem30
{
    public static void Main(string[] args)
    {
        int sum = 0;
        foreach (var num in SumOfFifth(295245))
        {
            sum += num;
        }
        Console.WriteLine(sum-1);
    }

    private static List<int> SumOfFifth(double x)
    {
        List<int> nums = new List<int>();
        for (int i = 0; i < x; i++)
        {
            string intString = i.ToString();
            int fifthSum = 0;

            foreach (var digit in intString)
            {
                fifthSum += (int)Math.Pow(int.Parse(digit.ToString()), 5);
            }

            if (fifthSum == i)
            {
                nums.Add(i);
            }
        }
        return nums;
    }
}
