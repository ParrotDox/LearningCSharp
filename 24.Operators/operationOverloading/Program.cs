using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Money;

namespace operationOverloading
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Cash m1 = new Cash(15);
            ++m1;
            m1++;
            m1.Print();
            Cash m2 = new Cash(25000, new Coin[] {new Coin("Trenny"), new Coin("GoldenPhillip") });
            m2.Print();
        }
    }
}
