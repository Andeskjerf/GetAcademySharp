namespace UnitTestCalc;

[TestFixture]
public class Tests
{
    public Calculator calc = new Calculator();

    [Test]
    public void Addition()
    {
        int result = calc.Add(2, 3);
        Assert.That(result, Is.EqualTo(5));
    }

    [Test]
    public void Subtraction()
    {
        int result = calc.Subtract(5, 3);
        Assert.That(result, Is.EqualTo(2));
    }

    [Test]
    public void Multiplication()
    {
        int result = calc.Multiply(2, 3);
        Assert.That(result, Is.EqualTo(6));
    }

    [Test]
    public void Division()
    {
        int result = calc.Divide(6, 3);
        Assert.That(result, Is.EqualTo(2));
    }

		[Test]
		public void DivideByZero()
		{
			Assert.Throws<ArgumentException>(() => calc.Divide(6, 0));
		}
}
