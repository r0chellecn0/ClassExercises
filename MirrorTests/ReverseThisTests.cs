using Microsoft.VisualStudio.TestTools.UnitTesting;
using Mirror;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mirror.Tests
{
    [TestClass()]
    public class ReverseThisTests
    {
        [TestMethod()]
        public void IsPalTest()
        {
            Assert.AreEqual("taco cat", ReverseThis.IsPal("taco cat"));
            Assert.Fail("ellehcor", ReverseThis.IsPal("rochelle"));
        }
    }
}