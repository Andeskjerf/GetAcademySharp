namespace Warehouse;

public class Food : IProduct
{
    public string Name { get; set; } = "";
    public double Price { get; set; } = 0.0;
    public string Expiration { get; set; } = "";

    public Food(string name, double price, string expiration)
    {
        Name = name;
        Price = price;
        Expiration = expiration;
    }

    public void Print()
    {
        Console.WriteLine($"Name: {Name}, Price: {Price}, Expiration: {Expiration}");
    }
}
