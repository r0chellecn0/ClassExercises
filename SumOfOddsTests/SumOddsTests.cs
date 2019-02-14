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
            Assert.AreEqual(25, SumOdds.CollectSumOdds(0, 9));
        }

        [TestMethod()]
        public void ReturnSumTest()
        {
            Assert.AreEqual(0, SumOdds.ReturnSum(-3));
            Assert.AreEqual(4, SumOdds.ReturnSum(4));
            Assert.AreEqual(0, SumOdds.ReturnSum(0));
        }
    }
}