// See https://aka.ms/new-console-template for more information
using IteratorPattern;
using IteratorPattern.Vehicles;

IVehicleAggregate car = new Car();
IVehicleAggregate motercycle = new Motercycle();

IVehicleIterator carIterator = car.CreateIterator();
IVehicleIterator motercycleIterator = motercycle.CreateIterator();

PrintVehicles(carIterator);
PrintVehicles(motercycleIterator);


static void PrintVehicles(IVehicleIterator iterator)
{
    iterator.First();
    while (!iterator.IsDone())
    {
        Console.WriteLine(iterator.Next());
    }
}