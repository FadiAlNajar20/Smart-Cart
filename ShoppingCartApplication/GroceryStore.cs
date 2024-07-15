using ShoppingCartApplication;
using System;
using System.Collections.Generic;

public class GroceryStore
{
    private List<Product> products;
    private ProductGenerator generator;

    public GroceryStore()
    {
        generator = new ProductGenerator();
        products = new List<Product>();

        products = Enumerable.Range(0, 5)
                              .Select(_ => generator.GenerateRandomProduct(ProductCategory.Food))
                              .ToList();    
    }

    public void DisplayAvailableProducts()
    {
        Console.WriteLine("\nGrocery Store Products:");
        foreach (var product in products)
        {
            Console.WriteLine(product);
        }
    }

    public Product SelectProduct(string productName)
    {
        return products.Find(p => p.Name.Equals(productName));
    }
}
    public class ElectronicsStore
    {
        private List<Product> products;
        private ProductGenerator generator;

        public ElectronicsStore()
        {
            generator = new ProductGenerator();
            products = new List<Product>();

            
            products = Enumerable.Range(0, 5) 
                                  .Select(_ => generator.GenerateRandomProduct(ProductCategory.Electronics))
                                  .ToList();
        }

        public void DisplayAvailableProducts()
        {
            Console.WriteLine("\nElectronics Store Products:");
            foreach (var product in products)
            {
                Console.WriteLine(product);
            }
        }

        public Product SelectProduct(string productName)
        {
            return products.Find(p => p.Name.Equals(productName, StringComparison.OrdinalIgnoreCase));
        }
    }

