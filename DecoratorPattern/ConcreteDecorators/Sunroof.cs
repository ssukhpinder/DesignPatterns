using DecoratorPattern.Component;
using DecoratorPattern.Decorator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern.ConcreteDecorators
{
    public class Sunroof : CarDecorator
    {
        public Sunroof(Car car) : base(car)
        {
        }

        public override int CarPrice() => _car.CarPrice() + 2000;
        public override string GetName() => "Alto Lxi with Sunroof";
    }
}
