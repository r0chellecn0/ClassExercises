using Microsoft.VisualStudio.TestTools.UnitTesting;
using whiteboaard;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace whiteboaard.Tests
{
    [TestClass()]
    public class SumOddsTests
    {
        [TestMethod()]
        public void CollectSumOddsTest()
        {
            Assert.AreEqual(25, SumOdds.CollectSumOdds(0,9));
        }
    }
}