using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            void SayMyName(string globalName = "SomeName")
            {
                Console.WriteLine("Say my name");
                string localname = Console.ReadLine();
                if (localname == globalName)
                {
                    Console.WriteLine($"You're god damn right, I'm {globalName}");
                }
                else
                {
                    Console.WriteLine("You're an IDIOT. SAY MY NAME");
                    SayMyName("Woltah");
                }
            }
            SayMyName("Woltah");

            int returnBullet(string pistol = "Degl", int Qshots = 0)
            {
                Console.WriteLine("Write Shot to Shoot");
                string localCondition = Console.ReadLine();
                if (localCondition == "Shot")
                {
                    Console.WriteLine($"{pistol} banged!");
                    return returnBullet(pistol, Qshots + 1);
                }
                else
                {
                    Console.WriteLine("Peace and flowers!");
                    return Qshots;
                }
            }
            int numberOfShots = returnBullet(Qshots: 0, pistol: "Makarov");
            Console.WriteLine($"Number of shots is {numberOfShots}");

            void sayHello() => Console.WriteLine("Hewo!");
            sayHello();

            int test(int one, int two) => one+two;
            int result = test(5, 10);
            Console.WriteLine(result);
        }
    }
}
