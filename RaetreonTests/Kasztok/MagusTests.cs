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
    public class MagusTests
    {
        [TestMethod()]
        public void MagusPropertykSet()
        {
            MagikusF fegyver = new MagikusF();
            Magus m = new Magus();
            m.nev = "Mágus Teszt";
            m.maxeletero = 1500;
            m.eletero = 1500;
            m.kaszt = "Mágus";
            m.magusfegyver = fegyver;
            m.kep = "Images/Karakterek/magus0.png";
            Assert.AreEqual(1500, m.maxeletero);
            Assert.AreEqual(1500, m.eletero);
            Assert.AreEqual("Mágus Teszt", m.nev);
            Assert.AreEqual("Mágus", m.kaszt);
            Assert.AreEqual(fegyver, m.magusfegyver);
            Assert.AreEqual("Images/Karakterek/magus0.png", m.kep);
        }

        [TestMethod()]
        public void MagusKonstruktor()
        {
            Magus m = new Magus("Harry Potter", 1000, 1000, "Mágus", "Images/Karakterek/magus0.png");
            Assert.AreEqual("Harry Potter", m.nev);
            Assert.AreEqual(1000, m.maxeletero);
            Assert.AreEqual(1000, m.eletero);
            Assert.AreEqual("Mágus", m.kaszt);
            Assert.AreEqual("Images/Karakterek/magus0.png", m.kep);
        }
    }
}