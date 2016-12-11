using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Raetreon
{
    public class TesztOsztaly
    {
        public TesztOsztaly(string teszt0, int teszt1, string teszt2) : this()
        {

        }
        public TesztOsztaly()
        {
            this.teszt0 = teszt0;
            this.teszt1 = teszt1;
            this.teszt2 = teszt2;
        }
        private string _teszt0;
        public string teszt0
        {
            get { return _teszt0; }
            set { _teszt0 = value; }
        }
        private int _teszt1;

        public int teszt1
        {
            get { return _teszt1; }
            set { _teszt1 = value; }
        }
        private string _teszt2;

        public string teszt2
        {
            get { return _teszt2; }
            set { _teszt2 = value; }
        }
    }
}
