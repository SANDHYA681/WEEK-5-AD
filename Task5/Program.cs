using System;
using Task5;

class Program
{
    static void Main(string[] args)
    {
        ElectronicsStore store = new ElectronicsStore();

        
        Laptop laptop = new Laptop("Asus", 80000);
        Smartphone phone = new Smartphone("Zenbook", 50000);

        store.AddDevice(laptop);
        store.AddDevice(phone);

        store.ShowAllDeviceDetails();
    }
}
