using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mirror
{
    public class ReverseThis
    {
        public static string ReverseThisPhrase(string phrase)
        {
            string revPhrase = "";
            for (int i=phrase.Length-1; i>= 0; i--)
            {
                revPhrase += phrase[i];
            }
            return revPhrase;
        }

        public static bool IsPal(string phrase)
        {
            int i = 0;
            int j = phrase.Length - 1;
            while (i<j)
            {
                if (phrase[i] != phrase[j])
                    return false;
                i++;
                j--;
            }
            return true;

        }
        
        static void Main(string[] args)
        {
            Console.WriteLine("Mirror is running");
            Console.WriteLine(ReverseThisPhrase("spice up your life"));
            Console.WriteLine(IsPal("racecar"));
            Console.WriteLine(IsPal("rochelle"));
        }
    }
}
