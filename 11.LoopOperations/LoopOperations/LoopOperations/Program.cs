using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoopOperations
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Four types of loops
            /*
             for
             foreach
             while
             do...while*/
            //FOR
            /*
             syntax: for(operation before cycle;
                         requirement;
                         operation after cycle)
                     {
                        some operations;
                     }
             */
            for(int i = 1; i <= 3; ++i) 
            {
                Console.WriteLine($"Index: {i}");
            }
            int value = 1;
            for (Console.WriteLine($"Start of loop {value}"); value <= 3;) 
            {
                
                Console.WriteLine($"Iteration: {value}");
                value++;
            }
            bool requirement = false;
            uint counter = 0;
            uint summa = 0;
            for (Console.WriteLine("Start"); requirement != true ; Console.WriteLine($"Value is {summa}")) 
            {
                Console.WriteLine("1");
                if (summa > 50)
                {
                    requirement = true;
                }
                if (counter % 2 == 0) 
                {
                    summa += counter;
                }
                counter++;
            }
            //DO- WHILE
            /*
             Syntax: do
                     {
                        operations;
                     }
                     while(requirement);
             */
            string name = "";
            string buffer;
            do
            {
                Console.WriteLine("Write \"Egor\" symbol by symbol");
                buffer = Console.ReadLine();
                name += buffer;
                buffer = "";
            } while (name != "Egor");
            //WHILE
            /*
             Syntax: while(requirement)
                     {
                        operations;
                     }
             */
            name = "";
            buffer = "";
            while (name != "Egor")
            { 
                Console.WriteLine("Write \"Egor\" symbol by symbol");
                buffer = Console.ReadLine();
                name += buffer;
                buffer = "";
            };
            foreach(char letter in name) 
            {
                Console.WriteLine(letter);
            }
            //Task
            int input1, input2;
            while(true) 
            {
                Console.WriteLine("Number 1");
                input1 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Number 2");
                input2 = Convert.ToInt32(Console.ReadLine());
                if ((input1 > 0 && input1 < 10) && (input2 > 0 && input2 < 10))
                {
                    Console.WriteLine($"Result of multiplication {input1 * input2}");
                    break;
                }
                else
                {
                    Console.WriteLine("Input again");
                }
            }
        }
    }
}
