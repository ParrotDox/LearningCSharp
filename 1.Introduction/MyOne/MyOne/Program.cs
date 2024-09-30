using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyOne
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            Console.WriteLine("Please enter your firstname");
            Console.WriteLine("INPUT:");
            var firstName = Console.ReadLine();
            Console.WriteLine($"Hello {firstName}");
        }
    }
}
