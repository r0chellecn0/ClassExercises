using System;
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
			if (number <= 0)
			{
				return false;
			}
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

		public static bool isPrimeQ(int num)
		{
			for(int i=2; i<num; i++)
			{
				if (num % i == 0)
				{
					return false;
				}
			}
			return true;
		}

		public static int sumOfNums(int num)
		{
			int sum = 0;
			for (int i=2; i<=num; i++)
			{
				if (isPrimeQ(i))
				{
					sum += i;
				}
			}
			Console.WriteLine(sum);
			return sum;
		}
       
        static void Main(string[] args)
        {
            //SumOfPrimes(12);
            //CountPrimes(9);
			//IsPrime(-70);
			isPrimeQ(9);
			sumOfNums(200);
        }
    }
}
