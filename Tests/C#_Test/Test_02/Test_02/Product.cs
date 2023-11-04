using System;
class Product
{
    public int ProductID { get; set; }
    public string Name { get; set; }
    public double Price { get; set; }

}
class Products
{
    static void Main()
    {
        Product[] products = new Product[10];
        // Accepting 10 products

        for (int i = 0; i < products.Length; i++)
        {
            Console.WriteLine($"Enter details for Product {i + 1}:");
            Console.Write("Product ID: ");
            int productId = int.Parse(Console.ReadLine());


            Console.Write("Product Name: ");
            string name = Console.ReadLine();

            Console.Write("Price of the Product: ");
            double price = double.Parse(Console.ReadLine());

            products[i] = new Product { ProductID = productId, Name = name, Price = price };
        }

        for (int i = 0; i < products.Length - 1; i++)
        {
            for (int j = 0; j < products.Length - i - 1; j++)
            {
                if (products[j].Price > products[j + 1].Price)
                {
                    Product temp = products[j];
                    products[j] = products[j + 1];
                    products[j + 1] = temp;

                }
            }
        }
        Console.WriteLine("\nSorted Products by Price:");
        foreach (Product product in products)
        { 
            Console.WriteLine($"Product ID: {product.ProductID}, Name: {product.Name}, Price: {product.Price}");
        }

    }

}