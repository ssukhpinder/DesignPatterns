using IteratorPattern.Iterators;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IteratorPattern.Vehicles
{
    public class Car : IVehicleAggregate
    {
        private List<string> _cars;
        public Car()
        {
            _cars = new List<string> { "Car 1", "Car 2", "Car 3" };
        }

        public IVehicleIterator CreateIterator()
        {
            return new CarIterator(_cars);
        }
    }
}
