using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            *Creating an arrays
            int[] arrayName;
            int[] arrayName = new int[5]; //{0,0,0,0,0}
            int[] arrayName = new int[5] {1,2,3,4,5};
            int[] arrayName = new int {1,2,3,4,5};
            int[] arrayName = new {1,2,3,4,5};
            int[] arrayName = {1,2,3,4,5};

            *Adress the elem
            Console.WriteLine(arrayName[index]);

            *Adress the elem from end
            Console.WriteLine(arrayName[^1]);
            -->Answer: 5

            *Change the adressed element
            arrayName[2] = 13;
            -->Answer: {1,2,13,4,5}

            *Initialize the variable
            var variable = arrayName[index];

            *Length method
            To find a length of an array
            length method preffered
            Console.WriteLine(arrayName.Length);

            *Iterate over array
            foreach(int elem in arrayName)
            {
                Console.WriteLine(elem);
            }
            for(int i = 0; i < arrayName.Length; ++i)
            {
                Console.WriteLine(arrayName[i]);
            }
            while(i < arrayName.Length)
            {
                Console.WriteLine(arrayName[i]);
                ++i;
            }
             */

            /*
            *Creating two-dimensional array
            int[,] matrix;
            int[,] matrix = new int[2,3];
            int[,] matrix = new int[2,4];
            int[,] matrix = new int[2,4] {{2,3,2,3},{4,5,4,5}};
            int[,] matrix = new int[,] {{2,3,2,3},{4,5,4,5}};
            int[,] matrix = new [,]{{2,3,2,3},{4,5,4,5}};
            int[,] matrix = {{2,3,2,3},{4,5,4,5}};

            *Iterating through bidimensional array (NEW)
            int[,] matrix = new int[2, 3]  { {1, 2, 3 }, { 1, 2, 3 } };
            Console.WriteLine(matrix.Length);
            for(int i = 0; i < matrix.GetUpperBound(0)+1; i++) 
            {
                for(int j = 0; j < matrix.GetUpperBound(1)+1; j++)
                    Console.WriteLine(matrix[i,j]);
            }
             */
            int[,] matrix = new int[2, 3]  { {1, 2, 3 }, { 1, 2, 3 } };
            Console.WriteLine(matrix.Length);
            for(int i = 0; i < matrix.GetUpperBound(0)+1; i++) 
            {
                for(int j = 0; j < matrix.GetUpperBound(1)+1; j++)
                    Console.WriteLine(matrix[i,j]);
            }
            /*
            *Creating array of arrays
            int[][] arr = new int[3][];

            */
            int[][] arrOfarr = new int[3][];
            arrOfarr[0] = new int[1] { 1 };
            arrOfarr[1] = new int[2] { 2,2 };
            arrOfarr[2] = new int[3] { 3,3,3 };
            int[][] arrOfarr2 = {
                new int[3] {11,24,37},
                new int[4] {81,92,13,4},
                new int[2] {01,001}
            };
            for(int i = 0; i < arrOfarr2.Length; i++) 
            {
                for(int j = 0; j < arrOfarr2[i].Length; j++) 
                {
                    Console.WriteLine(arrOfarr2[i][j]);
                }
            }


            int[,,] mas = new int[4, 2, 2] 
              { { { 1, 2 },{ 3, 4 } },
                { { 4, 5 }, { 6, 7 } },
                { { 7, 8 }, { 9, 10 } },
                { { 10, 11 }, { 12, 13 } }
              };
            Console.Write('{');
            for (int level0 = 0;  level0 < mas.GetUpperBound(0)+1; level0++) 
            {
                Console.Write('{');
                for(int level1 = 0; level1 < mas.GetUpperBound(1) + 1; level1++)
                {
                    Console.Write('{');
                    for (int level2 = 0; level2 < mas.GetUpperBound(2) + 1; level2++)
                    {
                        Console.Write(mas[level0,level1,level2]);
                    }
                    Console.Write('}');
                }
                Console.Write('}');
            }
            Console.Write('}');

        }
    }
}
