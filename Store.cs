using System.Collections.Generic;

namespace ConsoleApp1
{
    internal class ProductStore
    {
        public List<Product> Products { get; private set; } = new List<Product>();

        public void AddProduct(Product product)
        {
            Products.Add(product);
        }

        public void DisplayProducts()
        {
            foreach (var product in Products)
            {
                Console.WriteLine(product.GetInformation());
            }
        }
    }
}
