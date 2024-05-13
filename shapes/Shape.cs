namespace Shape;

public abstract class Shape
{
    public string Name { get; }
    public string Color { get; }

    public Shape(string name, string color)
    {
        Name = name;
        Color = color;
    }

    public abstract double Area();

    public void PrintInfo()
    {
        Console.WriteLine($"Name: {Name}\nColor: {Color}\nArea: {Area()}");
    }
}
