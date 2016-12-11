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
    public class KarakterRaktarTests
    {
        [TestMethod()]
        public void getInstanceTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void JatHarcosHozzaadTest()
        {
            List<Harcos> harcosok = new List<Harcos>();
            Harcos h1 = new Harcos("Harcoska", 1200, 1200, "Harcos", "Images/Karakterek/harcos1.png");
            harcosok.Add(h1);
            Harcos h2 = new Harcos("Marcona", 1300, 1300, "Harcos", "Images/Karakterek/harcos1.png");
            harcosok.Add(h2);
            Harcos h3 = new Harcos("Katona", 1400, 1400, "Harcos", "Images/Karakterek/harcos1.png");
            harcosok.Add(h3);
            Harcos h4 = new Harcos("Barbár", 1500, 1500, "Harcos", "Images/Karakterek/harcos1.png");
            harcosok.Add(h4);
            Harcos h5 = new Harcos("Lovag", 1600, 1600, "Harcos", "Images/Karakterek/harcos1.png");
            harcosok.Add(h5);
            Assert.IsTrue(harcosok.Count == 5 && harcosok[1].nev == "Marcona");
        }

        [TestMethod()]
        public void JatMagusHozzaadTest()
        {
            List<Magus> magusok = new List<Magus>();
            Magus m1 = new Magus("Mág Ica", 1200, 1200, "Mágus", "Images/Karakterek/magus0.png");
            magusok.Add(m1);
            Magus m2 = new Magus("Varázsló", 1300, 1300, "Mágus", "Images/Karakterek/magus0.png");
            magusok.Add(m2);
            Magus m3 = new Magus("Abraka", 1400, 1400, "Mágus", "Images/Karakterek/magus0.png");
            magusok.Add(m3);
            Magus m4 = new Magus("Dabra", 1500, 1500, "Mágus", "Images/Karakterek/magus0.png");
            magusok.Add(m4);
            Magus m5 = new Magus("Seprű", 1600, 1600, "Mágus", "Images/Karakterek/magus0.png");
            magusok.Add(m5);
            Assert.IsTrue(magusok.Count == 5 && magusok[1].nev == "Varázsló");
        }

        [TestMethod()]
        public void JatIjaszHozzaadTest()
        {
            List<Ijasz> ijaszok = new List<Ijasz>();
            Ijasz i1 = new Ijasz("Robin", 1200, 1200, "Íjász", "Images/Karakterek/ijasz0.png");
            ijaszok.Add(i1);
            Ijasz i2 = new Ijasz("Hood", 1300, 1300, "Íjász", "Images/Karakterek/ijasz0.png");
            ijaszok.Add(i2);
            Ijasz i3 = new Ijasz("Nyíl", 1400, 1400, "Íjász", "Images/Karakterek/ijasz0.png");
            ijaszok.Add(i3);
            Ijasz i4 = new Ijasz("Vessző", 1500, 1500, "Íjász", "Images/Karakterek/ijasz0.png");
            ijaszok.Add(i4);
            Ijasz i5 = new Ijasz("Tegez", 1600, 1600, "Íjász", "Images/Karakterek/ijasz0.png");
            ijaszok.Add(i5);
            Assert.IsTrue(ijaszok.Count == 5 && ijaszok[1].nev == "Hood");
        }
    }
}