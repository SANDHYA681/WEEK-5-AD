public class Laptop : ElectronicDevice
{
    public int RAM { get; set; }

    public Laptop(string brand, double price, int ram)
        : base(brand, price)
    {
        this.RAM = ram;
    }

    public override void ShowInfo()
    {
        Console.WriteLine($"Laptop -> Brand: {Brand}, Price: {Price}, RAM: {RAM}GB");
    }

    // Child-specific method
    public void LaptopFeature()
    {
        Console.WriteLine("Laptop Feature: Best for multitasking.");
    }
}