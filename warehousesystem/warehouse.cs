namespace Warehouse;

public class Warehouse
{
		public List<IProduct> Products { get; set; } = new List<IProduct>();

		public void AddProduct(IProduct product)
		{
				Products.Add(product);
		}

		public void RemoveProduct(IProduct product)
		{
				Products.Remove(product);
		}

		public void PrintProducts()
		{
				Console.WriteLine($"Products: {Products.Count}");
				for (int i = 0; i < Products.Count; i++)
				{
						Console.Write($"{i}.");
						Products[i].Print();
						Console.WriteLine();
				}
		}
}
