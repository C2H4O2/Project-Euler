using System;
using System.Collections.Generic;

public class Problem17
{
    public static void Main(string[] args) {
        List<string> OneToNine = new List<string> {
            "one", "two", "three", "four", "five", "six", "seven", "eight", "nine"
        };

        List<string> teenWords = new List<string> {
            "ten", "eleven", "twelve", "thirteen", "fourteen", "fifteen", "sixteen", "seventeen", "eighteen", "nineteen"
        };

        List<string> tyWords = new List<string> {
            "twenty", "thirty", "forty", "fifty", "sixty", "seventy", "eighty", "ninety"
        };

        List<string> hundredWords = new List<string> {
            "onehundred", "twohundred", "threehundred", "fourhundred", "fivehundred", "sixhundred", "sevenhundred", "eighthundred", "ninehundred"
        };

        List<string> thousandWords = new List<string> {
            "onethousand"
        };

        double totalCharacters = Characters(1000, OneToNine, teenWords, tyWords, hundredWords, thousandWords);
        Console.WriteLine(totalCharacters);
    }

    private static double SumOfCharacters(List<string> numList) {
        double sumOfChar = 0;
        foreach (var num in numList) {
            sumOfChar += num.Length;
        }
        return sumOfChar;
    }

    private static double Characters(int target, List<string> OneToNine, List<string> teenWords, List<string> tyWords, List<string> hundredWords, List<string> thousandWords) {
        double totalSum = 0;

        for (int i = 1; i <= target; i++) {
            if (i < 10) {
                totalSum += OneToNine[i - 1].Length;
            }
            else if (i < 20) {
                totalSum += teenWords[i - 10].Length;
            }
            else if (i < 100) {
                totalSum += tyWords[(i / 10) - 2].Length; // e.g., 20-90
                if (i % 10 != 0) {
                    totalSum += OneToNine[(i % 10) - 1].Length; // add units
                }
            }
            else if (i < 1000) {
                totalSum += hundredWords[(i / 100) - 1].Length; // e.g., 100-900
                if (i % 100 != 0) {
                    totalSum += "and".Length; // adding 'and'
                    if (i % 100 < 10) {
                        totalSum += OneToNine[i % 100 - 1].Length; // units
                    }
                    else if (i % 100 < 20) {
                        totalSum += teenWords[i % 100 - 10].Length; // teens
                    }
                    else {
                        totalSum += tyWords[((i % 100) / 10) - 2].Length; // tens
                        if (i % 10 != 0) {
                            totalSum += OneToNine[(i % 10) - 1].Length; // add units
                        }
                    }
                }
            }
            else {
                totalSum += thousandWords[0].Length;
            }
        }

        return totalSum;
    }
}
