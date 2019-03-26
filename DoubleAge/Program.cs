using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoubleAge
{
	public class Program
	{
		public static int doubleAge(int dad, int son)
		{
			int sonAge = 0;
			int dadAge = dad-son;
			while(dadAge != 2 * sonAge)
			{
				dadAge++;
				sonAge++;
			}
			return sonAge-son;


		}
		static void Main(string[] args)
		{
			Console.WriteLine(doubleAge(49,27));
			Console.ReadKey();
		}
	}
}
