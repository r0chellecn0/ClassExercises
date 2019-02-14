using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindAge
{
    class Program
    {
       
        public static int DoubleAge(int dad, int son)
        {
            int sonAge = 0;
            int dadAge = dad - son;

            while (dad != 2 * son)
            {
                sonAge++;
                dadAge++;
            }
            Console.WriteLine(dadAge-dad);
            return dadAge-dad;
        }
        static void Main(string[] args)
        {
            NoSpace("i love ramen");
           // DoubleAge(23, 63);
        }
    }
}
