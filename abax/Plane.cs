namespace Abax;

public class Plane : Vehicle
{
    private int _wingSpan { get; set; }
    private string _wingSpanUnit { get; set; }
    private int _weight { get; set; }
    private string _weightUnit { get; set; }
    private int _capacity { get; set; }
    private string _capacityUnit { get; set; }

    public Plane(
                    string registration,
                    int effect,
                    int wingSpan,
                    string wingSpanUnit,
                    int weight,
                    string weightUnit,
                    int capacity,
                    string capacityUnit
    ) : base(registration, effect, "kw")
    {
        _wingSpan = wingSpan;
        _wingSpanUnit = wingSpanUnit;
        _weight = weight;
        _weightUnit = weightUnit;
        _capacity = capacity;
        _capacityUnit = capacityUnit;
    }

    public override void PrintInfo()
    {
        Console.WriteLine($"Wing Span: {_wingSpan}{_wingSpanUnit}\nWeight: {_weight}{_weightUnit}\nCapacity: {_capacity}{_capacityUnit}");
        base.PrintInfo();
    }

		public void Fly()
		{
				Console.WriteLine("Flying!");
		}
}
