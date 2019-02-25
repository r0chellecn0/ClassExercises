using Microsoft.VisualStudio.TestTools.UnitTesting;
using Prime;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prime.Tests
{
    [TestClass()]
    public class ProgramTests
    {
        [TestMethod()]
        public void isPrimeTest()
        {
            Assert.AreEqual(true, Program.IsPrime(5));
            Assert.AreEqual(false, Program.IsPrime(15));
            Assert.AreEqual(false, Program.IsPrime(14));
            Assert.AreEqual(false, Program.IsPrime(-70));
        }

        [TestMethod()]
        public void SumOfPrimesTest()
        {
            Assert.AreEqual(10, Program.SumOfPrimes(7));
            Assert.AreEqual(2, Program.SumOfPrimes(3));
        }

        [TestMethod()]
        public void CountPrimesTest()
        {
            Assert.AreEqual(3, Program.CountPrimes(7));
            Assert.AreEqual(4, Program.CountPrimes(9));
        }
    }
}