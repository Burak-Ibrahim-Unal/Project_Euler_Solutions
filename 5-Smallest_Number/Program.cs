using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5_Smallest_Number
{
    class Program
    {

        static void Main(string[] args)
        {
            /*2520 is the smallest number that can be divided by each of the numbers from 1 to 10 without any remainder.
            What is the smallest positive number that is evenly divisible by all of the numbers from 1 to 20?*/
            // 2520 - 232792560
            int limit = 20, counter = 2;
            bool interrupt;
            for (int i = 2; i < 1000000000; i++)
            {
                interrupt = true;
                while (i%counter==0 && counter <= limit)
                {
                    interrupt = !interrupt;
                    if (counter == limit)
                    {
                        Console.WriteLine(i);
                    }
                    counter++;
                }
                if (counter == limit)
                    break;
                counter = 2;

            }
            Console.ReadKey();
        }
    }
}
