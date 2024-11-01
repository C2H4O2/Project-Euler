using System;
using System.Collections.Generic;

public class Problem21
{
    public static void Main(string[] args)
    {
        Console.WriteLine(AmicableNumbersSum(10000));
        Console.WriteLine(SumOfProperDivisors(1));
    }



    private static double AmicableNumbersSum(int limit) {
        double sum = 0;
        for (int i = 0; i < limit; i++) {
            if(SumOfProperDivisors(SumOfProperDivisors(i)) == i && i != SumOfProperDivisors(i)) {
                    sum+=SumOfProperDivisors(i);
            }
        }
        return sum;
    }

    private static double SumOfProperDivisors(double target) {
        List<double> divisors = new List<double>();
        for (double i = 1; (i*i) <= target; i++) {
            if (target % i == 0) {
                divisors.Add(i);
                double pair = target/i;
                if(i != pair && pair != target) {
                    divisors.Add(pair);
                }
            }
        }
        double sum = 0;

        foreach (var num in divisors) {
            sum += num;
        }
        return sum;
    }
}