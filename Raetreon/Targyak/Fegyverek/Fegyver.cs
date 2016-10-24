using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Raetreon
{
    public class Fegyver : IFegyver
    {
        public Fegyver()
        {
            this.nev = nev;
            this.sebzes = sebzes;
        }
        public Fegyver(string nev, int sebzes) : this()
        {
            this.nev = nev;
            this.sebzes = sebzes;
        }

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

        protected int _sebzes;
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
