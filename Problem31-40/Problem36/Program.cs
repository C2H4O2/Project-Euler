using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        int sum = 0;
        for (int i = 1; i < 1000000; i++)
        {
            if(PalindromeCheck(i.ToString())){
                string binString = Convert.ToString(i, 2);
                if(PalindromeCheck(binString)) {
                    
                    sum += i;
                }
            }
            
        }
        Console.WriteLine(sum);    
        
    }

    private static int binToDec(int bin) {
        return Convert.ToInt32(bin.ToString(), 2);
    }

    private static bool PalindromeCheck(string testNum) {
        string reversed = new string(testNum.Reverse().ToArray());
        
        return testNum == reversed;
    }
}
