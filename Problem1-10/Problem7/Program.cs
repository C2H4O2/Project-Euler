using System;

public class Problem7
{

    public static void Main(string[] args) {
        int target = 10001;
        List<int> primes = new List<int>();
        primes = Primes(target);
        Console.WriteLine(primes[target-1]);
    }

    private static List<int> Primes(int n)
    {
        int inc = 2;
        List<int> primes = new List<int>
        {
            2,
        };
        
        while(primes.Count <= n) {
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