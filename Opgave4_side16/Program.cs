using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opgave4_side16
{
    class Program
    {
        static void Main(string[] args)
        {
            //Input "decimaltal"
            Console.WriteLine("Indtast decimatal");
            int decimaltal = Convert.ToInt32(Console.ReadLine());

            //Der omregnes til binære tal
            string binary = Convert.ToString(decimaltal, 2);
            string hex = decimaltal.ToString("X");

            //Output
            Console.Clear();
            Console.WriteLine("{0} Decimal is {1} in binary",decimaltal ,binary);
            Console.WriteLine("{0} Decimal is {1} in hexadecimal", decimaltal, hex);
            //Slut
            Console.ReadKey();




        }
    }
}
