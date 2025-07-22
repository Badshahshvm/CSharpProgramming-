using System;

using System;

interface IVehicle
{
    string vehicleType();
    int numOfWheel();
}

class Bike : IVehicle
{
    string name;
    int numOfwheel;

    public Bike(string name, int numOfwheel)
    {
        this.name = name;
        this.numOfwheel = numOfwheel;
    }

    string IVehicle.vehicleType()
    {
        return name;
    }

    int IVehicle.numOfWheel()
    {
        return numOfwheel;
    }
}

class Car : IVehicle
{
    string name;
    int numOfwheel;

    public Car(string name, int numOfwheel)
    {
        this.name = name;
        this.numOfwheel = numOfwheel;
    }

    string IVehicle.vehicleType()
    {
        return name;
    }

    int IVehicle.numOfWheel()
    {
        return numOfwheel;
    }
}

// Execution
class Class1
{
    static void Main(string[] args)
    {
        IVehicle c1 = new Car("Maruti", 4);
        IVehicle b1 = new Bike("Hero", 2);

        Console.WriteLine($"Car: {c1.vehicleType()}, Wheels: {c1.numOfWheel()}");
        Console.WriteLine($"Bike: {b1.vehicleType()}, Wheels: {b1.numOfWheel()}");
    }
}

