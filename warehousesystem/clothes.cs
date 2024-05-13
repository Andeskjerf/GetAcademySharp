namespace Warehouse;

public class Clothes : IProduct
{
    public string Name { get; set; } = "";
    public double Price { get; set; } = 0.0;
    public int Size { get; set; } = 0;

    public Clothes(string name, double price, int size)
    {
        Name = name;
        Price = price;
        Size = size;
    }

    public void Print()
    {
        Console.WriteLine($"Name: {Name}, Price: {Price}, Size: {Size}");
    }
}
