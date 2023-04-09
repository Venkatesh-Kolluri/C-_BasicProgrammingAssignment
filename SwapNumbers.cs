using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicProgramming
{
    internal class SwapNumbers
    {
        public static void Main(string[] args)
        {
            int a;
            int b;
            Console.WriteLine("Enter First Number: ");
            a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Second Number: ");
            b = Convert.ToInt32(Console.ReadLine());

            swap(a, b);
        }
        public static void swap(int a,int b)
        {
            a = a + b;
            b = a - b;
            a = a - b;
            Console.WriteLine("a: "+a);
            Console.WriteLine("b: "+b);
        }
    }
}
