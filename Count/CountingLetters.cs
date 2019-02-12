using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Count
{
    public class CountingLetters
    {
        public static int CountVowels(string word)
        {
            Console.WriteLine("enter a word or sentence, i'll count the values");
            string words = Console.ReadLine();
            string lowWords = words.ToLower();
            int numVow = 0;
            foreach (char letter in lowWords)
            {
                if (letter == 'a' || letter == 'e' || letter == 'i' || letter == 'o' || letter == 'u')
                
                    numVow++;               
            }
            Console.WriteLine(numVow);
            Console.ReadKey();
            return numVow;

        }
        static void Main(string[] args)
        {
            CountVowels("LETS coDE");
        }
    }
}
