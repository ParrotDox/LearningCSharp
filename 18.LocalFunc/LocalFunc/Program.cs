using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LocalFunc
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int arraysSum(int[] arr1, int[] arr2) 
            {
                int sum = returnSummary(arr1) + returnSummary(arr2);
                return sum;

                int returnSummary(int[] localarr) 
                {
                    int result = 0;
                    foreach(int elem in localarr) 
                    {
                        result += elem;
                    }
                    return result;
                }
            }

            Console.WriteLine(arraysSum(new int [] { 1,2,3}, new int[] { 2,3,4}));
        }
    }
}
