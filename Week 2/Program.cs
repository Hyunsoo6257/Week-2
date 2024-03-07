using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace Week_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const int Fahrenheit_value = 100;
            int Celsius = Fahrenheit_value - 32;


            double fahrenheit = 45;

            double celsius = (fahrenheit - 32) * (5 / 9);

            fahrenheit.ToString(F1); //F1 makes one decimal place
            celsius.ToString(F1);

        }

}
