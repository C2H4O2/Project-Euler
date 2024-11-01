﻿using System;

public class Problem2
{
    /*
    <p>Each new term in the Fibonacci sequence is generated by adding the previous two terms. By starting with $1$ and $2$, the first $10$ terms will be:
    $$1, 2, 3, 5, 8, 13, 21, 34, 55, 89, \dots$$</p>
    <p>By considering the terms in the Fibonacci sequence whose values do not exceed four million, find the sum of the even-valued terms.</p>
    */
    public static void Main(string[] args)
    {
        
        List<int> fibonacci = new List<int>
        {
            1,
            2
        };
        fibonacci = Fibo(fibonacci, 4000000);
        Console.WriteLine(EvenFibonacci(fibonacci, 4000000));
        
        
    }

    private static int EvenFibonacci(List<int> fibonacci, int boundary) {
        int index = 1;
        int sum = 0;
        while (index < fibonacci.IndexOf(fibonacci.Last()))
        {
            Console.WriteLine(fibonacci[index]);
            sum += fibonacci[index];
            index +=3;
        }
        return sum;
    }

    private static List<int> Fibo(List<int> fibonacci, int boundary)
    {
        int index = 2;
        while (fibonacci.Last() <= boundary) {     
            fibonacci.Add(fibonacci[index-1]+fibonacci[index-2]);
            index++;
        }
        return fibonacci;
    }

    
}
