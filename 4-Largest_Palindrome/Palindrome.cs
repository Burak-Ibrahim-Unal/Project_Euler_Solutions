using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_Palindromic
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * A palindromic number reads the same both ways. The largest palindrome made from the product of two 2-digit numbers is 9009 = 91 × 99.
             * Find the largest palindrome made from the product of two 3-digit numbers.
             */
            int max = 0,final;
            bool isitPalindrome = false;
            for (int i = 2; i <1000; i++)
            {
                for (int j = 2; j < 1000; j++)
                {
                    string result = (i * j).ToString();
                    if (result.Length == 6)
                    {
                        for (int t = 0; t < result.Length; t++)
                        {
                            if (result[t] == result[result.Length - (t + 1)])
                            {
                                isitPalindrome = true;
                            }
                            else
                            {
                                isitPalindrome = false;
                                break;
                            }
                        }
                        if (isitPalindrome && Convert.ToInt32(result) > max)
                        {
                            max = Convert.ToInt32(result);
                        }
                    }
                    else
                    {
                        continue;
                    }
                }
            }
            Console.WriteLine(max);
            Console.ReadKey();
        }
    }
}
