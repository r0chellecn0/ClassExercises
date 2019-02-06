using Microsoft.VisualStudio.TestTools.UnitTesting;
using Julian;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Julian.Tests
{
    [TestClass()]
    public class ProgramTests
    {
        [TestMethod()]
        public void CaseJulianTest()
        {
            Assert.AreEqual(32, Program.CaseJulian(2, 1));

        }
    }
}