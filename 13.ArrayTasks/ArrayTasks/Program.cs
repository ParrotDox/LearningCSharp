using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace ArrayTasks
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = new int[] { 1, 2, 3, -3, -2, 100, 0, -1, 23 };
            int result = 0;
            foreach (int elem in numbers)
            { 
                if(elem >= 0) 
                {
                    ++result;
                }
            }
            Console.WriteLine(result);

            int[] inverseArray = new int[] { 1, -1, 2, 3, 4, 5, 6, 7 ,9};
            int middle = inverseArray.Length/2;

            foreach (int elem in inverseArray)
            {
                Console.Write($"| {elem} | ");
            }
            Console.WriteLine("\n");
            for (int i = 0; i < middle; ++i) 
            {
                int temp = inverseArray[i];
                inverseArray[i] = inverseArray[inverseArray.Length-1-i];
                inverseArray[inverseArray.Length - 1 - i] = temp;
            }
            foreach(int elem in inverseArray)
            {
                Console.Write($"| {elem} | ");
            }
        }
    }
}
