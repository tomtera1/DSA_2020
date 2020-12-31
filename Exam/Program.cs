using System;

namespace Exam
{
    class Program
    {
        static void Main(string[] args)
        {
            int i, factorial = 1, num;

            Console.WriteLine("==========================");
            Console.WriteLine("CALCULATING THE FACTORIAL");
            Console.WriteLine("==========================");
            

            Console.Write("Enter number: ");
            num = Convert.ToInt32(Console.ReadLine());
            for (i = 1; i <= num; i++)
                factorial = factorial * i;

            Console.Write("The Factorial of {0} is: {1}", num, factorial);
        }

    }
}
