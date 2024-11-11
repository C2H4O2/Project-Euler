using System;
using System.Numerics;
using System.Linq;
public class Problem28
{
    public static void Main(string[] args)
    {
        int[][] triangle = new int[][]
        {
            new int[] {75},
            new int[] {95, 64},
            new int[] {17, 47, 82},
            new int[] {18, 35, 87, 10},
            new int[] {20, 04, 82, 47, 65},
            new int[] {19, 01, 23, 75, 03, 34},
            new int[] {88, 02, 77, 73, 07, 63, 67},
            new int[] {99, 65, 04, 28, 06, 16, 70, 92},
            new int[] {41, 41, 26, 56, 83, 40, 80, 70, 33},
            new int[] {41, 48, 72, 33, 47, 32, 37, 16, 94, 29},
            new int[] {53, 71, 44, 65, 25, 43, 91, 52, 97, 51, 14},
            new int[] {70, 11, 33, 28, 77, 73, 17, 78, 39, 68, 17, 57},
            new int[] {91, 71, 52, 38, 17, 14, 91, 43, 58, 50, 27, 29, 48},
            new int[] {63, 66, 04, 68, 89, 53, 67, 30, 73, 16, 69, 87, 40, 31},
            new int[] {04, 62, 98, 27, 23, 09, 70, 98, 73, 93, 38, 53, 60, 04, 23}
        };
        
        for (int i = 0; i < (triangle.Length-1); i++)
        {
            triangle[i] = MergeDown(triangle[i], triangle[i+1]);
        }
        int maxSum = 0;
        foreach (var item in triangle[14])
        {
            if(item > maxSum) {
                maxSum = item;
            }
        }
        Console.WriteLine(maxSum);
        
    }

    private static int[] MergeDown(int[] row, int[] nextRow) {
        for (int i = 0; i < nextRow.Length; i++) {
            if(i == 0){
                nextRow[i] += row[i];
            }
            else if(i == row.Length){
                nextRow[i] += row[i-1];
            }
            else{
                nextRow[i] += Math.Max(row[i],row[i-1]);
            }
        }
        continue nextRow;
    }
}
