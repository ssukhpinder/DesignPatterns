using IteratorPattern.Iterators;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IteratorPattern.Vehicles
{
    public class Motercycle : IVehicleAggregate
    {

        private string[] _motercycles;
        public Motercycle()
        {
            _motercycles = new[] { "Bike 1", "Bike 2", "Bike 3" };
        }
        public IVehicleIterator CreateIterator()
        {
            return new MotercycleIterator(_motercycles);
        }
    }
}
