public class Smartphone : ElectronicDevice
{
    public int CameraMP { get; set; }

    public Smartphone(string brand, double price, int cameraMP)
        : base(brand, price)
    {
        this.CameraMP = cameraMP;
    }

    public override void ShowInfo()
    {
        Console.WriteLine($"Smartphone -> Brand: {Brand}, Price: {Price}, Camera: {CameraMP}MP");
    }

    // Child  method
    public void SmartphoneFeature()
    {
        Console.WriteLine("Smartphone Feature: Great for photography.");
    }
}