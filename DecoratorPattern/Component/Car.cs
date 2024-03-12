using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern.Component
{
    public abstract class Car
    {
        public abstract int CarPrice();
        public abstract string GetName();
    }
}
