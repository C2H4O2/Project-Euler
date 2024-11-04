using System;
using System.Numerics;
using System.Linq;
public class Problem28
{
    public static void Main(string[] args)
    {
        Console.WriteLine(allPowers(100,100).Count);
       
    }

    private static List<BigInteger> allPowers(int a, int b)
    {
        List<BigInteger> powers = new List<BigInteger>();
        for (int i = 2; i <= a; i++)
        {
            for (int j = 2; j <= b; j++)
            {
                powers.Add((BigInteger)Math.Pow(i,j));
            }
        }
        powers.Sort();
        return powers.Distinct().ToList();
    }


    
}
