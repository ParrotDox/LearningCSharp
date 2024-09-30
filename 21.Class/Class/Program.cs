using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Human 
{
    public string name;
    public int age;
    public Motherland motherland;
    public Human() : this("Unknown", 0, "Russia") { Console.WriteLine("1st"); }
    public Human(string n) : this(n,0, "Russia") { Console.WriteLine("2nd"); }
    public Human(string n, int a, string l) 
    {
        Console.WriteLine("3rd");
        this.name = n;
        this.age = a;
        motherland = new Motherland();
        this.motherland.location = l;
    }
    
    public void Deconstruct(out string outName, out int outAge, out Motherland outMotherland) 
    {
        outName = this.name;
        outAge = this.age;
        outMotherland = this.motherland;
    }
    public void printAll() 
    {
        Console.WriteLine($"name: {this.name} age: {this.age} motherland: {motherland.location}");
    }
}
class Motherland 
{
    public string location;
}

namespace Class
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Human broBoy = new Human();
            Human broBoyBuffled = new Human{ age = 18, name = "Kravicky", motherland =  { location = "Russia" }  };
            broBoyBuffled.printAll();

            string tempName;
            int tempAge;
            Motherland tempMotherland;

            ( _ , tempAge, tempMotherland) = broBoyBuffled;

            broBoy.Deconstruct(out tempName, out tempAge, out tempMotherland);
        }
    }
}
