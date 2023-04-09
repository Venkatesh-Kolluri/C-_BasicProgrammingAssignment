using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicProgramming
{
    internal class EvenOdd
    {
        public static void Main(string[] args)
        {
            int a;
            Console.WriteLine("Enter a number to find even or odd");
            a = Convert.ToInt32(Console.ReadLine());

            if (a % 2 == 0)
            {
                Console.WriteLine("The nummber is an even number");
            }
            else
            {
                Console.WriteLine("The number is an odd number");
            }
        }
    }
}
