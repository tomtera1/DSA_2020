using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace DATA_SA_ASSIGNMENT
{
    class Program
    {
        static void Main(string[] args)
        {
            PopuLateWithSampleData();
        }

        public static void PopuLateWithSampleData()
        {


            //Declaring Variables with data
            #region
            List<string> FirstNames = new List<string>();
            List<string> LastNames = new List<string>();
            List<string> StudentNumbers = new List<string>();
            int[] Scores = new int[4] { 100, 75, 89, 94 };
            double avgScores = Queryable.Average(Scores.AsQueryable());


            #endregion

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

            //EDITING INFORMATION
           
            Console.WriteLine("====================================");
            Console.WriteLine("THIS INTERFACE ALLOWS YOU TO EDIT");
            Console.WriteLine("INFORMATION ABOUT STUDENTS");
            Console.WriteLine("THAT YOU HAVE ENTERED BEFORE");
            Console.WriteLine("=====================================");
            Console.WriteLine("Press any key to continue");
            Console.ReadKey();
            Console.Clear();

            Console.WriteLine("==================================================");
            Console.WriteLine("IF YOU WISH TO ADD AN ELEMENT, PRESS 1");
            Console.WriteLine("IF YOU WISH TO GET AN ELEMENT BY INDEX, PRESS 2");
            Console.WriteLine("IF YOU WISH TO DELETE AN ELEMENT BY INDEX, PRESS 3");
            Console.WriteLine("==================================================");
            int Choice = int.Parse(Console.ReadLine());

            //IF "1" SELECTED (ADDING AN ELEMENT)
            if (Choice == 1)
            {
                Console.Clear();
                Console.WriteLine("====================");
                Console.WriteLine("SELECT TYPE OF DATA,");
                Console.WriteLine("THAT YOU WANNA ADD");
                Console.WriteLine("====================");
                Console.WriteLine("1. First Name");
                Console.WriteLine("2. Last Name");
                Console.WriteLine("3. Student Number");
                Console.WriteLine("--------------------");
                Console.WriteLine("Your choice: ");
                int ChoiceTwo = int.Parse(Console.ReadLine());
                Console.Clear();

                //IF "1" SELECTED (FIRST NAME)
                if (ChoiceTwo == 1)
                {
                    do
                    {
                        Console.WriteLine("====================");
                        Console.WriteLine("ADDING FIRST NAME");
                        Console.WriteLine("====================");

                        Console.WriteLine("---------------------");
                        Console.WriteLine("First names STORED: ");
                        Console.WriteLine("---------------------");
                        foreach (string FirstName in FirstNames)
                        {
                            Console.WriteLine(FirstName);
                        }
                        Console.WriteLine("---------------------------------");

                        Console.WriteLine("Add First Name: ");
                        input = (Console.ReadLine());
                        FirstNames.Add(input);
                        Console.Clear();
                        Console.WriteLine("==================");
                        Console.WriteLine("SUCCESSFULLY ADDED");
                        Console.WriteLine("==================");
                        Console.WriteLine("-------------------------");
                        Console.WriteLine("First Names STORED: ");
                        Console.WriteLine("-------------------------");
                        foreach (string FirstName in FirstNames)
                        {
                            Console.WriteLine(FirstName);
                        }
                        Console.WriteLine("--------------------------------");
                        Console.WriteLine("Add one more?");
                        Console.WriteLine("YES: 'i don't care which button you will  press.");
                        Console.WriteLine("NO: press 'n': ");
                        YesNoInput = Console.ReadLine();
                        Console.Clear();
                        Console.WriteLine("First Names just added: ");
                        foreach (string FirstName in FirstNames)
                        {
                            Console.WriteLine(FirstName);
                        }
                        Console.WriteLine("---------------------------------");
                    }
                    while (YesNoInput != "n");

                    Console.Clear();
                }

                //IF "2" SELECTED (LAST NAME)
                if (ChoiceTwo == 2)
                {
                    do
                    {
                        Console.WriteLine("====================");
                        Console.WriteLine("ADDING LAST NAME");
                        Console.WriteLine("====================");

                        Console.WriteLine("-------------");
                        Console.WriteLine("Last Names STORED: ");
                        Console.WriteLine("-------------");
                        foreach (string LastName in LastNames)
                        {
                            Console.WriteLine(LastName);
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
                }

                //IF "3" SELECTED (STUDENT NUMBER)
                if (ChoiceTwo == 3)
                {
                    do
                    {
                        Console.WriteLine("====================");
                        Console.WriteLine("ADDING STUDENT NUMBER");
                        Console.WriteLine("====================");
                        Console.WriteLine("-------------");
                        Console.WriteLine("Student Numbers STORED: ");
                        Console.WriteLine("-------------");
                        foreach (string StudentNumber in StudentNumbers)
                        {
                            Console.WriteLine(StudentNumber);
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
                }
            }

            //IF "2" SELECTED (GETTING ELEMENT BY INDEX)
            if (Choice == 2)
            {
                Console.Clear();
                Console.WriteLine("====================");
                Console.WriteLine("SELECT TYPE OF DATA,");
                Console.WriteLine("THAT YOU WANNA GET");
                Console.WriteLine("====================");
                Console.WriteLine("1. First Name");
                Console.WriteLine("2. Last Name");
                Console.WriteLine("3. Student Number");
                Console.WriteLine("--------------------");
                Console.WriteLine("Your choice: ");
                int ChoiceTwo = int.Parse(Console.ReadLine());
                Console.Clear();

                //IF "1" SELECTED (FIRST NAME)
                if (ChoiceTwo == 1)
                {
                    do
                    {
                        Console.WriteLine("====================");
                        Console.WriteLine("GETTING FIRST NAME");
                        Console.WriteLine("BY INDEX");
                        Console.WriteLine("====================");
                        Console.WriteLine("");
                        Console.WriteLine("---------------------");
                        Console.WriteLine("First names STORED: ");
                        Console.WriteLine("---------------------");
                        foreach (string FirstName in FirstNames)
                        {
                            Console.WriteLine(FirstName);
                        }
                        Console.WriteLine("---------------------------------");

                        Console.WriteLine("TYPE IN AN INDEX OF A NAME,");
                        Console.WriteLine("THAT YOU WANNA GET:");
                        int inputIndex = int.Parse(Console.ReadLine());
                        Console.Clear();

                        Console.WriteLine("====================");
                        Console.WriteLine("GETTING FIRST NAME");
                        Console.WriteLine("BY INDEX");
                        Console.WriteLine("====================");
                        Console.WriteLine("");
                        Console.WriteLine($"-------------------------");
                        Console.WriteLine("You have selected element");
                        Console.WriteLine($"With index ({inputIndex})");
                        Console.WriteLine($"-------------------------");
                        Console.WriteLine($"THERE YOU GO: ");
                        Console.WriteLine($"{FirstNames[inputIndex].ToUpper()}");
                        Console.WriteLine("---------------------------------");
                        Console.WriteLine("So... You wanna get another one?");
                        Console.WriteLine("YES: 'y', NO: 'n': ");
                        YesNoInput = Console.ReadLine();
                        Console.Clear();
                    }
                    while (YesNoInput != "n");
                }

                //IF "2" SELECTED (LAST NAME)
                if (ChoiceTwo == 2)
                {
                    do
                    {
                        Console.WriteLine("====================");
                        Console.WriteLine("GETTING LAST NAME");
                        Console.WriteLine("BY INDEX");
                        Console.WriteLine("====================");
                        Console.WriteLine("");
                        Console.WriteLine("---------------------");
                        Console.WriteLine("Last names STORED: ");
                        Console.WriteLine("---------------------");
                        foreach (string LastName in LastNames)
                        {
                            Console.WriteLine(LastName);
                        }
                        Console.WriteLine("---------------------------------");

                        Console.WriteLine("TYPE IN AN INDEX OF A SURNAME,");
                        Console.WriteLine("THAT YOU WANNA GET:");
                        int inputIndex = int.Parse(Console.ReadLine());
                        Console.Clear();
                        Console.WriteLine("====================");
                        Console.WriteLine("GETTING LAST NAME");
                        Console.WriteLine("BY INDEX");
                        Console.WriteLine("====================");
                        Console.WriteLine("");
                        Console.WriteLine($"-------------------------");
                        Console.WriteLine("You have selected element");
                        Console.WriteLine($"With index ({inputIndex})");
                        Console.WriteLine($"-------------------------");
                        Console.WriteLine($"THERE YOU GO: ");
                        Console.WriteLine($"{LastNames[inputIndex].ToUpper()}");
                        Console.WriteLine("---------------------------------");
                        Console.WriteLine("So... You wanna get another one?");
                        Console.WriteLine("YES: 'y', NO: 'n': ");
                        YesNoInput = Console.ReadLine();
                        Console.Clear();
                    }
                    while (YesNoInput != "n");
                }

                if (ChoiceTwo == 3)
                {
                    do
                    {
                        Console.WriteLine("======================");
                        Console.WriteLine("GETTING STUDENT NUMBER");
                        Console.WriteLine("BY INDEX");
                        Console.WriteLine("======================");
                        Console.WriteLine("");
                        Console.WriteLine("---------------------");
                        Console.WriteLine("STUDENT NUMBERS STORED: ");
                        Console.WriteLine("---------------------");
                        foreach (string StudentNumber in StudentNumbers)
                        {
                            Console.WriteLine(StudentNumber);
                        }
                        Console.WriteLine("---------------------------------");

                        Console.WriteLine("TYPE IN AN INDEX OF A STUDENT NUMBER,");
                        Console.WriteLine("THAT YOU WANNA GET:");
                        int inputIndex = int.Parse(Console.ReadLine());
                        Console.Clear();
                        Console.WriteLine("====================");
                        Console.WriteLine("GETTING STUDENT NUMBER");
                        Console.WriteLine("BY INDEX");
                        Console.WriteLine("====================");
                        Console.WriteLine("");
                        Console.WriteLine($"-------------------------");
                        Console.WriteLine("You have selected element");
                        Console.WriteLine($"With index ({inputIndex})");
                        Console.WriteLine($"-------------------------");
                        Console.WriteLine($"THERE YOU GO: ");
                        Console.WriteLine($"{StudentNumbers[inputIndex]}");
                        Console.WriteLine("---------------------------------");
                        Console.WriteLine("So... You wanna get another one?");
                        Console.WriteLine("YES: 'y', NO: 'n': ");
                        YesNoInput = Console.ReadLine();
                        Console.Clear();
                    }
                    while (YesNoInput != "n");
                }
            }

            //IF "3" SELECTED (DELETING ELEMENT BY INDEX)
            if (Choice == 3)
            {
                Console.Clear();
                Console.WriteLine("====================");
                Console.WriteLine("SELECT TYPE OF DATA,");
                Console.WriteLine("THAT YOU WANNA REMOVE");
                Console.WriteLine("====================");
                Console.WriteLine("1. First Name");
                Console.WriteLine("2. Last Name");
                Console.WriteLine("3. Student Number");
                Console.WriteLine("--------------------");
                Console.WriteLine("Your choice: ");
                int ChoiceTwo = int.Parse(Console.ReadLine());
                Console.Clear();

                //IF "1" SELECTED (FIRST NAME)
                if (ChoiceTwo == 1)
                {
                    do
                    {
                        Console.WriteLine("====================");
                        Console.WriteLine("DELETING FIRST NAME");
                        Console.WriteLine("BY INDEX");
                        Console.WriteLine("====================");
                        Console.WriteLine("");
                        Console.WriteLine("--------------------");
                        Console.WriteLine("First names STORED: ");
                        Console.WriteLine("--------------------");
                        foreach (string FirstName in FirstNames)
                        {
                            Console.WriteLine($"{FirstName}");
                        }
                        Console.WriteLine("---------------------------------");

                        Console.WriteLine("TYPE IN AN INDEX OF A NAME,");
                        Console.WriteLine("YOU WOULD LIKE TO DELETE (STARTING FROM '0') , SIR (MA'AM):");
                        int inputIndex = int.Parse(Console.ReadLine());
                        Console.Clear();

                        Console.WriteLine("====================");
                        Console.WriteLine("DELETING FIRST NAME");
                        Console.WriteLine("BY INDEX");
                        Console.WriteLine("====================");
                        Console.WriteLine("");
                        Console.WriteLine($"-------------------------");
                        Console.WriteLine("You have selected element");
                        Console.WriteLine($"With index ({inputIndex})");
                        Console.WriteLine($"-------------------------");
                        Console.WriteLine($"WHICH IS: ");
                        Console.WriteLine($"{FirstNames[inputIndex].ToUpper()}");
                        Console.WriteLine("---------------------------------");
                        Console.WriteLine("Press any key to continue");
                        Console.ReadKey();
                        Console.Clear();

                        //REMOVING ITEM
                        
                        Console.WriteLine("====================");
                        Console.WriteLine($"THERE YOU GO: ");
                        Console.WriteLine($"{FirstNames[inputIndex].ToUpper()}");
                        Console.WriteLine($"With index ({inputIndex})");
                        Console.WriteLine("REMOVED");
                        Console.WriteLine("====================");
                        
                        Console.WriteLine("Press any Key to Continue");
                        Console.ReadKey();
                        Console.Clear();
                        FirstNames.RemoveAt(inputIndex);
                        Console.WriteLine("--------------------");
                        Console.WriteLine("First names STORED: ");
                        Console.WriteLine("--------------------");
                        foreach (string FirstName in FirstNames)
                        {
                            Console.WriteLine($"{FirstName}");
                        }
                        //ANOTHER ONE?
                        Console.WriteLine("");
                        Console.WriteLine("---------------------------------");
                        Console.WriteLine("So... You wanna remove another one?");
                        Console.WriteLine("YES: 'y', NO: 'n': ");
                        YesNoInput = Console.ReadLine();
                        Console.Clear();
                    }
                    while (YesNoInput != "n");
                }

                //IF "2" SELECTED (LAST NAME)
                if (ChoiceTwo == 2)
                {
                    do
                    {
                        Console.WriteLine("====================");
                        Console.WriteLine("DELETING LAST NAME");
                        Console.WriteLine("BY INDEX");
                        Console.WriteLine("====================");
                        Console.WriteLine("");
                        Console.WriteLine("--------------------");
                        Console.WriteLine("Last names STORED: ");
                        Console.WriteLine("--------------------");
                        foreach (string LastName in LastNames)
                        {
                            Console.WriteLine($"{LastName}");
                        }
                        Console.WriteLine("---------------------------------");

                        Console.WriteLine("TYPE IN AN INDEX (STARTING FROM '0') OF A SURNAME,");
                        Console.WriteLine("YOU WOULD LIKE TO DELETE:");
                        int inputIndex = int.Parse(Console.ReadLine());
                        Console.Clear();

                        Console.WriteLine("====================");
                        Console.WriteLine("DELETING FIRST NAME");
                        Console.WriteLine("BY INDEX");
                        Console.WriteLine("====================");
                        Console.WriteLine("");
                        Console.WriteLine($"-------------------------");
                        Console.WriteLine("You have selected element");
                        Console.WriteLine($"With index ({inputIndex})");
                        Console.WriteLine($"-------------------------");
                        Console.WriteLine($"WHICH IS: ");
                        Console.WriteLine($"{LastNames[inputIndex].ToUpper()}");
                        Console.WriteLine("---------------------------------");
                        Console.WriteLine("Press any key to continue (you cannot stop me now)");
                        Console.ReadKey();
                        Console.Clear();

                        //REMOVING ITEM
                        
                        Console.WriteLine("====================");
                        Console.WriteLine($"THERE YOU GO: ");
                        Console.WriteLine($"ITEM '{LastNames[inputIndex].ToUpper()}'");
                        Console.WriteLine($"With index ({inputIndex})");
                        Console.WriteLine("HAS BEEN REMOVED");
                        Console.WriteLine("====================");
                        Console.WriteLine("");
                        Console.WriteLine("Press any Key to Continue");
                        Console.ReadKey();
                        Console.Clear();
                        LastNames.RemoveAt(inputIndex);
                        Console.WriteLine("--------------------");
                        Console.WriteLine("Last names THAT SURVIVED YOUR BRUTALITY: ");
                        Console.WriteLine("--------------------");
                        foreach (string LastName in LastNames)
                        {
                            Console.WriteLine($"{LastName}");
                        }
                        //ANOTHER ONE?
                        Console.WriteLine("");
                        Console.WriteLine("---------------------------------");
                        Console.WriteLine("So... You wanna remove another one?");
                        Console.WriteLine("YES: 'y', NO: 'n': ");
                        YesNoInput = Console.ReadLine();
                        Console.Clear();
                    }
                    while (YesNoInput != "n");
                }

                //IF "3" SELECTED (STUDENT NUMBER)
                if (ChoiceTwo == 3)
                {
                    do
                    {
                        Console.WriteLine("====================");
                        Console.WriteLine("DELETING STUDENT NUMBER");
                        Console.WriteLine("BY INDEX");
                        Console.WriteLine("====================");
                        Console.WriteLine("");
                        Console.WriteLine("--------------------");
                        Console.WriteLine("STUDENT NUMBERS STORED: ");
                        Console.WriteLine("--------------------");
                        foreach (string StudentNumber in StudentNumbers)
                        {
                            Console.WriteLine($"{StudentNumber}");
                        }
                        Console.WriteLine("---------------------------------");

                        Console.WriteLine("TYPE IN AN INDEX (STARTING FROM '0') OF A STUD. NUMBER,");
                        Console.WriteLine("YOU WOULD LIKE TO DELETE:");
                        int inputIndex = int.Parse(Console.ReadLine());
                        Console.Clear();

                        Console.WriteLine("====================");
                        Console.WriteLine("DELETING STUDENT NUMBER");
                        Console.WriteLine("BY INDEX");
                        Console.WriteLine("====================");
                        Console.WriteLine("");
                        Console.WriteLine($"-------------------------");
                        Console.WriteLine("You have selected element");
                        Console.WriteLine($"With index ({inputIndex})");
                        Console.WriteLine($"-------------------------");
                        Console.WriteLine($"WHICH IS: ");
                        Console.WriteLine($"'{StudentNumbers[inputIndex].ToString()}'");
                        Console.WriteLine("---------------------------------");
                        Console.WriteLine("Press any key to continue");
                        Console.ReadKey();
                        Console.Clear();

                        //REMOVING ITEM
                        
                        Console.WriteLine("====================");
                        Console.WriteLine($"THERE YOU GO: ");
                        Console.WriteLine($"ITEM '{StudentNumbers[inputIndex].ToString()}'");
                        Console.WriteLine($"With index ({inputIndex})");
                        Console.WriteLine("HAS BEEN REMOVED");
                        Console.WriteLine("====================");
                        Console.WriteLine("HAPPY?");
                        Console.WriteLine("");
                       
                        Console.WriteLine("Press any Key to Continue");
                        Console.ReadKey();
                        Console.Clear();
                        StudentNumbers.RemoveAt(inputIndex);
                        Console.WriteLine("--------------------");
                        Console.WriteLine("Student Numbers THAT SURVIVED: ");
                        Console.WriteLine("--------------------");
                        foreach (string StudentNumber in StudentNumbers)
                        {
                            Console.WriteLine($"{StudentNumber}");
                        }
                        //ANOTHER ONE?
                        Console.WriteLine("");
                        Console.WriteLine("---------------------------------");
                        Console.WriteLine("So... You wanna keep removing things?");
                        Console.WriteLine("YES: 'y';");
                        Console.WriteLine("NO, I'M DONE: 'n': ");
                        YesNoInput = Console.ReadLine();
                        Console.Clear();
                    }
                    while (YesNoInput != "n");
                }
                
            }



            //DISPLAYING FULL INFORMATION 
            #region
            Console.WriteLine($"===========================================");
            Console.WriteLine($"HERE IS FULL INFO AFTER ADDING AND EDITING:");
            Console.WriteLine($"===========================================");
            Console.WriteLine($"");
            Console.WriteLine("--------------------");
            Console.WriteLine("First names STORED: ");
            Console.WriteLine("--------------------");
            foreach (string FirstName in FirstNames)
            {
                Console.WriteLine($"{FirstName}");
            }
            Console.WriteLine("---------------------------------");
            Console.WriteLine($"");
            Console.WriteLine("--------------------");
            Console.WriteLine("Last names STORED: ");
            Console.WriteLine("--------------------");
            foreach (string LastName in LastNames)
            {
                Console.WriteLine($"{LastName}");
            }
            Console.WriteLine("---------------------------------");
            Console.WriteLine($"");
            Console.WriteLine("-----------------------");
            Console.WriteLine("STUDENT NUMBERS STORED: ");
            Console.WriteLine("-----------------------");
            foreach (string StudentNumber in StudentNumbers)
            {
                Console.WriteLine($"{StudentNumber}");
            }
            Console.WriteLine("---------------------------------");
            Console.WriteLine("");
            Console.WriteLine("-------------------------");
            Console.WriteLine("SCORES AVERAGE:");
            Console.WriteLine("-------------------------");
            Console.WriteLine($"{avgScores}");
            Console.WriteLine("---------------------------------");
            Console.WriteLine("PRESS ANY KEY TO SAY GOODBYE");
            Console.ReadKey();
            #endregion

        }
        
    }
}