using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Recursion
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int findFibonachiNumber(int position) 
            {
                if(position == 0 || position == 1) 
                {
                    return position;
                }
                return findFibonachiNumber(position - 1) + findFibonachiNumber(position - 2);
                
            }
            int fib4 = findFibonachiNumber(4);
            Console.WriteLine(fib4);
        }
    }
}
