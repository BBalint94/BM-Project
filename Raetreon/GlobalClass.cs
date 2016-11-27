using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Raetreon
{
    public class GlobalClass
    {
        private static GlobalClass uniqueInstance = null;
        private GlobalClass() { }
        public static GlobalClass getInstance()
        {
            if (uniqueInstance == null)
                uniqueInstance = new GlobalClass();
            return uniqueInstance;
        }

        private Harcos _korabbiharcos = new Harcos();
        public Harcos korabbiharcos
        {
            get { return _korabbiharcos; }
            set
            {
                _korabbiharcos = value;
            }
        }

        private Magus _korabbimagus = new Magus();
        public Magus korabbimagus
        {
            get { return _korabbimagus; }
            set
            {
                _korabbimagus = value;
            }
        }

        private Ijasz _korabbiijasz = new Ijasz();
        public Ijasz korabbiijasz
        {
            get { return _korabbiijasz; }
            set { _korabbiijasz = value; }
        }
    }
}
