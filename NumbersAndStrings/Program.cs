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
            /*
            Accumulation
            */

            //var increment = 35;
            //var bankBalance = 0;

            //for (int i = 0; i < 365; i++) 
            //{
            //    bankBalance += increment;
                
            //}

            //Console.WriteLine("Your account balance after one year is {0:C2}.", bankBalance);
            //Console.WriteLine("Your account balance after two years is {0:C2}.", bankBalance * 2);
            //Console.WriteLine("Your account balance after five years is {0:C2}.", bankBalance * 5);
            //Console.WriteLine("Your account balance after ten years is {0:C2}.", bankBalance * 10);

            //Console.ReadLine();

            /*
            Land Cost Calculator
            */

            int width;
            int height;

            //Get width of parcel
            Console.WriteLine("Width of parcel:");
            width = Convert.ToInt32(Console.ReadLine());

            //get height of parcel
            Console.WriteLine("height of parcel:");
            height = Convert.ToInt32(Console.ReadLine());

            //find area of parcel
            var area = width * height;
            
            //Calculate cost of square footage
            var squareFootCost = (area * 5);

            //Get total Perimiter
            var perimiterTotal = ((width + height) * 2);

            //Get Perimiter Cost
            var perimiterCost = (perimiterTotal * 0.75);

            //Show Total

            var totalLandCost = (squareFootCost + perimiterCost).ToString("C2");
            Console.WriteLine(totalLandCost);
            Console.ReadLine();
        }
    }
}
