using System;
using System.Collections.Generic;
using System.Numerics;

public class Problem42
{
    static void Main(string[] args) {
        Dictionary<char, int> letterNumberPair = new Dictionary<char, int>();
        string content = File.ReadAllText(Path.Combine(Directory.GetCurrentDirectory(), "Problem42/words.txt"));
        string[] words = content.Trim('"').Split(new[] { "\",\"" }, StringSplitOptions.RemoveEmptyEntries);
        string alphabet = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
        letterNumberPair = stringToDicitionary(alphabet);
        List<int> triangleNumbers = TriangleNumbers(26*45); //The longest word is 45 characters long
        HashSet<int> triangleNumbersSet = new HashSet<int>(triangleNumbers);
        int numberOfTriangleNumbersInTxt=0;
        foreach (string word in words) {
            if(triangleNumbersSet.Contains(wordToNumber(letterNumberPair, word))) {
                numberOfTriangleNumbersInTxt++;
            }
        }
        Console.WriteLine("Number of triangle Numbers in words" + numberOfTriangleNumbersInTxt);
    }

    private static List<int> TriangleNumbers(int boundary) {
    List<int> numbers = new List<int>();
    int n = 1;
    int result = n * (n + 1) / 2;

    while (result <= boundary) {
        numbers.Add(result);
        n++;
        result = n * (n + 1) / 2;
    }

    return numbers;
}

    private static int wordToNumber(Dictionary<char, int> letterNumberPair, string word) {
        int result = 0;
        foreach (char letter in word) {
            result += letterNumberPair[letter];
        }
        return result;
    }

    private static Dictionary<char, int> stringToDicitionary(string alphabet) {
        Dictionary<char, int> letterNumberPair = new Dictionary<char, int>();
        for (int i = 0; i < alphabet.Length; i++) {
            letterNumberPair.Add(alphabet[i], i+1);
        }
        return letterNumberPair;
        
    }

}

