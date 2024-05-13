namespace Abax;

public class Car : Vehicle
{
    public string Color { get; }
    public int MaxSpeed { get; }
    public string SpeedUnit { get; }
    public bool IsLightCar { get; }

    public Car(
                        string color,
                        string registration,
                        int maxSpeed,
                        string speedUnit,
                        int effect,
                        bool isLightCar
    ) : base(registration, effect, "kw")
    {
        Color = color;
        MaxSpeed = maxSpeed;
        SpeedUnit = speedUnit;
        IsLightCar = isLightCar;
    }

    public override void PrintInfo()
    {
        Console.WriteLine($"Color: {Color}\nMax Speed: {MaxSpeed}{SpeedUnit}\nIs Light Car: {IsLightCar}");
        base.PrintInfo();
    }

    public bool IsSameAs(Car car)
    {
        return Color == car.Color && MaxSpeed == car.MaxSpeed && SpeedUnit == car.SpeedUnit && IsLightCar == car.IsLightCar && Registration == car.Registration && Effect == car.Effect;
    }

    public void Drive()
    {
        Console.WriteLine("Driving!");
    }
}
