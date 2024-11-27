using System;
using System.Collections.Generic;

class Problem37
{
    static void Main() {
           
        
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
}
