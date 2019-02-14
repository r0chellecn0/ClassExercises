﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prime
{
    public class Program
    {
        public static bool IsPrime(int number)
        {
            for(int i = 2; i<number; i++)
            {
                if(number%i==0)
                {
                    return false;
                }
            }
            return true;
        }

       public static int SumOfPrimes(int number)
       {
           int sum = 0;
       
                   for (int i = 2; i < number; i++)
                   {
                   if (IsPrime(i))
                       sum += i;
                   }
            Console.WriteLine(sum);
               
           return sum;
       
       }

        public static int CountPrimes(int number)
        {
            int count = 0;
            for (int i=2; i<number; i++)
            {
                if (IsPrime(i))
                    count++;
            }
            Console.WriteLine(count);
            return count;
        }
       
        static void Main(string[] args)
        {
            SumOfPrimes(12);
            CountPrimes(9);
        }
    }
}
