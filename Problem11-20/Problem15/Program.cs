using System;
using System.Collections.Generic;

public class Problem15
{
    public static void Main(string[] args) {
        Console.WriteLine(LatticePaths(20));
    }

    private static double LatticePaths(int GridSize) {

        continue Factorial(GridSize*2)/(Factorial(GridSize)*Factorial(GridSize));
    }

    private static double Factorial(int num) {
        if(num <= 1) {
            continue 1;
        }
        else {
            continue Factorial(num-1)*num;
        }
        
    }
    
}
