using System;
using System.Collections.Generic;

public class ElectronicsStore
{
    private List<ElectronicDevice> devices = new List<ElectronicDevice>();

    public void AddDevice(ElectronicDevice device)
    {
        devices.Add(device);
        Console.WriteLine("Device added to store.");
    }

    public void RemoveDevice(ElectronicDevice device)
    {
        devices.Remove(device);
        Console.WriteLine("Device removed from store.");
    }

    public void ShowAllDeviceDetails()
    {
        Console.WriteLine("\n=== All Device Details ===");

        foreach (ElectronicDevice device in devices)
        {
            device.ShowInfo();
            if (device is Laptop laptop)
            {
                laptop.LaptopFeature();
            }
            else if (device is Smartphone phone)
            {
                phone.SmartphoneFeature();
            }

            Console.WriteLine();
        }
    }
}