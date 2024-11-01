using System;
using System.Numerics;

public class Problem20
{
    public static void Main() {
        double digitSum = 0;
        BigInteger factorial = Fact(100);
        Console.WriteLine(factorial);
        foreach (char digit in factorial.ToString())
            digitSum += int.Parse(digit.ToString());

        Console.WriteLine("The sum of the digits of 100! " + digitSum);
    }

    private static BigInteger Fact(int num) {
        if(num <= 1) {
            return 1;
        }
        else return num * Fact(num-1);
    }
}
