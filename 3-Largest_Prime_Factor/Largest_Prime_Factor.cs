using System;


namespace Rextester
{
    public class Program
    {
        public static void Main(string[] args)
        {
            // List<int> numbers = new List<int>();
            /*The prime factors of 13195 are 5, 7, 13 and 29.what is the largest prime factor of the number 600851475143 ?*/
            double max=0;
            for(double i=2;i<600851475143;i++){
                if(600851475143%i==0){
                    bool asalmi=true;     
                    for(double j=2;j<i;j++){
                        if(i%j==0){
                            asalmi=false;
                            break;
                        }
                    }
                    if(asalmi){
                        if(max < i){
                            max = i;
                        }
                        //Console.WriteLine(i+"\t");                      
                    }
                }
            }
            Console.WriteLine(max+"\t");       
        }
    }
}