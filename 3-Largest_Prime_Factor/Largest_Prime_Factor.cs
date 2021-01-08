using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_Prime_Factor
{
    class Program
    {
        static void Main(string[] args)
        {
            /// Asal Bölenler
            long max = 0;
            long number = 13195; //600851475143 
            bool isitPrimeFactor;
            for (long i = 2; i < number; i++)
            {
                if (number % i == 0)
                {
                    isitPrimeFactor = true;
                    for (long j = 2; j < i; j++)
                    {
                        if (i % j == 0)
                        {
                            isitPrimeFactor = false;
                            break;
                        }
                    }
                    if (isitPrimeFactor)
                    {
                        if (max < i)
                        {
                            max = i;
                        }
                        //Console.WriteLine(i);
                    }
                }
            }
            Console.WriteLine("Max prime factor is {0}",max);
            Console.ReadKey();
        }
    }
}
