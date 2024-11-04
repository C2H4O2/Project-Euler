using System;
using System.Collections.Generic;
using System.Linq;

public class Problem24
{
    public static void Main() {
        List<int> digits = Enumerable.Range(0, 10).ToList();
        List<List<int>> permutations = IteratePermutations(digits, new List<int>(), new List<List<int>>());

        List<int> millionthPermutation = permutations[999999];
        Console.WriteLine(string.Join("", millionthPermutation));
    }

    private static List<List<int>> IteratePermutations(List<int> digits, List<int> current, List<List<int>> result) {
        if (current.Count == digits.Count) {
            result.Add(new List<int>(current));
            return result;
        }

        foreach (var digit in digits.Where(d => !current.Contains(d))) {
            current.Add(digit);
            IteratePermutations(digits, current, result);
            current.RemoveAt(current.Count - 1);
        }

        return result;
    }
}
