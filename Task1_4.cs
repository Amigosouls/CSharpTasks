using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpTasks
{
    internal class Task1_4
    {
        /// <summary>
        /// all decimal numbers are suffixed with m or M
        /// all float numbers are suffixed with f or F
        /// all double numbers are suffixed with d or D but not mandatory
        /// by default  all fractions are doubles
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            decimal num1 = 240.624545454545454545454545E-2m; 
            float num2 = 240.624545454545454545454545E-2f;
            double num3 = 240.624545454545454545454545E-2;
            Console.WriteLine($"The Size of double:{sizeof(double)}");
            Console.WriteLine($"The Size of float:{sizeof(float)}");
            Console.WriteLine($"The Size of decimal:{sizeof(decimal)}");

            Console.WriteLine($"Precission of different numeric types:");
            Console.WriteLine($"Float:{num2 / 3}");
            Console.WriteLine($"Double:{num3 / 3}");
            Console.WriteLine($"Decimal:{num1 / 3}");


        }

    }
}
