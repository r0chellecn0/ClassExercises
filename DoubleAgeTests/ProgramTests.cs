using Microsoft.VisualStudio.TestTools.UnitTesting;
using DoubleAge;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoubleAge.Tests
{
	[TestClass()]
	public class ProgramTests
	{
		[TestMethod()]
		public void doubleAgeTest()
		{
			Assert.AreEqual(5, Program.doubleAge(39,17));
			Assert.AreEqual(-5, Program.doubleAge(49, 17));
		}
	}
}