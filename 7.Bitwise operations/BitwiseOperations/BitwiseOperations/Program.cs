using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BitwiseOperations
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Bitwise operations are unique
              because all of them are performed
              over binary charges of number.
              For example, 2 in binary representation is
              10; 7 in binary representation is 111.
              The first number has only two charges when
              the second has three.*/

            //-------------------------//
            //Logical operations
            //-------------------------//
            //& - logical multiplication
            /*The principle of work is easy.
             Just multiplicate charge-equal binary
             digits and put the results in order of
             completion one after another and get new number.
             Let's take two numbers: x1=2; x2=5;
             Their binary performance: x1=0b010; x2=0b101;
             
             0 * 1 = 0
             1 * 0 = 0
             0 * 1 = 0
             Answer is 0b000. Decimal representation is 0!
             */
            int x1 = 3; //0b011;
            int x2 = 5; //0b101;
            Console.WriteLine(x1&x2); //0*1 1*0 1*1 -> 0b001 = 1

            //-------------------------//
            //| - logical addition
            /*The principle is same as the multiplication
              but instead of multiplication the addition is
              performed.
              Let's take two numbers: x1=5; x2=3;
              Their binary performance: x1=0b101; x2=0b011;
             
             1 + 0 = 1
             0 + 1 = 1
             1 + 1 = 1
             Answer is 0b111. Decimal representation is 7!
            */
            int y1 = 5; //0b101
            int y2 = 3; //0b011
            Console.WriteLine(y1 | y2); //1*0 0*1 1*1 -> 0b111 = 7

            //-------------------------//
            //^ - logical excluding "or"
            /*This operation is used to simple
              encryption.Also, this operation
              is called XOR. The algorithm is simple.
              Let's take two numbers, first will be a
              value and the second will be a key to encrypt
              the value:
              z1=20; z2=102;
              Their binary performance: z1=0b10100; z2=0b1100110;
              z1:     0 0 1 0 1 0 0
              ^
              z2:     1 1 0 0 1 1 0
              result: 1 1 1 0 0 1 0. Decimal representation 114
             */
            int z1 = 20;
            int z2 = 102;
            Console.WriteLine(z1 ^ z2);

            //-------------------------//
            //~ - logical deny or inversion
            /*This operation just inverts the charges
             of the number and adding minus. Easy!
             Let's take number h1=5;
             It's binary performance: h1=0b101;
             h1:    1 0 1        |-adding +1 to the end
             ~                   |    |-adding 1 to the left side
                                 |    Y          Y Y Y Y - invert number
            result: 0 1 0 -> 0 1 1 -> 1 0 1 1 -> 0 1 0 0. Decimal representation is -6
             */
            int h1 = 5;
            Console.WriteLine(~h1);

            //-------------------------//
            //<< and >> - bit shift
            /*<< - shift bits to the left
              >> - shift bits to the right
              Syntax: int a = 0b1000;
                      a = a >> 2;
              Result: a = 0b10;
              Shifts are used to compress files.
              For example, you have int values and you
              want to manipulate them and compress into
              one variable:
             */
            int num1 = 3; //0b11
            int num2 = 2; //0b10
            int num3 = 1; //0b01
            int result = 0b0;
            result = result | num1; //result is 0b 11
            result = result << 2;   //result is 0b 11 00
            result = result | num2; //result is 0b 11 10
            result = result << 2;   //result is 0b 11 10 00
            result = result | num3; //result is 0b 11 10 01
            //result is 0b {11} {10} {01} {binary_value}
            //And now, let's drag numbers from { }
            int box1;
            int box2;
            int box3;
            box3 = result & 0b11;
            result = result >> 2;   //result is 0b 11 10 
            box2 = result & 0b11;   
            result = result >> 2;   //result is 0b 11
            box1 = result & 0b11;
            Console.WriteLine($"1:{box1} 2:{box2} 3:{box3}");

            //-------------------------//
            Console.WriteLine("Practise here under:");
            Console.WriteLine("Task: get number 7 by using binary numbers and &-operation");
            Console.WriteLine(0b11111 & 0b00111);
            Console.WriteLine("Task: get number 12 by using binary numbers and &-operation");
            Console.WriteLine(0b11111 & 0b001100);
            Console.WriteLine("Task: get number 3 by using binary numbers and |-operation");
            Console.WriteLine(0b010 | 0b001);
            Console.WriteLine("Task: get number 23 by using binary numbers and |-operation");
            Console.WriteLine(0b000000 | 0b010111);
            Console.WriteLine("Task: get number 10 by using binary numbers and ^-operation");
            Console.WriteLine(0b100111010 ^ 0b100110000);
            Console.WriteLine("Task: get number 10 by using binary numbers and ^-operation");
            Console.WriteLine(0b100111010 ^ 0b100110000);
            Console.WriteLine("Task: get number 9 by using binary numbers and ^-operation");
            Console.WriteLine(0b011110 ^ 0b010111);
            Console.WriteLine("Task: get number -10 by using binary numbers and ~-operation");
            Console.WriteLine(~9);
            Console.WriteLine(~0b1001);
            Console.WriteLine("Task: pack 3 number into 1 data cell");
            int value1 = 0b001;
            int value2 = 0b101;
            int value3 = 0b1111;
            int dataCell = 0b0000;
            dataCell = dataCell | value1;
            dataCell = dataCell << 4;
            dataCell = dataCell | value2;
            dataCell = dataCell << 4;
            dataCell = dataCell | value3;
            Console.WriteLine(Convert.ToString(dataCell, 2));
        }
    }
}
