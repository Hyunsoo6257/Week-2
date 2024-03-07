using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Week_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //InchesToCentimeters();
            //MoveEstimator();
            //Egg();
            const int BASE_RATE = 200;
            const int HOURLY_RATE = 150;
            const int RATE_PER_MILE = 2;
            Console.Write("Please enter number of hours ");
            double hours = Convert.ToDouble(Console.ReadLine());
            Console.Write("Please enter number of miles ");
            double miles = Convert.ToDouble(Console.ReadLine());
            double movingFee = BASE_RATE + hours * HOURLY_RATE + miles * RATE_PER_MILE;

            Console.WriteLine(movingFee);

        }
        /*
        static void InchesToCentimeters() {
            const double INCHIES_TO_CENTIMETERS = 2.54;
            // making it Capital cuz it's constant
            double inches = 3;
            double centimeters;
            centimeters = inches * INCHIES_TO_CENTIMETERS;
            Console.WriteLine("Number of inches and centimeters " + inches + "," + centimeters);
        }
        */
        /*
        static void MoveEstimator() {
            double move=1; 
            double hour=2; 
            double mile=3; 
            double estimation = 200 * move + 150 * hour + mile * 2;
            Console.WriteLine("$"+estimation);

        }
        
        */

        /*
        static void Egg() {
            Console.Write("Please enter egg from chicken1 ");
            int egg1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Please enter egg from chicken2 ");
            int egg2 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Please enter egg from chicken3 ");
            int egg3 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Please enter egg from chicken4 ");
            int egg4 = Convert.ToDouble(Console.ReadLine());


            int sumEgg = egg1 + egg2 + egg3 + egg4;
            Console.WriteLine(sumEgg / 12 + "dozen " + sumEgg % 12 + "eggs");
        }
        */
        

        static void MakeChange() {
            int dollars = 113;

        }

    }
}
