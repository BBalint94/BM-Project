using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Raetreon
{
    public class KarakterRaktar
    {
        private static KarakterRaktar uniqueInstance = null;
        private KarakterRaktar() { }
        public static KarakterRaktar getInstance()
        {
            if (uniqueInstance == null)
                uniqueInstance = new KarakterRaktar();
            return uniqueInstance;
        }
        private List<Harcos> _jatharcosok = new List<Harcos>();
        public List<Harcos> jatharcosok
        {
            get { return _jatharcosok; }
        }
        private List<Magus> _jatmagusok = new List<Magus>();
        public List<Magus> jatmagusok
        {
            get { return _jatmagusok; }
        }
        private List<Ijasz> _jatijaszok = new List<Ijasz>();
        public List<Ijasz> jatijaszok
        {
            get { return _jatijaszok; }
        }
        private int _kivantkaszt;
        public int kivantkaszt
        {
            get { return _kivantkaszt; }
            set { _kivantkaszt = value; }
        }
        public void JatHarcosHozzaad(Harcos jharcos)
        {
            jatharcosok.Add(jharcos);
        }
        public void JatMagusHozzaad(Magus jmagus)
        {
            jatmagusok.Add(jmagus);
        }
        public void JatIjaszHozzaad(Ijasz jijasz)
        {
            jatijaszok.Add(jijasz);
        }
    }
}
