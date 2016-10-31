using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Raetreon
{
    class Ellenseg : Karakter, IEllenseg
    {
        public Ellenseg() : base()
        {
            this.sebzes = sebzes;
        }

        public Ellenseg(string nev, int maxeletero, int eletero, int sebzes, string kaszt, string kep) : this()
        {
            this.nev = nev;
            this.maxeletero = maxeletero;
            this.eletero = eletero;
            this.sebzes = sebzes;
            this.kaszt = kaszt;
            this.kep = kep;
        }

        private int _sebzes;
        public int sebzes
        {
            get
            {
                return _sebzes;
            }

            set
            {
                if (value >= 0 && value <= 3000)
                    _sebzes = value;
                else throw new Exception("Hibás sebzés érték!");
            }
        }
    }
}
