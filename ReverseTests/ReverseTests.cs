using Microsoft.VisualStudio.TestTools.UnitTesting;
using Reverse;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reverse.Tests
{
    [TestClass()]
    public class ReverseTests
    {
        [TestMethod()]
        public void ReverseThisTest()
        {
            Assert.AreEqual("tac", Reverse.ReverseThis("cat"));
            Assert.AreEqual("dlrow olleh", Reverse.ReverseThis("hello world"));
            Assert.AreEqual("ne7ves", Reverse.ReverseThis("sev7en"));
        }
    }
}