using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalPrograms
{
    public class Prime
    {
        public static void PrimeNumber()
        {
            int n, i, flag = 0;

            Console.Write("Enter a positive integer: ");
            n = Convert.ToInt32(Console.ReadLine());

            for (i = 2; i <= n / 2; i++)
            {
                if (n % i == 0)
                {
                    flag = 1;
                    break;
                }
            }

            if (n == 1)
            {
                Console.WriteLine("1 is neither prime nor composite.");
            }
            else
            {
                if (flag == 0)
                {
                    Console.WriteLine("{0} is a prime number.", n);
                }
                else
                {
                    Console.WriteLine("{0} is not a prime number.", n);
                }
            }
        }
    }
}
    

