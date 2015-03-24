using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumbersAndStrings
{
    class Program
    {
        static void Main(string[] args)
        {
            var increment = 35;
            var bankBalance = 0;

            for (int i = 0; i < 365; i++) 
            {
                bankBalance += increment;
                
            }

            Console.WriteLine("Your account balance after one year is {0:C2}.", bankBalance);
            Console.WriteLine("Your account balance after two years is {0:C2}.", bankBalance * 2);
            Console.WriteLine("Your account balance after five years is {0:C2}.", bankBalance * 5);
            Console.WriteLine("Your account balance after ten years is {0:C2}.", bankBalance * 10);

            Console.ReadLine();

        }
    }
}
