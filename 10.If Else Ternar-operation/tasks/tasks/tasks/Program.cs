using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tasks
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int value1 = Convert.ToInt32(Console.ReadLine());
            int value2 = Convert.ToInt32(Console.ReadLine());
            if (value1 > value2) 
            {
                Console.WriteLine("first value is higher");
            }
            else 
            {
                Console.WriteLine("second value is higher");
            }

            int value3 = Convert.ToInt32(Console.ReadLine());
            if (value3 > 5 && value3 < 10) 
            {
                Console.WriteLine("Number is > 5 and < 10");
            }
            else 
            {
                Console.WriteLine("Unknown number");
            }

            int value4 = Convert.ToInt32(Console.ReadLine());
            if(value4 == 5 || value4 == 10) 
            {
                Console.WriteLine("Value is 5 or 10");
            }
            else 
            {
                Console.WriteLine("???");
            }

            double invest = Convert.ToDouble(Console.ReadLine());
            if(invest < 100) 
            {
                invest*= 1.05;
            }
            else if(invest > 100 && invest < 200) 
            {
                invest *= 1.07;
            }
            else 
            {
                invest *= 1.10;
            }
            Console.WriteLine($"Your investition is {invest}");

        }
    }
}
