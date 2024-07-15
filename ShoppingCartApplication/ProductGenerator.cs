using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingCartApplication
{
    public class ProductGenerator
    {
        public Random random = new Random();

        private readonly string[] foodProducts = { "Bulgur", "Bread", "Rice", "Sugar", "Flour" };
        private readonly string[] clothingProducts = { "T-Shirt", "Jeans", "Shirt", "Suit" };
        private readonly string[] electronicsProducts = { "Headphones", "Lamp", "Power Adapter" };

        public Product GenerateRandomProduct(ProductCategory category)
        {
            string[] productNames;

            switch (category)
            {
                case ProductCategory.Food:
                    productNames = foodProducts;
                    break;
                case ProductCategory.Clothing:
                    productNames = clothingProducts;
                    break;
                case ProductCategory.Electronics:
                    productNames = electronicsProducts;
                    break;
                default:
                    throw new ArgumentException("Invalid product category");
            }

            var randomName = productNames[random.Next(productNames.Length)];
            var randomPrice = Math.Round((random.Next(50, 150) + random.NextDouble()), 2);
            return new Product(randomName, randomPrice, category);
        
        }
    }
    
}
