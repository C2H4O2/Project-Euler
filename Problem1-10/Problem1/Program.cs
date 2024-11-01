using System;

public class Problem1
{
    //If we list all the natural numbers below $10$ that are multiples of $3$ or $5$, we get $3, 5, 6$ and $9$. The sum of these multiples is $23$.</p>
    //Find the sum of all the multiples of $3$ or $5$ below $1000$.</p>
    public static void Main(string[] args)
    {
        Console.WriteLine(SumOfMultiples(3,5,1000));
    }

    private static int SumOfMultiples(int num1, int num2, int boundary) {
        //number of multiples of num1 and num2, number of multiples of common factors double common multiples so - the multiples of both common multiples
        int lastMultiple1 = (boundary-1) / num1;
        int lastMultiple2 = (boundary-1) / num2;
        int lastCommonMultiple = (boundary-1) / (num1 * num2);
        // 5*1 + 5*2 + ... + 5*n = 5(1+2+ ... n) = 5(n(n+1)/2)

        return num1*(lastMultiple1*(lastMultiple1+1)/2) + num2*(lastMultiple2*(lastMultiple2+1)/2) - (num1*num2)*(lastCommonMultiple*(lastCommonMultiple+1)/2);
    }
}