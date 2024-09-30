using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Placeholders
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string model = "X-200";
            ushort year = 2018;
            ushort price = 200;
            Console.WriteLine($"Camera model:{model}\n" +
                $"Year of announcement:{year}\n" +
                $"Price:{price}");
            Console.WriteLine("Camera model:{0}\n" +
                "Year of announcement:{1}\n" +
                "Price:{2}", model, year, price);
        }
    }
}
