using Microsoft.VisualStudio.TestTools.UnitTesting;
using Minimums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Minimums.Tests
{
    [TestClass()]
    public class ProgramTests
    {
        [TestMethod()]
        public void minValTest()
        {
            int[] a = { 324, 123, 2 };
            Assert.AreEqual(2, Program.minVal(a));
          
        }
    }
}