namespace Warehouse;

public interface IProduct
{
	public string Name { get; set; }
	public double Price { get; set; }

	public void Print();
}
