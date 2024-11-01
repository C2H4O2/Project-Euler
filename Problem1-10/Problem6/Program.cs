using System;

public class Problem6
{
    public static void Main(string[] args)
    {
        int endNum = 100;
        int diff = SumOfSquares(endNum)-SquareOfSum(endNum);
        Console.WriteLine(diff);
    }

    private static int SumOfSquares(int EndNum) {
        Console.WriteLine((EndNum)*(EndNum+1)*(2*EndNum+1)/6);
        return (EndNum)*(EndNum+1)*(2*EndNum+1)/6;
    }

    private static int SquareOfSum(int EndNum) {
        Console.WriteLine((EndNum)*(EndNum+1)*(EndNum)*(EndNum+1)/4);
        return (EndNum)*(EndNum+1)*(EndNum)*(EndNum+1)/4;
    }
}