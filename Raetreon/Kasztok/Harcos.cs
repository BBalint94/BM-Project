using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Raetreon
{
    public class Harcos : Karakter, IHarcos
    {

        private static Random rnd = new Random();

        public Harcos()
            : base()
        {
            this.harcosfegyver = harcosfegyver;
        }
        public Harcos(string nev, int maxeletero, int eletero, string kaszt, string kep) : this()
        {
            this.nev = nev;
            this.maxeletero = maxeletero;
            this.eletero = eletero;
            this.kaszt = kaszt;
            this.kep = kep;

        }

        private KozelharciF _harcosfegyver;
        public KozelharciF harcosfegyver
        {
            get
            {
                return _harcosfegyver;
            }
            set
            {
                _harcosfegyver = value;
            }
        }
    }
}
