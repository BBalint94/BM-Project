using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Raetreon
{
    interface IMagus : IKarakter
    {
        MagikusF magusfegyver { get; set; }
    }
}
