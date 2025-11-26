using Task2;

class Program
{
    static void Main(string[] args)
    {
        Car car = new Car();
        car.Brand = "Toyota";
        car.Speed = 120;
        car.Seats = 4;

        Motorcycle bike = new Motorcycle();
        bike.Brand = "Honda";
        bike.Speed = 90;
        bike.HasCarrier = true;

        car.Start();
        car.DisplayInfo();
        car.Stop();

        Console.WriteLine();

        bike.Start();
        bike.DisplayInfo();
        bike.Stop();
    }
}
