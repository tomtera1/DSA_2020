using System;
using System.Collections.Generic;

namespace DSA_ASSIGNMENT_RELEASE
{
    class Program
    {
        static void Main(string[] args)
        {
            //Declaring Variables with data
            
            List<string> FirstNames = new List<string>();
            List<string> LastNames = new List<string>();
            List<string> StudentNumbers = new List<string>();
            List<float> AverageScore = new List<float>();

            PupulateWithSampleData();
            
        }


        public class DSAASSIGNMENT
        {
            //Declaring Variables with data
            #region
            List<string> FirstNames = new List<string>();
            List<string> LastNames = new List<string>();
            List<string> StudentNumbers = new List<string>();
            List<float> AverageScore = new List<float>();
            #endregion


            public static void PupulateWithSampleData()
            {
                

                //ADDING INFORMATION
                #region

                Console.WriteLine("=============================================");
                Console.WriteLine("THIS INTERFACE ALLOWS YOU TO ADD");
                Console.WriteLine("INFORMATION ABOUT STUDENTS");
                Console.WriteLine("=============================================");
                Console.WriteLine("");
                Console.WriteLine("-------------------------");
                Console.WriteLine("Assignment for DATA S&A. Made by Artem Haidash");
                Console.WriteLine("Student id: 2016051");
                Console.WriteLine("-------------------------");
                Console.WriteLine("");
                Console.WriteLine("-------------------------");
                Console.WriteLine("FUNCTIONALITY:");
                Console.WriteLine("ADDING, STORING, DISPLAYING BY INDEX,");
                Console.WriteLine("REMOVING BY INDEX, DISPLAYING ALL STORED DATA");
                Console.WriteLine("-------------------------");
                Console.WriteLine("Press any key to continue");
                Console.ReadKey();
                Console.Clear();

                string input = "";
                string YesNoInput = "";

                //INTERFACE FOR ADDING FIRST NAME
                do
                {

                    Console.WriteLine("Add First Name: ");
                    input = Console.ReadLine();
                    FirstNames.Add(input);
                    Console.Clear();
                    Console.WriteLine("==================");
                    Console.WriteLine("SUCCESSFULLY ADDED");
                    Console.WriteLine("==================");
                    Console.WriteLine("");
                    Console.WriteLine("First Names STORED: ");
                    Console.WriteLine("---------");
                    foreach (string FirstName in FirstNames)
                    {
                        Console.WriteLine(FirstName);
                    }
                    Console.WriteLine("---------");
                    Console.WriteLine("");
                    Console.WriteLine("Add one more?");
                    Console.WriteLine("YES: 'y', NO: 'n': ");
                    YesNoInput = Console.ReadLine();
                    Console.Clear();
                    Console.WriteLine("First Names STORED: ");
                    foreach (string FirstName in FirstNames)
                    {
                        Console.WriteLine(FirstName);
                    }
                    Console.WriteLine("------------------");
                }
                while (YesNoInput != "n");

                Console.Clear();

                //INTERFACE FOR ADDING LAST NAME
                do
                {
                    Console.WriteLine("=================");
                    Console.WriteLine("Memory Contains: ");
                    Console.WriteLine("=================");
                    Console.WriteLine("-------------");
                    Console.WriteLine("First names: ");
                    Console.WriteLine("-------------");
                    foreach (string FirstName in FirstNames)
                    {
                        Console.WriteLine(FirstName);
                    }
                    Console.WriteLine("---------------------------------");

                    Console.WriteLine("Add Last Name: ");
                    input = (Console.ReadLine());
                    LastNames.Add(input);
                    Console.Clear();
                    Console.WriteLine("==================");
                    Console.WriteLine("SUCCESSFULLY ADDED");
                    Console.WriteLine("==================");
                    Console.WriteLine("---------");
                    Console.WriteLine("Last Names STORED: ");
                    Console.WriteLine("---------");
                    foreach (string LastName in LastNames)
                    {
                        Console.WriteLine(LastName);
                    }
                    Console.WriteLine("---------");
                    Console.WriteLine("");
                    Console.WriteLine("Add one more?");
                    Console.WriteLine("YES: 'y', NO: 'n': ");
                    YesNoInput = Console.ReadLine();
                    Console.Clear();
                    Console.WriteLine("-------------------------");
                    Console.WriteLine("Last Names STORED: ");
                    Console.WriteLine("-------------------------");
                    foreach (string LastName in LastNames)
                    {
                        Console.WriteLine(LastName);
                    }
                    Console.WriteLine("--------------------------------");
                }
                while (YesNoInput != "n");
                Console.Clear();

                //INTERFACE FOR ADDING STUDENT NUMDERS
                do
                {
                    Console.WriteLine("=================");
                    Console.WriteLine("Memory CONTAINS: ");
                    Console.WriteLine("=================");
                    Console.WriteLine("-------------");
                    Console.WriteLine("First names: ");
                    Console.WriteLine("-------------");
                    foreach (string FirstName in FirstNames)
                    {
                        Console.WriteLine(FirstName);
                    }

                    Console.WriteLine("-------------");
                    Console.WriteLine("Last names: ");
                    Console.WriteLine("-------------");
                    foreach (string LastName in LastNames)
                    {
                        Console.WriteLine(LastName);
                    }
                    Console.WriteLine("---------------------------------");


                    Console.WriteLine("Add a Student Number: ");
                    input = (Console.ReadLine());
                    StudentNumbers.Add(input);
                    Console.Clear();
                    Console.WriteLine("==================");
                    Console.WriteLine("SUCCESSFULLY ADDED");
                    Console.WriteLine("==================");
                    Console.WriteLine("---------");
                    Console.WriteLine("Student Numbers STORED: ");
                    Console.WriteLine("---------");
                    foreach (string StudentNumber in StudentNumbers)
                    {
                        Console.WriteLine(StudentNumber);
                    }
                    Console.WriteLine("---------");
                    Console.WriteLine("");
                    Console.WriteLine("Add one more?");
                    Console.WriteLine("YES: 'y', NO: 'n': ");
                    YesNoInput = Console.ReadLine();
                    Console.Clear();
                    Console.WriteLine("---------");
                    Console.WriteLine("Student numbers just added: ");
                    Console.WriteLine("---------");
                    foreach (string StudentNumber in StudentNumbers)
                    {
                        Console.WriteLine(StudentNumber);
                    }
                    Console.WriteLine("---------------------------------");
                }
                while (YesNoInput != "n");
                Console.Clear();
                #endregion



            }

            public static void Add()
            {



            }

        }
           
    }
}
