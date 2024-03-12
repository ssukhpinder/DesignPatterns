// See https://aka.ms/new-console-template for more information
var sedan = new ModelSedan();
var suv = new ModelSuv();

var factory = new CarFactory();
var builders = new List<CarBuilder> { suv, sedan };

foreach (var b in builders)
{
    var c = factory.Build(b);
    Console.WriteLine($"The Car details" +
        $"\n--------------------------------------" +
        $"\nName: {c.Name}" +
        $"\nIs SUV: {c.IsSUV}" +
        $"\nTop Speed: {c.TopSpeed} mph\n");
}
public class Car
{
    public string Name { get; set; }
    public double TopSpeed { get; set; }
    public bool IsSUV { get; set; }
}

public abstract class CarBuilder
{
    protected readonly Car _car = new Car();
    public abstract void SetName();
    public abstract void SetSpeed();
    public abstract void SetIsSUV();
    public virtual Car GetCar() => _car;
}

public class CarFactory
{
    public Car Build(CarBuilder builder)
    {
        builder.SetName();
        builder.SetSpeed();
        builder.SetIsSUV();
        return builder.GetCar();
    }
}

public class ModelSuv : CarBuilder
{
    public override void SetIsSUV()
    {
        _car.IsSUV = true;
    }

    public override void SetName()
    {
        _car.Name = "Maruti SUV";
    }

    public override void SetSpeed()
    {
        _car.TopSpeed = 1000;
    }
}

public class ModelSedan : CarBuilder
{
    public override void SetIsSUV()
    {
        _car.IsSUV = false;
    }

    public override void SetName()
    {
        _car.Name = "Maruti Sedan";
    }

    public override void SetSpeed()
    {
        _car.TopSpeed = 2000;
    }
}