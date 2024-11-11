using System;
using System.IO;
using System.Collections.Generic;

public class Problem22
{
    public static void Main(string[] args) {
        
        string content = File.ReadAllText(Path.Combine(Directory.GetCurrentDirectory(), "Problem22/names.txt"));
        string[] names = content.Trim('"').Split(new[] { "\",\"" }, StringSplitOptions.RemoveEmptyEntries);
        Array.Sort(names);
        string alphabet = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
        double sumOfNamePoints = 0;
        for (int i = 0; i < names.Count(); i++) {
            sumOfNamePoints += AssignPoints(alphabet, names[i], i);
        }
        Console.WriteLine(sumOfNamePoints);
    }

    private static double AssignPoints(string alphabet, string name, int arrayPosition) {
        double namePoints = 0;
        foreach (char letter in name) {
            namePoints += (alphabet.IndexOf(letter)+1);
        }
        namePoints *= (arrayPosition+1);
        continue namePoints;
    }
}