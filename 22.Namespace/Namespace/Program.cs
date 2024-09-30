using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using City;
using Newtonsoft.Json;
using static System.Console;

namespace Namespace
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Hospital h1 = new Hospital(1896, 200000, 1000, 100);
            h1.GetInfo();
            Building b1 = new Building(1900, 100000);
            b1.GetInfo();
            Hospital hc = new Hospital(2000, 50, b1);
            hc.GetInfo();
            Building.CheckPrice(h1);
            Hospital.CheckPrice(h1);
            Console.WriteLine(Building.country);
            string json = JsonConvert.SerializeObject(h1);
            Console.WriteLine(json);
            Console.WriteLine(Building.type);
            WriteLine(json);
        }
    }
}
