namespace Abax;

public class Boat : Vehicle
{
    public int MaxSpeed { get; }
    public string MaxSpeedUnit { get; }
    public int GrossTonnage { get; }
    public string GrossTonnageUnit { get; }

    public Boat(string registration, int effect, int maxSpeed, string maxSpeedUnit, int grossTonnage, string grossTonnageUnit) : base(registration, effect, "kw")
    {
        MaxSpeed = maxSpeed;
        MaxSpeedUnit = maxSpeedUnit;
        GrossTonnage = grossTonnage;
        GrossTonnageUnit = grossTonnageUnit;
    }

    public override void PrintInfo()
    {
        Console.WriteLine($"Max Speed: {MaxSpeed}{MaxSpeedUnit}\nGross Tonnage: {GrossTonnage}{GrossTonnageUnit}");
        base.PrintInfo();
    }
}
