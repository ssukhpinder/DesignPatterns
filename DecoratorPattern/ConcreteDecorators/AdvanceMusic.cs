using DecoratorPattern.Component;
using DecoratorPattern.Decorator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern.ConcreteDecorators
{
    public class AdvanceMusic : CarDecorator
    {
        public AdvanceMusic(Car car) : base(car)
        {
        }

        public override int CarPrice() => _car.CarPrice() + 3000;
        public override string GetName()=> "Alto Lxi with advance music system";
    }
}
