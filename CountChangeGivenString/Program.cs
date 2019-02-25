using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CountChangeGivenString
{
	public class Program
	{
		public static decimal CountChange(string coins)
		{
			decimal dollarAmt = 0.00M;
			string allCoins = coins.ToUpper();

			foreach(char coin in allCoins)
			{
				if(coin == 'Q')
				{
					dollarAmt += 0.25M;
				}
				else if (coin == 'D')
				{
					 dollarAmt += 0.10M;
				}
				else if (coin == 'N')
				{
					dollarAmt += 0.05M;
				}
				else
				{
					 dollarAmt += 0.01M;
				}
				
			}
			Console.WriteLine(dollarAmt);
			return dollarAmt;
		}
		static void Main(string[] args)
		{
			CountChange("QDNPQQDDQQDN");
		}
	}
}
