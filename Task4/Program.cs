using System;
using Task4;

class Program
{
    static void Main(string[] args)
    {
        Car car = new Car();
        Bike bike = new Bike();

        // Car
        car.Display();
        car.StartEngine();
        car.StopEngine();

        Console.WriteLine();

        // Bike
        bike.Display();
        bike.StartEngine();
        bike.StopEngine();
    }
}
