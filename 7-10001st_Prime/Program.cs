using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            /*By listing the first six prime numbers: 2, 3, 5, 7, 11, and 13, we can see that the 6th prime is 13.
            What is the 10 001st prime number?*/
            int limit=110000,counter=1;
            bool prime=true;
            for (int i = 2; i <= limit; i++)
            {
                if (i==2)
                {
                    //System.Console.WriteLine("{0}th prime number is: {1}",counter++,i);
                    counter++;
                    continue;
                }
                for (int j = 2; j < i; j++)
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
                    if (prime)
                    {
                        //System.Console.WriteLine("{0}th prime number is: {1}",counter++,i);
                        counter++;
                    }
                    else
                    {
                        break;
                    }
                }
                if (counter==10002) // 1th prime number is actually 0th prime number...
                {
                    System.Console.WriteLine("10001th prime number is {0}",i);
                    break;
                }
            }
        
        }
    }
}