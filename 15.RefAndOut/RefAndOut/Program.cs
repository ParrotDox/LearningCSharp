using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RefAndOut
{
    internal class Program
    {
        static void Main(string[] args)
        {
            void increment(int num) 
            {
                num++;
                Console.WriteLine("Inside inc:" + num);
            }
            void incrementRef(ref int num)
            {
                num++;
                Console.WriteLine("Inside Ref:" + num);
            }

            int number = 0;
            Console.WriteLine("Before inc and ref: " + number);
            increment(number);
            Console.WriteLine("After inc: " + number);
            incrementRef(ref number);
            Console.WriteLine("After ref:" + number);

            void summaryOut(int x, int y, out int res)
            {
                res = x + y;
            }
            int num1 = 13;
            int num2 = 15;
            int result;
            summaryOut(num1, num2, out result);
            Console.WriteLine(result);

            void getRectangleCube(int x, out int area, out int volume) 
            {
                area = x * x;
                volume = x * x * x;
            }

            int areaRes = 0;
            int volumeRes = 0;
            getRectangleCube(5, out areaRes, out volumeRes);

            Console.WriteLine($"{areaRes} : {volumeRes}");
        }
    }
}
