using System;
using System.Collections.Generic;

public class Problem15
{
    public static void Main(string[] args) {
        Console.WriteLine(LatticePaths(20));
    }

    private static double LatticePaths(int GridSize) {

        return Factorial(GridSize*2)/(Factorial(GridSize)*Factorial(GridSize));
    }

    private static double Factorial(int num) {
        if(num <= 1) {
            return 1;
        }
        else {
            return Factorial(num-1)*num;
        }
        
    }
    
}
