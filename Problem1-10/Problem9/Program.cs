using System;
using System.Collections.Generic;

public class Problem9
{
    public static void Main(string[] args) {
      Console.WriteLine(PythagTriple(1000));
    }


    private static double PythagTriple(int target) {
        for (int a = 0; a < (target/2); a++) {
            for (int b = 0; b < (target/2); b++) {
                double c = Math.Sqrt(a*a + b*b);
                if((c) < (target/2)) {
                    if(c%1 == 0) {
                        if(a+b+c == 1000) {
                            Console.WriteLine(a);
                            Console.WriteLine(b);
                            Console.WriteLine(c);
                            return a*b*c;
                        }
                    }
                }
            }
        }
        return 0;
    }
}
