using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RemoveSpaces
{
    class RemoveSpaces
    {
        public static string NoSpace(string sentence)
        {
            string noSpaceSentence = "";

            foreach (char word in sentence)
            {
                if (word != ' ')
                {
                    noSpaceSentence += word;
                }
            }
            Console.WriteLine(noSpaceSentence);
            return noSpaceSentence;
        }
        static void Main(string[] args)
        {
            NoSpace("i Love Ramen");
        }
    }
}