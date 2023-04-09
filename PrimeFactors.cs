using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicProgramming
{
    internal class PrimeFactors
    {
       public static void Main(string[] args)
        {
            int num;
            Console.WriteLine("Enter a number to find factorial: ");
            num = Convert.ToInt32(Console.ReadLine());
            int result = primeFact(num);
            Console.WriteLine(result);

        }
        public static int primeFact(int num)
        {
            int result = 1;
            for(int i=1; i<=num; i++)
            {
                result = result* i;
            }
            return result;

        } 

    }
}
