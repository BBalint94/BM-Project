using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Raetreon
{
    public class EllensegRaktar
    {
        private static EllensegRaktar uniqueInstance = null;
        private EllensegRaktar() { }
        public static EllensegRaktar getInstance()
        {
            if (uniqueInstance == null)
                uniqueInstance = new EllensegRaktar();
            return uniqueInstance;
        }
        private List<Ellenseg> _jatellenseg = new List<Ellenseg>();
        public List<Ellenseg> jatellenseg
        {
            get { return _jatellenseg; }
        }
        public void JatEllensegHozzaad(Ellenseg jellenseg)
        {
            jatellenseg.Add(jellenseg);
        }
    }
}
