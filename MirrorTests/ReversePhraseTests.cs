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
    public class ReversePhraseTests
    {
        [TestMethod()]
        public void ReverseThisTest()
        {
            Assert.AreEqual("ellehcor", Mirror.ReverseThis.ReverseThisPhrase("rochelle"));
            Assert.AreEqual("yad doog a evah", Mirror.ReverseThis.ReverseThisPhrase("have a good day"));
        }
    }
}