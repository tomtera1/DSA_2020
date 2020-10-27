using System;
using System.Linq;
using System.Threading.Tasks;

namespace Lesson_05
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }


        private static void MinMaxArray()
        {
            //task: find min and max elements in the array
            //~~~~~~~~~~~~~~~~~~~~~~~~~
            //1. Start
            //2. Define min, max
            
            //3. Read array
            
            //4. min=array[0], max=array[0]
            //5. foreach element of array
            //      5.1 If element < min 
            //          min=element
            //      5.2 if element > max
            //          max=element
            //6. Display min, max
            //7. End




        }

        private static void Average()
        {
            // Task: calculate average
            // ~~~~~~~~~~~~~~~~~~~
            //Start
            //2. Define sum, count, avg
            //3. Read array
            //4. foreach element of the array 
            //    4.1 sum = sum + element
            //    4.2 count++
            //5. avg = sum / count
            //6. Display avg
            // 7. End
        }
        private static void Swap()
        {
            // Task: swap 2 array items
            // {1, 2, 3, 4} => swap 1 and 3 => {3, 2, 1, 4}
            // ~~~~~~~~~~~~~~~~~~~
            // 1. Start
            // 2. Define temp
            // 3. Read array
            // 4. Read index1 (0) and index2 (2)
            // 5. temp = array[index1]
            // 6. Array[Index1] = array [index2]
            // 7. array[Index2] = temp
            // 8. End 
        }
        private static void PushStack()
        {
            //Add element to stack realized by array
            //~~~~~~~~~~~~~~~~~~~~~~~~
            //1. Start
            //2. Define element, is added
            //3. Read new element
            //4. isadded = full
            //5. For each item in array 
            //    If item is empty
            //     5.1 Item = element
            //      5.2 isadded = true
            //6. Return isadded
            //7. End
        }
        private static void PopStack()
        {
            // Remove item from stack
            // {1, 2, 3, null, null, null} ==> 3
            //~~~~~~~~~~~~~~~~~~~~~~
            //1. Start
            //2. Define output
            //3. Foreach item in array
            //   If item is null
            //       3.1 output = array[item index -1]
            //       3.2 array[item index -1] = null
            //       3.3 Exit foreach loop
            //4. Return output
            //5. End

        }
        private static void AddTreeElem()
        {
            //Add Element into binary tree
            //~~~~~~~~~~~~~~~~~~~~~~~~~~~



        }

    }
}
