using Microsoft.VisualStudio.TestTools.UnitTesting;
using Count;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Count.Tests
{
	[TestClass()]
	public class CountingLettersTests
	{
		[TestMethod()]
		public void AlphabeticalOrderTest()
		{
			Assert.AreEqual("aeforstw", CountingLetters.AlphabeticalOrder("software"));
			Assert.AreEqual("bddeelmoru", CountingLetters.AlphabeticalOrder("DUMBLEdore"));
		}
	}
}