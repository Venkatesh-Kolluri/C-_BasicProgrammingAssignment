using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicProgramming
{
    internal class Power
    {
       /* static void Main(string[] args)
        {
            int num;
            int power;

            Console.WriteLine("Input the base value");
            num = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Input the power value ");
            power = Convert.ToInt32(Console.ReadLine());

            int result = powerOf(num, power);
            Console.WriteLine(result);

        }*/
        public static int powerOf(int num, int power)
        {
            int result = 1;

            for (int i = 1; i <= power; i++)
            {
                result = num * result;
            }
            return result;
        }

    }
}
