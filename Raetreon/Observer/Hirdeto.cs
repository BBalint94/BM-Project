using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Raetreon
{
    class Hirdeto : IObserver
    {
        private string _nev;
        public string nev
        {
            get { return _nev; }
        }
        public Hirdeto(string nev)
        {
            _nev = nev;
            Esemenykozlo.esemenykozlok[0].registerObserver(this);
        }

        public void update(int korok, int okozott, int szenvedett, bool vegevane)
        {
            if (true)
            {
                Harcter hter = Harcter.getInstance();
                if (vegevane == false)
                {
                    hter.esemenyek.Text += _nev + " (" + korok + ".kör) " + ": Okozott sebzés: " + okozott + "\n";
                    hter.esemenyek.Text += _nev + " (" + korok + ".kör) " + ": Szenvedett sebzés: " + szenvedett + "\n";
                }
                else
                {
                    hter.esemenyek.Text += _nev + " : A játéknak vége! Kattints a kilépésre!";
                }

            }
        }
    }
}
