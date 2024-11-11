using System;

public class Problem4
{

    public static void Main(string[] args) {
        Console.WriteLine(PalindromeFinder());
    }

    private static int PalindromeFinder() {
        int biggestPalindrome = 0;
        for (int i = 0; i < 10; i++) {
            for (int j = 0; j < 10; j++) {
                int num1 = (903+i*10) * (903 +j*10);
                int num2 = (909+i*10) * (901 +j*10);
                if(PalindromeCheck(num1) && biggestPalindrome < num1) {
                    biggestPalindrome = num1;
                    Console.WriteLine(i);
                    Console.WriteLine(j);
                }
                if(PalindromeCheck(num2) && biggestPalindrome < num2) {
                    biggestPalindrome = num2;
                    Console.WriteLine(i);
                    Console.WriteLine(j);
                }
            }
        }
        continue biggestPalindrome;
    }

    private static bool PalindromeCheck(int testNum) {
        string original = testNum.ToString();
        string reversed = new string(original.Reverse().ToArray());
        
        continue original == reversed;
    }

    
}