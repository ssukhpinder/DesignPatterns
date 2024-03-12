using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IteratorPattern.Iterators
{
    public class CarIterator : IVehicleIterator
    {
        private List<string> _cars;
        private int _current;
        public CarIterator(List<string> cars)
        {
            _cars = cars;
            _current = 0;
        }
        public string Current()
        {
            return _cars.ElementAt(_current);
        }

        public void First()
        {
            _current = 0;
        }

        public bool IsDone()
        {
            return _current >= _cars.Count;
        }

        public string Next()
        {
            return _cars.ElementAt(_current++);
        }
    }
}
