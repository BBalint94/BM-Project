using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Raetreon
{
    public class FegyverRaktar
    {
        private static FegyverRaktar uniqueInstance = null;
        private FegyverRaktar() { }
        public static FegyverRaktar getInstance()
        {
            if (uniqueInstance == null)
                uniqueInstance = new FegyverRaktar();
            return uniqueInstance;
        }
        private List<KozelharciF> _khfegyverek = new List<KozelharciF>();
        public List<KozelharciF> khfegyverek
        {
            get { return _khfegyverek; }
        }
        private List<TavolsagiF> _tavfegyverek = new List<TavolsagiF>();

        public List<TavolsagiF> tavfegyverek
        {
            get { return _tavfegyverek; }
        }
        private List<MagikusF> _magfegyverek = new List<MagikusF>();
        public List<MagikusF> magfegyverek
        {
            get { return _magfegyverek; }
        }
        public void KhFegyverHozzaad(KozelharciF fegyver)
        {
            if (!_khfegyverek.Contains(fegyver))
                khfegyverek.Add(fegyver);
        }
        public void TavFegyverHozzaad(TavolsagiF fegyver)
        {
            if (!_tavfegyverek.Contains(fegyver))
                tavfegyverek.Add(fegyver);
        }
        public void MagFegyverHozzaad(MagikusF fegyver)
        {
            if (!_magfegyverek.Contains(fegyver))
                magfegyverek.Add(fegyver);
        }
    }
}
