using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Raetreon
{
    interface IObserver
    {
        // értékék amiket megkapnak az observerek a Subjecttől, push-os megoldás
        void update(int korokszama, int okozott, int szenvedett, bool vegevane);
    }
}
