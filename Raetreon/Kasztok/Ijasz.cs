using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Raetreon
{
    public class Ijasz : Karakter, IIjasz
    {
        private static Random rnd = new Random();

        public Ijasz()
            : base()
        {
            this.ijaszfegyver = ijaszfegyver;
        }
        public Ijasz(string nev, int maxeletero, int eletero, string kaszt, string kep) : this()
        {
            this.nev = nev;
            this.maxeletero = maxeletero;
            this.eletero = eletero;
            this.kaszt = kaszt;
            this.kep = kep;
        }
        private TavolsagiF _ijaszfegyver;
        public TavolsagiF ijaszfegyver
        {
            get
            {
                return _ijaszfegyver;
            }
            set
            {
                _ijaszfegyver = value;
            }
        }
    }
}
