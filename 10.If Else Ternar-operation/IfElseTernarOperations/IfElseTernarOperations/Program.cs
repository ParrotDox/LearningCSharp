using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IfElseTernarOperations
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            if (requirement) 
            {
                Instructions
            }
            else if (requirement)
            {
                Instructions
            }
            else 
            {
                Instructions
            }
            if (requirement) Instructions;
            */
            Console.WriteLine("Enter name:");
            String name = Console.ReadLine();
            Console.WriteLine("Enter age:");
            String ageInput = Console.ReadLine();
            int age = Int32.Parse(ageInput);
            if (name == null)
            {
                Console.WriteLine("UnDefined");            
            }
            else if (age < 12) 
            {
                Console.WriteLine($"{name}, you're too young!");
            }
            else 
            {
                Console.WriteLine($"Welcome,{name}");
            }
            //Ternar operation
            bool isReadyToWork = age > 25 ? true : false;
            if (isReadyToWork)
            {
                Console.WriteLine("Go to Work!");
            }
            else
            {
                Console.WriteLine("Relax");
            }
        }
    }
}
