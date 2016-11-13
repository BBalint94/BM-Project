using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Raetreon
{
    interface ISubject
    {
        // observer regisztrálásra
        void registerObserver(IObserver o);
        // observer törlésre
        void removeObserver(IObserver o);
        // meghívódik, hogy értesítse az megfigyelőket
        // amikor a Subject állapota megváltozik
        void notifyObservers();
    }
}
