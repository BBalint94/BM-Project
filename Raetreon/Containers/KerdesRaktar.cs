using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Raetreon
{
    class KerdesRaktar
    {
        private static KerdesRaktar uniqueInstance = null;
        private KerdesRaktar() { }
        public static KerdesRaktar getInstance()
        {
            if (uniqueInstance == null)
                uniqueInstance = new KerdesRaktar();
            return uniqueInstance;
        }

        private List<string> _kerdesek;
        public List<string> kerdesek
        {
            get { return _kerdesek; }
            set { _kerdesek = value; }
        }

        private List<string> _valaszok;
        public List<string> valaszok
        {
            get { return _valaszok; }
            set { _valaszok = value; }
        }
    }
}
