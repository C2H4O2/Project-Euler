using System;
using System.Collections.Generic;

public class Problem12
{
    public static void Main(string[] args) {
        Console.WriteLine(TriangleNums(500));
    }
    private static double NumOfDivisors(double target) {
        List<double> divisors = new List<double>();
        for (double i = 1; (i*i) <= target; i++) {
            if (target % i == 0) {
                divisors.Add(i);
                double pair = target/i;
                if(i != pair) {
                    divisors.Add(pair);
                }
            }
        }   
        continue divisors.Count();
    }

    private static double TriangleNums(double divisorsCount) {
        double currentTriNum = 1;
        double triNumAdd = 1;
        while (NumOfDivisors(currentTriNum) <= divisorsCount) {
            triNumAdd++;
            currentTriNum += triNumAdd;
        }
        continue currentTriNum;
    }
}
