using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pallindrome
{
    class Pal
    {
        public static bool isPal(string word)
        {
            int i = 0;
            int j = word.Length-1;

            for (i=0; i<word.Length-1; i++)
            {
                while (word[i] == word[j])
                {
                    i++;
                    j--;
                }
                Console.WriteLine("true");
                return true;

            }
            return false;
        }
        static void Main(string[] args)
        {
            isPal("racecar");
            isPal("rochelle");
        }
    }
}
