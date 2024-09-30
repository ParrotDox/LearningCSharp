using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Variables
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Version 1.1.5
            /*
             INFO application
             */

            bool CONNECTION = true;

            //binary number 0b1010 = 10
            const int KEY_CONNECTION = 0b1010;
            //Hexagon number 0x0B = 11
            const int KEY_ID = 0x0B;

            const string location = "Unknown";
            string firstName = Console.ReadLine();
            string lastName = "Serebryakov";
            Console.WriteLine($"\tHello, {firstName} {lastName}");
            Console.WriteLine($"\tYour current position is {location}");

            char ASCII_SYMBOL_HEX = '\x78'; //x
            Console.WriteLine(ASCII_SYMBOL_HEX);
            char ASCII_SYMBOL_UNICODE = '\u3086';
            Console.WriteLine(ASCII_SYMBOL_UNICODE);

            Console.WriteLine("\"UTF-8\" is universal");

        }
    }
}
