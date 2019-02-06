using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculateAverages
{
    class Averages
    {
        static double TestAverages(double a, double b, double c)
        {
            int i = 3;
            double sum;

            sum = a + b + c;
            return sum / i;

        }
        static void Main(string[] args)
        {
            double Avg;
            Console.WriteLine("\n\tAverages.Main()");

            Avg = TestAverages(90.0, 95.0, 85.0);
            Console.WriteLine($"\n\tthe average is {Avg}");

            Console.ReadKey();

       
        }
    }
}
