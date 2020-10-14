﻿using System;

namespace Lesson_03__missed_classes_
{
    class Program
    {
        static void Main(string[] args)
        {
            Task01();
        }

        private static void Task01()
        {
            // Initialization
            string[] names = { "Ivan", "Peter", "John", "Jane", "Maria" };

            DateTime[] bdays = new DateTime[names.Length];
            bdays[0] = new DateTime(2000, 01, 22);
            bdays[1] = new DateTime(2001, 01, 02);
            bdays[2] = new DateTime(2002, 01, 02);
            bdays[3] = new DateTime(2003, 01, 02);
            bdays[4] = new DateTime(2004, 01, 02);

            // User input
            Console.Write("Please enter index (0-4): ");
            int index = int.Parse(Console.ReadLine());

            // Program logic
            string periodOfMonth = GetPeriodOfMonth(bdays, index);
            string monthName = GetNameOfMonth(bdays[index].Month);

            // Output
            Console.WriteLine($"{names[index]}'s is born in the {periodOfMonth} in {monthName} ");
        }

        private static string GetPeriodOfMonth(DateTime[] bdays, int index)
        {
            int day = bdays[index].Day;
            string periodOfMonth = "beginning";

            if (day > 10)
            {
                periodOfMonth = "middle";
            }

            if (day > 20)
            {
                periodOfMonth = "end";
            }

            return periodOfMonth;
        }

        private static string GetNameOfMonth(int month)
        {
            if (month == 1) return "January";
            if (month == 2) return "February";
            if (month == 3) return "March";
            if (month == 4) return "April";
            if (month == 5) return "May";
            if (month == 6) return "Juny";
            if (month == 7) return "July";
            if (month == 8) return "August";
            if (month == 9) return "September";
            if (month == 10) return "October";
            if (month == 11) return "November";
            if (month == 12) return "December";

            return "Unknown";
        }
    }
}


