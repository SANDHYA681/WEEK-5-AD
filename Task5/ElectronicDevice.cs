public abstract class ElectronicDevice
{

    private string brand;
    private double price;

    public string Brand
    {
        get { return brand; }
        set { brand = value; }
    }

    public double Price
    {
        get { return price; }
        set
        {
            if (value > 0)
                price = value;
        }
    }

    public ElectronicDevice(string brand, double price)
    {
        this.brand = brand;
        this.price = price;
    }

    public abstract void ShowInfo();
}