using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sumodds
{
    class Program
    {
        static int sumMoreOdds(int num)
        {
            int sumOdds = 0;
            for (int i =1; i<= num; i++)
            {
                if (i%2 ==1)
                {
                    sumOdds += i;
                }
            }
            return sumOdds;

        }
        static void Main(string[] args)
        {
            Prime(9);
        }
        public static bool Prime (int num)
        {
            int i = 2;
            while (i < x)
            {
                if (x % i == 0)
                {
                    return false;
                }                    
                i++;
            }
            return true;
        }

        static int NumSwap(int a, int b)
        {
            int a = 5;
            int b = 11;
            a = a + b;
            b = a - b;
            a = a - b;
            }
      
    }
}
