using System;
class Vehicle
{
    public virtual void Start()
    {
        Console.WriteLine("Vehicle is starting");
    }
}
class Car : Vehicle
{
    public sealed override void Start()
    {
        Console.WriteLine("Car starts with a key");
    }
}
class Bike : Vehicle
{
    public override void Start()
    {
        Console.WriteLine("Bike starts with a kick");
    }
}
class Truck : Vehicle
{
    public new void Start()
    {
        Console.WriteLine("Truck starts with a heavy engine");
    }
}
class SportsCar : Car
{
    //compiler error
    /*public override void Start()
    {
        Console.WriteLine("Sports car zooming");
    }*/
}
class Program
{
    static void Main()
    {
        Console.WriteLine("Runtime Polymorphism Demonstration");

        Vehicle myVehicle;
        myVehicle = new Car();
        myVehicle.Start();
        myVehicle = new Bike();
        myVehicle.Start();
        Console.WriteLine("Method Hiding Demonstration");
        Truck myTruck = new Truck();
        myTruck.Start();
        Vehicle hiddenTruck = new Truck();
        hiddenTruck.Start();
        Console.WriteLine("Task Completed");
    }
}