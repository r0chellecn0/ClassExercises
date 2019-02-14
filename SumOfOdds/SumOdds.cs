using System;

namespace whiteboaard
{
    public class SumOdds
    {

        public static int CollectSumOdds(int maxValue)
        {
            int sum=1;
            if (maxValue > 0 && maxValue < 256)
                for (int i = 1; i < 256; i++)
                    if (i % 2 == 1)
                    {
                        sum += i;
                    }
            return sum;
        }

        public static int CollectSumOdds(int minValue, int maxValue)
        {
            int sum = 0;
            if (maxValue > 0 && maxValue < 256)
                for (int i = minValue; i <= maxValue; i++)
                    if (i % 2 == 1)
                    {
                        sum += i;
                    }
            return sum;
        }


        public static int ReturnSum(int number)
        {
            int sum = 0;
            for(int i=0; i<= number; i++)
            {
                if(i%2==1)
                {
                    sum += i;
                }
            }
            return sum;
        }
        public static void Main(string[] args)
            
        {
            //Console.WriteLine("\n\tSum.Odds.Main()");
            //int testNumber = 5;
            //Console.WriteLine("\t" + CollectSumOdds(testNumber));
            //Console.WriteLine("\t" + CollectSumOdds(0, 9));
           // Console.WriteLine(ReturnSum(-16));
            //Console.WriteLine("\t" + CollectSumOdds(5, 25));
            //Console.WriteLine("\t" + CollectSumOdds(0, 50));
            Console.ReadKey();



        }
    }
}