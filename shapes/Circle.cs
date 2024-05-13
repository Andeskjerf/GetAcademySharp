namespace Shape;

public class Circle : Shape
{
    public double Radius { get; }

    public Circle(string color, double radius) : base("Circle", color)
    {
        Radius = radius;
    }

    public override double Area() => Math.PI * Radius * Radius;
}
