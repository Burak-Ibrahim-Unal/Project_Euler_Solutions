using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program


        static void Main(string[] args)
        {
          /* The sum of the primes below 10 is 2 + 3 + 5 + 7 = 17.
            Find the sum of all the primes below two million.*/
            //142913828922
            long number = 2000000;
            List<long> primeList = new List<long>();
            primeList.Add(2);
            long total = 2;
            for (long i = 3; i <= number; i += 2)
            {
                bool isPrimeNumber = false;
                foreach (long j in primeList)
                {
                    if (i % j == 0)
                    {
                        isPrimeNumber = false;
                        break;
                    }
                    else
                    {
                        isPrimeNumber = true;
                    }
                }
                if (isPrimeNumber)
                {
                    primeList.Add(i);
                    total += i;
                }
            }
            Console.WriteLine(total);
        }
    }
}

