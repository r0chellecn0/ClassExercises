using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingleDig
{
	//add all numbers that makes up a number and keep adding them until you have a single digit
	public class Program
	{
		public static int DoWork(int number)
		{
			int single = 0;

			if (number > 0)
			{
				while (number % 10 != 0 && number > 0)
				{
					single += number % 10;
					number /= 10;
				}
			}
			return single > 9 ? DoWork(single) : single;

		}
		static void Main(string[] args)
		{
			Console.WriteLine(DoWork(4532)	); 

		}
	}
}

