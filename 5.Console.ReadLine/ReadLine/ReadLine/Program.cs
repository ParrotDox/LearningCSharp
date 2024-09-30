using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReadLine
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*When using console method "ReadLine"
             don't forget that user can input no information.
             We can check absence of information using ?*/
            var anything = Console.ReadLine();
            /*Using GetType() it is possible to find out
              the type of any variable*/ 
            Console.WriteLine(anything.GetType());
            /*Using Convert.___(variable) let you to
              convert types*/
            Console.WriteLine(Convert.ToInt32(anything).GetType());

        }
    }
}
