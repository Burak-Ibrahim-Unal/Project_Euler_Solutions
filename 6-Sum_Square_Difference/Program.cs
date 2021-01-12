using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6_Sum_Square_Difference
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * The sum of the squares of the first ten natural numbers is,1^2+2^2+3^2+ ... +10^2 =  385
The square of the sum of the first ten natural numbers is,(1+2+3+...+10)=55^2 = 3025
Hence the difference between the sum of the squares of the first ten natural numbers and the square of the sum is . (3025-385= 2640)

Find the difference between the sum of the squares of the first one hundred natural numbers and the square of the sum. 
Result: 25164150*/
            int sumSquare = 0, square = 0;
            for (int i = 1; i <= 100; i++)
            {
                square += i * i;
                sumSquare += i;
            }
            Console.WriteLine((sumSquare * sumSquare) - square);
            Console.ReadKey();
        }
    }
}
