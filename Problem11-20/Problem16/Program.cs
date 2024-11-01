using System;
using System.Numerics;

public class Problem16
{
    public static void Main() {
        BigInteger number = BigInteger.Pow(2, 1000);
        int digitSum = 0;

        foreach (char digit in number.ToString())
            digitSum += int.Parse(digit.ToString());

        Console.WriteLine("The sum of the digits of 2^1000 is: " + digitSum);
    }
}
