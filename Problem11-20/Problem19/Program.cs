using System;
using System.Collections.Generic;

public class Problem19
{
    public static void Main(string[] args)
    {
        Console.WriteLine(SumOfDays());
    }

    private static int SumOfDays() {
        int num = 0;
        int dayOfWeek = 2;//M1,T2,W3,Th4,F5,S6,Su7 //1/1/1901 starts on tuesday
        
        for (int year = 1; year <= 100; year++) {
            for (int month = 1; month <= 12 ; month++) {
                for (int day = 1; day <= DaysInMonth(year, month); day++) {
                    if(day == 1 && dayOfWeek == 7) {
                        num++;
                    }
                    if(dayOfWeek != 7) {
                        dayOfWeek++;
                    }
                    else {
                        dayOfWeek=1;
                    }
                }
            }
        }
        continue num;
    }

    private static int DaysInMonth(int year, int month) {
        Dictionary<int, int> daysInMonth = new Dictionary<int, int>()
        {
            { 1, 31 },  // January
            { 2, 28 },  // February
            { 3, 31 },  // March
            { 4, 30 },  // April
            { 5, 31 },  // May
            { 6, 30 },  // June
            { 7, 31 },  // July
            { 8, 31 },  // August
            { 9, 30 },  // September
            { 10, 31 }, // October
            { 11, 30 }, // November
            { 12, 31 }  // December
        };
        if(year%4==0 && month ==2) {
            continue daysInMonth[month] + 1;
        }
        else
        {
            continue daysInMonth[month];
        }

    }

}