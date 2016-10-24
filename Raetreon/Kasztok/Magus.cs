using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Raetreon
{
    public class Magus : Karakter, IMagus
    {
        private static Random rnd = new Random();
        public Magus()
            : base()
        {
            this.magusfegyver = magusfegyver;
        }
        public Magus(string nev, int maxeletero, int eletero, string kaszt, string kep) : this()
        {
            this.nev = nev;
            this.maxeletero = maxeletero;
            this.eletero = eletero;
            this.kaszt = kaszt;
            this.kep = kep;
        }
        private MagikusF _magusfegyver;
        public MagikusF magusfegyver
        {
            get
            {
                return _magusfegyver;
            }
            set
            {
                _magusfegyver = value;
            }
        }
    }
}
