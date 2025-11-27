using System;

class Program
{
    static void Main(string[] args)
    {
        ElectronicsStore store = new ElectronicsStore();

        // Creating objects
        Laptop laptop = new Laptop("Asus", 1900, 12);
        Smartphone phone = new Smartphone("Zenbook", 500, 109);

        // Adding devices to store
        store.AddDevice(laptop);
        store.AddDevice(phone);

        // Displaying all device details
        store.ShowAllDeviceDetails();
    }
}