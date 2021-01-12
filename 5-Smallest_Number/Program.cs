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
            bool interrupt = true;
            for (int i = 2; i < 1000000000; i++)
            {
                if (interrupt == false) // if counter = limit  break for loop
                {
                    break;
                }
                while (i % counter == 0 && counter <= limit) // if there is no remainder,it mean i can divide  counter variable and print i
                {
                    if (counter == limit)
                    {
                        Console.WriteLine(i);
                        interrupt = !interrupt;
                    }
                    counter++;
                }
                counter = 2;
            }
            Console.ReadKey();
        }
    }
}
