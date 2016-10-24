using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Raetreon
{
    public class MagikusF : Fegyver
    {
        private Settings.FegyverTipus _tipus = Settings.FegyverTipus.Magikus;
        public Settings.FegyverTipus tipus
        {
            get { return _tipus; }
        }
    }
}
