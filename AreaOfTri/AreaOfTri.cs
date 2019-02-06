using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AreaOfTri
{
    class AreaOfTri
    {
        static void testAOT()
        {
            int howMany = 5;
            for (int i = 0; i < howMany; i++)
            {
                for (int j = 0; j < howMany; j++)
                {
                    Console.Write("\n\t");
                    Console.Write($"base: {i}, height: {j}, area:{AreaOfTriangle(i, j)}");
                    
                }
            }
            return;
        }
        static double AreaOfTriangle(double b, double ht)
        {
            return (b * ht / 2);
        }
        static void Main(string[] args)
        {
            // Console.WriteLine("\n\tAreaOfTri.Main()");
            //testAOT();
            //Console.ReadKey();
            Console.WriteLine($"{SumOfOdds(5)}");

            // Console.WriteLine($"the area of this triangle is {AreaOfTriangle}");
        }

        static int SumOfOdds (int numbers)
        {
            int i = 5;
            for (i=5; i<256; i++)
            {
              i += 2;
            }
            return i;
           
        }
    }
}
