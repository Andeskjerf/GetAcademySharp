namespace Abax
{
    public static class Program
    {
        public static void Main(string[] args)
        {
            Car car1 = new Car("Green", "NF123456", 200, "km/h", 147, true);
            Car car2 = new Car("Blue", "NF654321", 195, "km/h", 150, true);
            car1.PrintInfo();
            car2.PrintInfo();
            Console.WriteLine("Is car1 same as car2? " + car1.IsSameAs(car2));

            Plane plane1 = new Plane("LN1234", 1000, 30, "m", 10, "ton", 2, "ton");
            plane1.PrintInfo();

            plane1.Fly();
            car1.Drive();

						Boat boat1 = new Boat("ABC123", 100, 30, "knop", 500, "kg");
						boat1.PrintInfo();
        }
    }
}
