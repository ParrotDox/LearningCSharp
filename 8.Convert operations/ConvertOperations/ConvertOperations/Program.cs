using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConvertOperations
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Different types of variables
             demand different bytes of memory
             So, you can't put an int value in
             byte-variable. In this case, you should
             obviously show how to interpret the
             math operation
             */
            //Example
            int value1 = 10;
            byte value2 = 23;
            //ERROR! byte result = value1 + value2;
            //Do this instead
            byte result = (byte)(value1 + value2);
            Console.WriteLine(result);

            /*Also, C# let us to make the byte-range
              of variable wider or narrower. Using
              assign sign user can extend or narrow down
              a variable
              main chains:
                byte -> short -> int -> long -> decimal

                int -> double

                short -> float -> double

                char -> int
             */
            byte value3 = 0b100;
            ushort value3_bigger = value3; //0b000000000000100 <-wider range!
        }
    }
}
