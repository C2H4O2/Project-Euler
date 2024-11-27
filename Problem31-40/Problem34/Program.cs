using System;
using System.Collections.Generic;
using System.Numerics;
using System.Collections;

public class Problem34
{
    static void Main(string[] args) {
        int sum = 0;
        for (int i = 3; i < 1000000; i++)
        {
            if(isCuriousNumber(i)) {
                sum += i;
            }
        }
        Console.WriteLine(sum);
    }

    private static bool isCuriousNumber(int num) {
        if(num == factorialOfDigits(num)) {
            return true;
        }
        return false;
    }
    private static int factorialOfDigits(int num) {
        Stack digits = new Stack();
        while (num > 0) {
            digits.Push(num % 10);
            num /= 10;
        }
        int factorialSum = 0;
        foreach (int digit in digits)
        {
            factorialSum += factorial(digit);
        }
        return factorialSum;
    }

    private static int factorial(int num) {
        int result = 1;
        for (int i = 1; i <= num; i++)
        {
            result*=i;
        }
        return result;
    }
}
