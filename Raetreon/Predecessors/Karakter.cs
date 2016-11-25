using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Raetreon
{
     public class Karakter : IKarakter
    {
        public Karakter()
        {
            this.nev = nev;
            this.eletero = eletero;
            this.maxeletero = maxeletero;
        }
        
        private static Random rnd = new Random();
        protected string _nev;
        public string nev
        {
            get
            {
                return _nev;
            }
            set
            {
                _nev = value;
            }
        }

        protected int _eletero;
        public int eletero
        {
            get
            {
                return _eletero;
            }
            set
            {
                if (value >= 0 && value <= 10000)
                {
                    _eletero = value;
                }
                else if (value <= 0)
                {
                    _eletero = 0;
                }
                else throw new Exception("Hibás életerő!");
            }
        }

        private int _maxeletero;
        public int maxeletero
        {
            get
            {
                return _maxeletero;
            }
            set
            {
                if (value >= _eletero && value <= 10000)
                    _maxeletero = value;
            }
        }

        protected bool _harckeptelen;
        public bool harckeptelen
        {
            get
            {
                if (_eletero > 0)
                {
                    _harckeptelen = false;
                }
                else
                {
                    _harckeptelen = true;
                }
                return _harckeptelen;
            }
        }

        private string _kep;
        public string kep
        {
            get
            {
                return _kep;
            }
            set
            {
                _kep = value;
            }
        }

        private string _kaszt;
        public string kaszt
        {
            get
            {
                return _kaszt;
            }
            set
            {
                _kaszt = value;
            }
        }

        public void Tamad(Karakter ellenseg, Fegyver fegyver)
        {
            int sebzes = rnd.Next(0, fegyver.sebzes + 1);
            ellenseg.eletero -= sebzes;
        }

        public void Vedekez(Karakter karakterunk, Fegyver fegyver)
        {
            int sebzes = rnd.Next(0, fegyver.sebzes + 1);
            int szerencse = rnd.Next(0, 100);
            int pajzs;
            int ujsebzes;            
            if(szerencse>=0 && szerencse <= 25)
            {
                pajzs = 0;
                ujsebzes = sebzes - pajzs;
                karakterunk.eletero -= ujsebzes;
            }
            else if (szerencse>=25 && szerencse <= 50)
            {
                pajzs = sebzes/4;
                ujsebzes = sebzes - pajzs;
                karakterunk.eletero -= ujsebzes;
            }
            else if(szerencse>=50 && szerencse <= 75)
            {
                pajzs = sebzes / 2;
                ujsebzes = sebzes - pajzs;
                karakterunk.eletero -= ujsebzes;
            }
            else if(szerencse>=75 && szerencse < 100)
            {
                pajzs = sebzes;
                ujsebzes = sebzes - pajzs;
                karakterunk.eletero -= ujsebzes;
            }
        }
    }
}
