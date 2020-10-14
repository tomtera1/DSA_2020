using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace Lesson_03_Homework
{
    class Program
    {
        static void Main(string[] args)
        {
            Exercise1();
        }

        private static void Task4List()
        {
            var names = new List<string>();
            names.Add("Aaron");
            names.Add("Archie");
            names.Add("Third");
            names.Add("Hi there");
            names.Add("Ashley");
            names.Add("Bob");
            names.Add("Dilan");
            names.Add("Daniel");
            names.Add("Elon");
            names.Add("Edgar");

            if (names.Contains("Ashley"))
            {
                Console.WriteLine("There's an Item with name Ashley in List");
            }
            foreach (var listItem in names)
            {
                Console.WriteLine(listItem);
            }


            Console.ReadKey();
        }

        private static void Task3Queue()
        {
            Queue names = new Queue();
            names.Enqueue(1254);
            names.Enqueue(3);
            names.Enqueue("Third");
            names.Enqueue("Hi there");
            names.Enqueue("Ashley");
            names.Enqueue("Bob");
            names.Enqueue("Dilan");
            names.Enqueue("Daniel");
            names.Enqueue("Elon");
            names.Enqueue("Edgar");

            if (names.Contains(3))
            {
                Console.WriteLine("There's an Item with name 3 in Stack");
            }
            foreach(var queueItem in names)
            {
                Console.WriteLine(queueItem);
            }


            Console.ReadKey();
        }

        private static void Task2Stack()
        {
            Stack names = new Stack();
            names.Push("Ashley");
            names.Push("Bob");
            names.Push("Dilan");
            names.Push("Daniel");
            names.Push("Elon");
            names.Push("Edgar");
            names.Push("Finn");
            names.Push("George");
            names.Push("Hilary");
            names.Push("Issac");

            if(names.Contains ("Bob"))
            {
                Console.WriteLine("There's an Item with name Bob in Stack");
            }

            foreach (object stackItem in names)
            {
                Console.WriteLine(stackItem);
            }

            Console.ReadKey();


        }

        private static void Task1Array()
        {

            string[] names = new string[10];
            names[0] = "Ashley";
            names[1] = "Bob";
            names[2] = "Dilan";
            names[3] = "Daniel";
            names[4] = "Elon";
            names[5] = "Edgar";
            names[6] = "Finn";
            names[7] = "George";
            names[8] = "Hilary";
            names[9] = "Issac";

            if (names.Contains("Elon"))
            {
                Console.WriteLine("There's a name Elon, 5th in array");
            }

            Array.ForEach(names, Console.WriteLine);

            Console.ReadKey();
        }

        private static void Exercise1()
        {


        }



    }
}
