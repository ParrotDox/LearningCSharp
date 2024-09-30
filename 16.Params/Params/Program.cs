using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Params
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Params is like an array but it can be created using only variables
            void paramsTest(string name, string surname, params int[][] ints) 
            {
                Console.WriteLine($"Hello {name} {surname}");
                Console.WriteLine($"Your data is {ints.Length} length");
                foreach(int[] elem in ints)
                {
                    Console.WriteLine(elem[0]);
                }
            }
            int[] arr = new int[3] {1,2,3};
            int[][] arr2 = new int[3][] { new int[] {1,2}, new int[] {3,4}, new int[] {5,6} };

            paramsTest("Egor", "Serebryakov", arr2);
        }
    }
}
