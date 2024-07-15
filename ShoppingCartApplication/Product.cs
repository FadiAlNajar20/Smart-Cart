using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingCartApplication
{
    public enum ProductCategory
    {
        Food,
        Clothing,
        Electronics
    }
 
    public class Product
    {
        public static void DisplayEnum()
        {
            Console.WriteLine("\nThe Departments:");
            foreach (var category in Enum.GetNames(typeof(ProductCategory)))
            {
                Console.WriteLine($"\t* {category}");
            }
            Console.WriteLine();

        }
        public string Name { get; set; }
        public double Price { get; set; }
        public ProductCategory Category { get; set; }

        public Product(string name, double price, ProductCategory category)
        {
            Name = name;
            Price = price;
            Category = category;
        }

        public override string ToString()
        {
            return $"{Name} Pric: {Price} Category: {Category}";
        }
    }
}
