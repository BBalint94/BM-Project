using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Raetreon
{
    interface IKarakter
    {
        string nev { get; set; }
        int eletero { get; set; }
        int maxeletero { get; set; }
        bool harckeptelen { get; }
        string kep { get; set; }
        string kaszt { get; set; }
    }
}
