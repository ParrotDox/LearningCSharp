using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Switch
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool workState = true;
            do
            {
                char cmd = Console.ReadKey().KeyChar;
                switch (cmd) 
                {
                    case 'a':
                        {
                            Console.WriteLine("Danger class A");
                            break;
                        }
                    case 'b':
                        {
                            Console.WriteLine("Danger class B");
                            break;
                        }
                    case '0':
                        {
                            workState = false;
                            break;
                        }
                    default:
                        Console.WriteLine("Danger class D");
                        break;
                }
            }
            while (workState);
        }
    }
}
