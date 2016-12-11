using Microsoft.VisualStudio.TestTools.UnitTesting;
using Raetreon;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Raetreon.Tests
{
    [TestClass()]
    public class FegyverTests
    {
        [TestMethod()]
        public void FegyverPropertykSetTest()
        {
            Fegyver f = new Fegyver();
            f.nev = "Kalapács";
            f.sebzes = 100;
            Assert.AreEqual("Kalapács", f.nev);
            Assert.AreEqual(100, f.sebzes);
        }

        [TestMethod()]
        public void FegyverKonstruktorTest()
        {
            Fegyver f = new Fegyver("Balta", 150);
            Assert.AreEqual("Balta", f.nev);
            Assert.AreEqual(150, f.sebzes);
        }
    }
}