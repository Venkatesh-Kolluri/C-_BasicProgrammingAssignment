using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicProgramming
{
    internal class QueRem
    {
       /* public static void Main(string[] args)
        {
            int a;
            int b;
            Console.WriteLine("Enter Dividend number: ");
            a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Divisior: ");
            b = Convert.ToInt32(Console.ReadLine());

            int result1 = quotient(a, b);
            int result2 = reminder(a, b);
            Console.WriteLine("Quotient: " + result1);
            Console.WriteLine("Reminder: " + result2);

        }*/
        public static int quotient(int a, int b)
        {
            int result1 = a / b;
            
            return result1;
        }
        public static int reminder(int a,int b)
        {
            int result2 = a % b;
            return result2;
        }
    }
}
