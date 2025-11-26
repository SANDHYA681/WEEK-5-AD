using System.Collections.Generic;

namespace Task5
{
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
            Console.WriteLine("\n--- All Device Details ---");

            foreach (var device in devices)
            {
                device.ShowInfo();

                // Downcasting to call child-specific methods
                if (device is Laptop l)
                {
                    l.TurnOnBattery();
                }
                else if (device is Smartphone s)
                {
                    s.EnableCamera();
                }

                Console.WriteLine();
            }
        }
    }
}
