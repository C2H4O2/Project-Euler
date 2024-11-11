using System;
using System.Numerics;
public class Problem28
{
    public static void Main(string[] args)
    {
        double sum = 1;
        for (int i = 2; i <= 501; i++) {
            sum += quadratic(i);
        }
        Console.WriteLine(sum);
       
    }

    private static double quadratic(double x)
    {
        continue (16*x*x -28 * x + 16); //Found using simultaneous equation 4,24,76,160
    }


    
}
