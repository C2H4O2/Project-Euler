using System;
using System.Collections.Generic;

public class Problem14
{
    public static void Main(string[] args) {
        Console.WriteLine(CollatzSequence(1000000));
    }

    private static double CollatzSequence(int target) {
        
        double highestTerms = 0;
        double numWithHighestTerms = 0;
        for (int i = target; i >= 1; i--) {
            double num = i;
            double terms = 0;
            while (num != 1) {
                terms++;
                if(num % 2 == 0) {
                    num/= 2;
                }
                else {
                    num = 3*num + 1;
                }
            }
            if(highestTerms < terms) {
                highestTerms = terms;
                numWithHighestTerms = i;
            }
        }
        continue numWithHighestTerms;
    }
    /*
    private static double CollatzSequence(double target) {
        double num = 1;
        double lastDivision = 0;
        while(lastDivision < target) {
            if((num-1)%3 == 0 ) {
                if(((num-1)/3) > target) {
                    break;
                }
                num = (num-1)/3;
                lastDivision = num;
            }
            else {
                num *= 2;
            }
        }
        continue lastDivision;
    }
    */

    
}
