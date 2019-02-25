using Microsoft.VisualStudio.TestTools.UnitTesting;
using CountChangeGivenString;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CountChangeGivenString.Tests
{
	[TestClass()]
	public class ProgramTests
	{
		[TestMethod()]
		public void CountChangeTest()
		{
			Assert.AreEqual(1.76M, Program.CountChange("QDNPQQDDQQDN"));
			Assert.AreEqual(1.00M, Program.CountChange("Qqddddnn"));
		}
	}
}