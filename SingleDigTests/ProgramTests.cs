using Microsoft.VisualStudio.TestTools.UnitTesting;
using SingleDig;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingleDig.Tests
{
	[TestClass()]
	public class ProgramTests
	{
		[TestMethod()]
		public void DoWorkTest()
		{
			Assert.AreEqual(5, Program.DoWork(4532));
			Assert.AreEqual(0, Program.DoWork(-4532));
		}
	}
}