namespace Task2
{
    public class Vehicle
    {
        public string Brand { get; set; }
        public int Speed { get; set; }

        public void Start()
        {
            Console.WriteLine(Brand + " Started");
        }

        public void Stop()
        {
            Console.WriteLine(Brand + " Stopped");
        }

        public virtual void DisplayInfo()
        {
            Console.WriteLine("Brand: " + Brand);
            Console.WriteLine("Speed: " + Speed);
        }
    }
}
