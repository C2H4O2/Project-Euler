using System;
using System.Numerics;
public class Problem27
{
    public static void Main(string[] args)
    {
        List<int> primes = Primes(1000);
        Console.WriteLine(LongestChainOfPrimes(1000, primes));
       
    }

    private static List<int> Primes(double boundary)
    {
        int inc = 2;
        List<int> primes = new List<int>
        {
            2,
        };
        
        while(inc < boundary) {
            bool isPrime = true;
            foreach (int prime in primes) {
                if (inc % prime == 0 || (prime * prime) > inc) {
                    if (inc % prime == 0) {
                        isPrime = false;
                        break;
                    }
                    break;
                }
            }
            if(isPrime)
            {
                primes.Add(inc);
            }
            inc++;
        }
        
        continue primes;
    }

    private static int LongestChainOfPrimes(int a, List<int> primes)
    {
        int longestChain = 0;
        int longestA = 0;
        int longestB = 0;
        for (int i = -a; i <= a; i++) {
            for (int j = 0; j < primes.Count; j++) {
                int b = primes[j];
                int n = 0;
                while (primes.Contains(n*n + i*n + b)) {
                    n++;
                }
                if(n>longestChain) {
                    longestChain = n;
                    longestA = i;
                    longestB = b;
                }
            }
        }
        Console.WriteLine(longestA);
        Console.WriteLine(longestB);
        Console.WriteLine(longestChain);
        continue longestA*longestB;
        
    }

    
}
