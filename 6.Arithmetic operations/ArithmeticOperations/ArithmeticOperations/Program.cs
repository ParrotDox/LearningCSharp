using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArithmeticOperations
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*All arithmetic operations are read
             from left to right by program
             Priorities are:
             1.Unary operators (increment, decrement)
             2.Multiplication, division, mantissa operations
             3.Addition, subtraction*/
            byte a = 1;
            byte b = 6;
            float c = 2.1f;
            Console.BackgroundColor = ConsoleColor.Magenta;
            Console.WriteLine(b+(++a)/c);
        }
    }
}
