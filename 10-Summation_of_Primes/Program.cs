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
          /* The sum of the primes below 10 is 2 + 3 + 5 + 7 = 17.
            Find the sum of all the primes below two million.*/
            long forlimit=110000,counter=0,sum=0,sumlimit=10;
            bool prime=true;
            for (int i = 2; i <= forlimit; i++)
            {
                if (i==2)
                {
                    System.Console.WriteLine("{0}th prime number is: {1}",++counter,i);
                    sum+=i;
                    continue;
                }
                for (long j = 2; j < i; j++)
                {
                    while (j<i)
                    {
                        if (i%j!=0)
                        {
                            j++;
                            prime=true;
                        }
                        else{
                            prime=false;
                            break;
                        }
                    }
                    if (prime && i<10)
                    {
                        System.Console.WriteLine("{0}th prime number is: {1}",++counter,i);
                        sumlimit+=i;
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

