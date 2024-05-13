namespace Shape;

public class Triangle : Shape
{
    public double Base { get; }
    public double Height { get; }

    public Triangle(string color, double @base, double height) : base("Triangle", color)
    {
        Base = @base;
        Height = height;
    }

    public override double Area() => 0.5 * Base * Height;
}
