namespace Warehouse
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Warehouse warehouse = new Warehouse();
            Electronic e1 = new Electronic("Phone", 1000, 12);
            Electronic e2 = new Electronic("Laptop", 2000, 24);
            warehouse.AddProduct(e1);
            warehouse.AddProduct(e2);

            Food f1 = new Food("Pizza", 10, "2022-12-31");
            Food f2 = new Food("Burger", 5, "2022-12-31");
            warehouse.AddProduct(f1);
            warehouse.AddProduct(f2);

            Clothes c1 = new Clothes("T-Shirt", 10, 42);
            Clothes c2 = new Clothes("Jeans", 20, 42);
            warehouse.AddProduct(c1);
            warehouse.AddProduct(c2);

            warehouse.PrintProducts();

            warehouse.RemoveProduct(e1);

            warehouse.PrintProducts();
        }
    }
}
