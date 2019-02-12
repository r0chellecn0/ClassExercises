using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Minimums
{
    public class Program
    {
        public static void CountVowels(string word)
        {
            Console.WriteLine("enter a word or sentence, i'll count the values");
            string words = Console.ReadLine();
            int numVow = 0;
            foreach (char letter in words)
            {
                if (letter=='a' || letter=='e' || letter == 'i' || letter =='o' || letter =='u' )
                {
                    numVow++;
                }
            }
            Console.WriteLine(numVow);
            Console.ReadKey();

        }
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
            CountVowels("what it is");
            int[] num = { 3, 1, 7, 8, 345 };
            Console.WriteLine(minVal(num));
        }
    }
}
