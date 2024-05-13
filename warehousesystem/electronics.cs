namespace Warehouse;

public class Electronic : IProduct
{
    public string Name { get; set; } = "";
    public double Price { get; set; } = 0.0;

    // in months
    public int Warranty { get; set; } = 24;

    public Electronic(string name, double price, int warranty)
    {
        Name = name;
        Price = price;
        Warranty = warranty;
    }

    public void Print()
    {
        Console.WriteLine($"Name: {Name}, Price: {Price}, Warranty: {Warranty} months");
    }
}
