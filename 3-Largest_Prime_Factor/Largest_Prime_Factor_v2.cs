using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
          /* The prime factors of 13195 are 5, 7, 13 and 29.
            What is the largest prime factor of the number 600851475143 ?*/
            long number = 600851475143;
            int i = 2;
            while (i < number)
            {
                if (number % i == 0)
                {
                    number /= i;
                    //Console.WriteLine(i);
                }
                else
                {
                    i++;
                }
            }
            Console.WriteLine(i);
        }
    }
}

