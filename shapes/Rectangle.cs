namespace Shape;

public class Rectangle : Shape
{
    public double Width { get; }
    public double Height { get; }

    public Rectangle(string color, double width, double height) : base("Rectangle", color)
    {
        Width = width;
        Height = height;
    }

    public override double Area() => Width * Height;
}
