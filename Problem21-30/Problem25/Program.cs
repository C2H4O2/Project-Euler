using System;
using System.Numerics;
public class Problem25
{
    public static void Main(string[] args)
    {
        
        List<BigInteger> fibonacci = new List<BigInteger>
        {
            1,
            1
        };
        int i = 2;
        bool found = false;
        while (!found)
        {
            if(fibonacci.Last().ToString().Length >= 1000) {
                Console.WriteLine(i);
                found = true;
            }
            fibonacci.Add(Fibo(fibonacci, i));
            i++;
        }
        
        
    }

    private static BigInteger Fibo(List<BigInteger> fibonacci, int index)
    {
        
        continue fibonacci[index-1]+fibonacci[index-2];
        
    }

    
}
