using System;
using System.Collections.Generic;
using Wintellect.PowerCollections;

namespace Lesson_04
{
    class Program
    {
        static void Main(string[] args)
        {
            Task1Menu();
        }
        







        private static void Task1Menu()
        {
            while(true)
            {
                List<int> listItems = new List<int>();

                Console.Clear();
                Console.WriteLine("1. Add Item");
                Console.WriteLine("2. Remove Item");
                Console.WriteLine("3. List of all Items");
                Console.WriteLine("4. Exit");

                string choise = Console.ReadLine();
                
                switch (choise)
                {
                    case "1":
                        Console.WriteLine(choise);
                            break;
                    case "2":
                        Console.WriteLine(choise);
                        break;
                    case "3":
                        Console.WriteLine(choise);
                        break;
                    case "4":
                        Console.WriteLine(choise);
                        return;
                }

            }
            static void AddItem()
            {
                Console.Write("Add Item = ");
                int item = int.Parse(Console.ReadLine());
                listItems.Add(item);
            }
            static void RemoveItem()
            {
                Console.Write("Remove Item = ");
                int item = int.Parse(Console.ReadLine());
                listItems.Remove(item);
            }

        }
        

        private static void StudentMarks()
        {
            Dictionary<string, int> studentMarks = new Dictionary<string, int>();

            studentMarks.Add("Jane", 90);
            studentMarks.Add("John", 80);
            studentMarks.Add("Ivan", 70);
            studentMarks.Add("Peter", 60);
            studentMarks.Add("Maria", 50);

            //putting in loop:
            while (true)
            {
                //displaying all marks and students:
                foreach (var studentMark in studentMarks)
                {
                    Console.Write($"Student {studentMark.Key}, mark={studentMark.Value}");
                }


                string name = Console.ReadLine();
                Console.Write("Name: ");
                //exiting programm if needed:
                if (name == "exit")
                {
                    break;
                }
                

                if (studentMarks.ContainsKey(name))
                {
                    Console.WriteLine($"Student '{name}' score is {studentMarks[name]}");
                }
                else
                {
                    Console.WriteLine($"Student '{name}' does not exsist");
                }
            }

            
        }
        private static void StudentMarks1()
        {
            string text = "a text some text just some text";
            IDictionary<string, int> wordsCount = new SortedDictionary<string, int>();
            string[] words = text.Split(' ');
            foreach (string word in words)
            {
                int count = 1;
                if (wordsCount.ContainsKey(word))
                {
                    count = wordsCount[word] + 1;
                }
                wordsCount[word] = count;
            }
            



        }

    }
}
