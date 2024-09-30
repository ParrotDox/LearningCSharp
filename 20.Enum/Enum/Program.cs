using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
enum colors
{
    white = 2, //2
    red, //3
    green, //4
    blue //5
}
enum test : byte 
{
    byt1 = 0,
    byt2 = 1,
    byt3 = 2,
    byt4 = 3,
    byt5 = 4
}
enum Day : int
{
    Monday = 5,
    Tuesday,
    Wednesday,
    Thursday = 14,
    Friday = Tuesday,
    Saturday,
    Sunday
}
namespace Enum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            colors color = colors.red;
            Console.WriteLine(color);
            Console.WriteLine((int)color);
            test t = test.byt3;
            Console.WriteLine((byte)t);
            Day d = Day.Sunday;
            Console.WriteLine((int)d);
        }
    }
}
