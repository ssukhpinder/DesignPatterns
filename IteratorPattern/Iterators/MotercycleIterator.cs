using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IteratorPattern.Iterators
{
    public class MotercycleIterator : IVehicleIterator
    {
        private string[] _motercylces;
        private int _current;
        public MotercycleIterator(string[] motercylces)
        {
            _motercylces = motercylces;
            _current = 0;
        }
        public string Current()
        {
            return _motercylces[_current];
        }

        public void First()
        {
            _current = 0;
        }

        public bool IsDone()
        {
            return _current >= _motercylces.Length;
        }

        public string Next()
        {
            return _motercylces[_current++];
        }
    }
}
