using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Types
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             Types of Data
             */
            //bool
            bool isActive = false;
            //byte 0-255
            byte cellOne = 0;
            byte cellTwo = 255;
            //sbyte (-128)-127
            sbyte scellOne = -128;
            sbyte scellTwo = 127;
            //short (-32768)-32767
            short shortVar1 = -32768;
            short shortVar2 = 32767;
            //ushort 0-65535
            ushort ushortVar1 = 0;
            ushort ushortVar2 = 65535;
            //int (-2147483648-2147483647)
            int intVar1 = 15;
            int intVar2 = 0b01111;
            int intVar3 = 0xE;
            //uint (0-4294967295)
            uint uintVar1 = 4294967295;
            //long ((–9 223 372 036 854 775 808) - 9 223 372 036 854 775 807)
            long longVar = 100000000000000000;
            //ulong just the same as prev uVars and without -
            //char
            char letter = 'A';
            //string
            string sentence = "My pug rules da world!";
            //float < double
            //decimal - contains value of mantissa
            decimal decimalVar = 5.3467M;
            Console.WriteLine(decimalVar);
            /*object - base type of data for other types.
              Can be any type */
            object obj1 = "Here";
            object obj2 = 'B';
            object obj3 = 123.5;

            //About suffixes
            //float floatVar1 = 10.5; ERROR
            float floatVar = 10.5f;
            Console.WriteLine(floatVar);
            double floatVar2 = 10.5;
            decimal decimalVar2 = 15.3333m;
            Console.WriteLine(decimalVar2);
            //Not obvious typization
            var word1 = "Hello";
            var number1 = 1;
            /*Because of the unknown type of data
             it is impossible to create a var variable
            without inicialization*/
            //var word2; ERROR
            string word2;
        }
    }
}
