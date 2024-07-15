using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingCartApplication
{
    public class ClothingStore
    {
        public List<Product> product;
        public ProductGenerator generator;
        public ClothingStore()
        {
           generator = new ProductGenerator();
            product = new List<Product>();

            product = Enumerable.Range(0, 5)
                                .Select(_ => generator.GenerateRandomProduct(ProductCategory.Clothing))
                                //.Where(p => p.Category == ProductCategory.Clothing)
                                .ToList();
        }

        public void DisplayAvailableProducts()
        {
            Console.WriteLine("\nClothing Store Products:");
            foreach (var product in product)
            {
                Console.WriteLine(product);
            }
        }
        public Product SelectProduct(string productName)
        {
            return product.Find(p => p.Name.Equals(productName, StringComparison.OrdinalIgnoreCase));
        }

    }
}
