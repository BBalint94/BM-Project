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
    public class HarcosTests
    {
        [TestMethod()]
        public void HarcosPropertykSet()
        {
            KozelharciF fegyver = new KozelharciF();
            Harcos h = new Harcos();
            h.nev = "Harcos Teszt";
            h.maxeletero = 1500;
            h.eletero = 1500;
            h.kaszt = "Harcos";
            h.harcosfegyver = fegyver;
            h.kep = "Images/Karakterek/harcos1.png";
            Assert.AreEqual(1500, h.maxeletero);
            Assert.AreEqual(1500, h.eletero);
            Assert.AreEqual("Harcos Teszt", h.nev);
            Assert.AreEqual("Harcos", h.kaszt);
            Assert.AreEqual(fegyver, h.harcosfegyver);
            Assert.AreEqual("Images/Karakterek/harcos1.png", h.kep);
        }

        [TestMethod()]
        public void HarcosKonstruktor()
        {
            Harcos h = new Harcos("Harci Marci", 1000, 1000, "Harcos", "Images/Karakterek/harcos1.png");
            Assert.AreEqual("Harci Marci", h.nev);
            Assert.AreEqual(1000, h.maxeletero);
            Assert.AreEqual(1000, h.eletero);
            Assert.AreEqual("Harcos", h.kaszt);
            Assert.AreEqual("Images/Karakterek/harcos1.png", h.kep);
        }
    }
}