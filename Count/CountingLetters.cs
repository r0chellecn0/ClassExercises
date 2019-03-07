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

		public static string AlphabeticalOrder(string word)
		{
			string newWord = word.ToLower();
			char[] input = newWord.ToArray();
			string ordWord = "";

			for (int i = 0; i < input.Length - 1; i++)
			{
				for (int j = 0; j < input.Length - 1; j++)
				{
					if (input[j] > input[j + 1])
					{
						char tempVal = input[j];
						input[j] = input[j + 1];
						input[j + 1] = tempVal;
					}
				}
			}

			foreach(var letter in input)
			{
				ordWord += letter;
			}
			Console.WriteLine(ordWord);
			return ordWord;
		}
        static void Main(string[] args)
        {
            //CountVowels("LETS coDE");
			AlphabeticalOrder("rochelle");
        }
    }
}
