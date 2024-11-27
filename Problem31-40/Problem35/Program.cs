using System;
using System.Collections.Generic;
using System.Numerics;

public class Problem35
{
    static void Main(string[] args) {
        List<double> primes = Primes(1000000);
        Console.WriteLine(allRotationsPrime(primes));
    }

    private static int allRotationsPrime(List<double> primes) {
        int counter = 0;
        HashSet<double> primeSet = new HashSet<double>(primes);

        for (int i = 0; i < primes.Count(); i++) {
            bool allPrime = true;
            for (int j = 0; j < primes[i].ToString().Length; j++) {
                if(!primeSet.Contains(RotateByN((int)primes[i], j))) {
                    allPrime = false;
                    break;
                }
            }
            if (allPrime) {
                counter++;
            }
        }
        return counter;
    }


    private static int RotateByN(int num, int n) {
        string numString = num.ToString();
        string startPart = numString.Substring(0, numString.Length - n);
        string endPart = numString.Substring(numString.Length - n, n);
        

        string rotatedString = endPart + startPart;

        return Int32.Parse(rotatedString);
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

