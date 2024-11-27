using System;
using System.IO;
using System.Collections.Generic;

public class Problem23
{
    public static void Main(string[] args) {
        List<double> abundantNums = new List<double>();
        for (int i = 0; i < 28123; i++) {
            if(Abundant(i)) {
                abundantNums.Add(i);
            }
        }
        List<double> notSumsOfTwoAbundant = new List<double>();
        
        for (int i = 0; i < 28123; i++) {
            bool canBeWrittenAsAbundantSum = false;
            foreach (var num in abundantNums) {
                if (num >= i) {
                    break;
                }
                if(abundantNums.Contains(i-num)) {
                    canBeWrittenAsAbundantSum = true;
                    break;
                }
            }
            if (!canBeWrittenAsAbundantSum) {
                notSumsOfTwoAbundant.Add(i);
            }
        }
        Console.WriteLine(notSumsOfTwoAbundant.Sum());
        
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

    private static bool Abundant(double target) {
        return target < SumOfProperDivisors(target);
    }

}