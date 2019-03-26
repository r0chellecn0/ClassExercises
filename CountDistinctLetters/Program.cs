using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CountDistinctLetters
{
	class Program
	{
		public static void GetLetters (string input)
		{
			string movieTitle = input.ToUpper();

				for(char c = 'A'; c <= 'Z'; c++)
				{
					int count = 0;
					if (movieTitle.Contains(c.ToString()))
					{
						foreach(char ch in movieTitle)
						{
							if (ch == c) count++;
						}
						Console.WriteLine($"letter {c} - {count}");
					}
							
			}
		}
		static void Main(string[] args)
		{
			GetLetters("star wars");
			Console.ReadKey();
		}
	}
}
