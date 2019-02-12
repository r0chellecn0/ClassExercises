using Microsoft.VisualStudio.TestTools.UnitTesting;
using Count;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Count.Tests
{
    [TestClass()]
    public class ProgramTests
    {
        [TestMethod()]
        public void CountVowelsTest()
        {
            Assert.AreEqual(3, CountingLetters.CountVowels("what it is"));
            Assert.AreEqual(2, CountingLetters.CountVowels("eel"));
            Assert.AreEqual(, CountingLetters.CountVowels("MICRosoft"));
        }
    }
}