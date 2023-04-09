using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicProgramming
{
    internal class LeapYear
    {
     /*   public static void Main(string[] args)
        {
            int year;
            Console.WriteLine("Enter the year: ");
            year = Convert.ToInt32(Console.ReadLine());
            leapYear(year);

        }*/
        public static void leapYear(int year)
        {
            if (((year % 4 == 0) && (year % 100 != 0)) || (year % 4 == 0))
            {
                Console.WriteLine("It is a leap year");
            }
            else
            {
                Console.WriteLine("It is not a leap year");
            }

        }
    }
}
