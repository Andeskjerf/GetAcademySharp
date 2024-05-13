namespace Shape
{
    public static class Program
    {
        public static void Main(string[] args)
        {
            List<Shape> shapes = new List<Shape>();
            shapes.Add(new Circle("red", 5));
            shapes.Add(new Rectangle("blue", 5, 10));
            shapes.Add(new Triangle("green", 5, 10));
            shapes.Add(new Circle("pink", 8));
            shapes.Add(new Rectangle("orange", 9, 15));
            shapes.Add(new Triangle("purple", 2, 20));

            foreach (var shape in shapes)
            {
                shape.PrintInfo();
            }

            Console.WriteLine($"Total area: {TotalArea(shapes)}");

            shapes = SortByArea(shapes);
            foreach (var shape in shapes)
            {
                shape.PrintInfo();
            }

            shapes = FilterByColor(shapes, "red");
            foreach (var shape in shapes)
            {
                shape.PrintInfo();
            }
        }

        public static double TotalArea(List<Shape> shapes)
        {
            double totalArea = 0;
            foreach (var shape in shapes)
            {
                totalArea += shape.Area();
            }
            return totalArea;
        }

        public static List<Shape> SortByArea(List<Shape> shapes)
        {
            return shapes.OrderBy(shape => shape.Area()).ToList();
        }

        public static List<Shape> FilterByColor(List<Shape> shapes, string color)
        {
            return shapes.Where(shape => shape.Color == color).ToList();
        }
    }
}
