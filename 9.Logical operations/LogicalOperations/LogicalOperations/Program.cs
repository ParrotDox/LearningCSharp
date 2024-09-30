using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalOperations
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Here I'm gonna talk only about
             things that I don't remember or
             don't know
             | - or
             || - or (but faster because 
                      if the first value is true 
                      then there is no reason to 
                      check the second value because
                      the result will be the same.)
             The same
             & - and
             && - and (but faster. If the first value
                       is false, then the result will be
                       false)

             ^ - excluding or (the values can't be the same. If they are
                               not the same then the result is true, else - false)
             */
            Console.WriteLine("^-operation");
            Console.WriteLine(false ^ false);
            Console.WriteLine(false ^ true);
            Console.WriteLine(true ^ true);
        }
    }
}
