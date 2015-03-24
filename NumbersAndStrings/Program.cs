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

            //int width;
            //int height;

            ////Get width of parcel
            //Console.WriteLine("Width of parcel:");
            //width = Convert.ToInt32(Console.ReadLine());

            ////get height of parcel
            //Console.WriteLine("height of parcel:");
            //height = Convert.ToInt32(Console.ReadLine());

            ////Calculate cost of square footage
            //var squareFootCost = (width * height) * 5;

            ////Get total Perimiter 
            //var perimiterCost = ((width + height) * 2) * 0.75;

            ////Show Total

            //var totalLandCost = (squareFootCost + perimiterCost).ToString("C2");
            //Console.WriteLine(totalLandCost);
            //Console.ReadLine();


            /*
            Space Exploration
            */

            var shipSpeed = 10000.00;
            var speedIncrement = (shipSpeed * 0.05);
            var newShipSpeed = shipSpeed + speedIncrement;

            for (int j = 0; j < 120; j += 15)
            {

                for (int i = 0; i < 10; i++)
                {
                    newShipSpeed = newShipSpeed * 1.05;
                }

            }

            Console.WriteLine(newShipSpeed);

            Console.ReadLine();


        }
    }
}
