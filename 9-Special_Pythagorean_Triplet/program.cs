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
          /* A Pythagorean triplet is a set of three natural numbers, a < b < c, for which,

            a2 + b2 = c2
            For example, 32 + 42 = 9 + 16 = 25 = 52.

            There exists exactly one Pythagorean triplet for which a + b + c = 1000.
            Find the product abc.*/
            for (int i = 0; i < 1000; i++)
            {
                for (int j = 0; j < 1000; j++)
                {
                    for (int k = 0; k < 1000; k++)
                    {
                        while (i<j && j<k)
                        {
                            if (i+j+k==1000 && i*i + j*j == k*k)
                            {
                                System.Console.WriteLine("{0}square + {1}square = {2}square",i,j,k);
                                System.Console.WriteLine("Multiplaction of these numbers is:{0}",i*j*k);
                                break;
                            }
                            else
                            {
                                break;
                            }
                        }
                    }
                }
            }

        }
    }
}

