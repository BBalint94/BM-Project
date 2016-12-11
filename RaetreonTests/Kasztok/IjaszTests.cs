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
    public class IjaszTests
    {
        [TestMethod()]
        public void IjaszPropertykSet()
        {
            TavolsagiF fegyver = new TavolsagiF();
            Ijasz i = new Ijasz();
            i.nev = "Íjász Teszt";
            i.maxeletero = 1500;
            i.eletero = 1500;
            i.kaszt = "Íjász";
            i.ijaszfegyver = fegyver;
            i.kep = "Images/Karakterek/ijasz0.png";
            Assert.AreEqual(1500, i.maxeletero);
            Assert.AreEqual(1500, i.eletero);
            Assert.AreEqual("Íjász Teszt", i.nev);
            Assert.AreEqual("Íjász", i.kaszt);
            Assert.AreEqual(fegyver, i.ijaszfegyver);
            Assert.AreEqual("Images/Karakterek/ijasz0.png", i.kep);
        }

        [TestMethod()]
        public void IjaszKonstruktor()
        {
            Ijasz i = new Ijasz("Robin Hood", 1000, 1000, "Íjász", "Images/Karakterek/ijasz0.png");
            Assert.AreEqual("Robin Hood", i.nev);
            Assert.AreEqual(1000, i.maxeletero);
            Assert.AreEqual(1000, i.eletero);
            Assert.AreEqual("Íjász", i.kaszt);
            Assert.AreEqual("Images/Karakterek/ijasz0.png", i.kep);
        }
    }
}