namespace Abax;

public abstract class Vehicle
{
    protected string Registration { get; }
		protected int Effect { get; }
		protected string EffectUnit { get; }

    public Vehicle(string registration, int effect, string effectUnit = "kw")
    {
        Registration = registration;
        Effect = effect;
				EffectUnit = effectUnit;
    }

		public virtual void PrintInfo()
		{
				Console.WriteLine($"Registration: {Registration}\nEffect: {Effect}{EffectUnit}");
		}
}
