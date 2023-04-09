using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicProgramming
{
    internal class HarmonicNumber
    {
        static void Main(string[] args)
        {
            float i;
            int y;
            double d = 0;

            Console.WriteLine("Enter the number of terms: ");
            y = Convert.ToInt32(Console.ReadLine());

            for (i = 1; i <= y; i++)
            {
                Console.Write("1/" + i + " + ");
                d = d + 1 / i;


            }
            Console.WriteLine();
            Console.WriteLine("Sum of Series Upto 6 terms: " + d);
        }
    }
}
