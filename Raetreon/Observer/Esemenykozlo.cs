using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Raetreon
{
    class Esemenykozlo : ISubject
    {
        public static List<Esemenykozlo> esemenykozlok = new List<Esemenykozlo>();
        private List<int> _korok = new List<int>();
        private List<int> _okozott = new List<int>();
        private List<int> _szenvedett = new List<int>();
        private List<bool> _vegevanelista = new List<bool>();
        private List<IObserver> observers = new List<IObserver>();

        public Esemenykozlo()
        {
            esemenykozlok.Add(this);
        }

        public void notifyObservers()
        {
            foreach (IObserver o in observers)
            {
                o.update(_korok.Last(), _okozott.Last(), _szenvedett.Last(), _vegevanelista.Last());
            }
        }

        public void registerObserver(IObserver o)
        {
            if (observers.IndexOf(o) >= 0)
                throw new Exception("Már jelentkezett");
            observers.Add(o);
        }

        public void removeObserver(IObserver o)
        {
            if (observers.IndexOf(o) >= 0)
                throw new Exception("Nincs is jelentkezve");
            observers.Remove(o);
        }

        public void ujEsemeny(int korokszama, int okozott, int szenvedett, bool vegevane)
        {
            _okozott.Add(okozott);
            _szenvedett.Add(szenvedett);
            _korok.Add(korokszama);
            _vegevanelista.Add(vegevane);
            notifyObservers();
        }
    }
}
