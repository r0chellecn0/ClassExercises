using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Minimums
{
    public class Program
    {
        public static int minVal(int[] a)
        {
   
            int smallest = a[0];

            foreach (int i in a)
            {
                if (i < smallest)
                {
                   smallest = i;
                }
                
            }
            return smallest;
        }
        static void Main(string[] args)
        {
            int[] num = { 3, 1, 7, 8, 345 };
            Console.WriteLine(minVal(num));
        }
    }
}
