using System;
using System.Collections.Generic;

public class Problem5
{
    public static void Main(string[] args) {
        int target = 20;
        List<int> primes = Primes(target);
        Console.WriteLine(EvenlyDivisible(primes, target));
    }

    private static int EvenlyDivisible(List<int> primes, int target) {
        Dictionary<int, int> primePowers = new();
        
        foreach (var prime in primes)
            primePowers[prime] = 0;

        for (int i = 2; i <= target; i++) {
            var primeFactors = PrimeFactorsOf(primes, i);
            foreach (var (prime, power) in primeFactors) {
                if (primePowers[prime] < power)
                    primePowers[prime] = power;
            }
        }

        int result = 1;
        foreach (var primePower in primePowers)
            result *= (int)Math.Pow(primePower.Key, primePower.Value);

        return result;
    }

    private static List<Tuple<int, int>> PrimeFactorsOf(List<int> primes, int num) {
        var factors = new List<Tuple<int, int>>();
        foreach (var prime in primes) {
            int power = 0;
            while (num % prime == 0 && num != 1) {
                num /= prime;
                power++;
            }
            if (power > 0)
                factors.Add(Tuple.Create(prime, power));
        }
        return factors;
    }

    private static List<int> Primes(double boundary) {
        List<int> primes = new() { 2 };
        int inc = 3;

        while (inc < boundary) {
            bool isPrime = true;
            foreach (var prime in primes) {
                if (inc % prime == 0 || prime * prime > inc) {
                    if (inc % prime == 0) {
                        isPrime = false;
                    }
                    break;
                }
            }
            if (isPrime)
                primes.Add(inc);

            inc++;
        }

        return primes;
    }
}
