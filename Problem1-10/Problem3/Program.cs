using System;

public class Problem3
{

    public static void Main(string[] args) {
        double target = 600851475143;
        List<int> primes = new List<int>();
        primes = Primes(Math.Sqrt(target));
        Console.WriteLine(LastFactor(primes, target));
    }

    private static int LastFactor(List<int> primes, double target) {
        primes.Reverse();
        int largestPrimeFactor = 0;
        foreach (int prime in primes) {
                if (target % prime == 0 || (prime * prime) > target) {
                    if (target % prime == 0) {
                        largestPrimeFactor = prime;
                        break;
                    }
                    break;
                }
            }
        return largestPrimeFactor;
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
        
        return primes;
    }
}