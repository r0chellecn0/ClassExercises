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
        [TestMethod()]
        public void JulianDayTest_Jan15()
        {
            Assert.AreEqual(15, Program.JulianDay(1, 15));
        }
        [TestMethod()]
        public void JulianDayTest_Feb2()
        {
            Assert.AreEqual(33, Program.JulianDay(2, 2));
        }
        [TestMethod()]
        public void JulianDayTest_Mar15()
        {
            Assert.AreEqual(74, Program.JulianDay(3, 15));
        }
        [TestMethod()]
        public void JulianDayTest_Dec31()
        {
            Assert.AreEqual(365, Program.JulianDay(12, 31));
        }
    }
}