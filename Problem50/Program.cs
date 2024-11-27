using System;
using System.Collections.Generic;
using System.Numerics;

public class Problem50
{
    static void Main(string[] args)
    {
        List<double> primes = Primes(1000000);
        Console.WriteLine(sumOfConsecutivePrimes(primes, 1000000));
    }
    private static List<double> Primes(double boundary) {
        double inc = 2;
        List<double> primes = new List<double>
        {
            2,
        };
        
        while(inc < boundary) {
            bool isPrime = true;
            foreach (double prime in primes) {
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
        
        return primes;
    }

    private static double sumOfConsecutivePrimes(List<double> primes, double pEndpoint) {
        HashSet<double> primeSet = new HashSet<double>(primes);
        double highestSum = 0;
        int maxLength = 0;

        for (int i = 0; i < primes.Count; i++)
        {
            double sum = 0;
            for (int j = i; j < primes.Count; j++)
            {
                sum += primes[j];
                if (sum >= pEndpoint) break;

                if (primeSet.Contains(sum) && (j - i + 1) > maxLength)
                {
                    highestSum = sum;
                    maxLength = j - i + 1;
                }
            }
        }
        return highestSum;
    }
}
