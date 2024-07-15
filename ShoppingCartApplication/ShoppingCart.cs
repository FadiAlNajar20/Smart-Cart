using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingCartApplication
{
    public class ShoppingCart
    {
        public List<Product> items;

        public ShoppingCart()
        {
            items = new List<Product>();
        }

        public void AddItem(Product AddProduct)
        {
            items?.Add(AddProduct);
            Console.WriteLine($"\nThe Product '{AddProduct}' has been added to the cart.\n");
        }

        public void RemoveItem(Product delProduct)
        {
            var serchForProduct = items.FirstOrDefault(i => i.Equals(delProduct));
            
            if(serchForProduct is not null)
            {
                items?.Remove(serchForProduct);
                Console.WriteLine($"\nThe Product '{serchForProduct}' has been deleted from the cart.\n");
            }
            else
            {
                Console.WriteLine($"The Product '{serchForProduct}' is not found!");
            }
        }

        public double CalculateTotalCost()
        {
            double total = items.Sum(i => i.Price);
            return total;
        }


        public void ViewItems()
        {
            if (items.Count == 0 || items is null)
            {
                Console.WriteLine("\nYour Cart is empty.\n");
            }
            else
            {
                Console.WriteLine("\nYour item: ");
                for (var i = 0; i < items.Count; i++) 
                {
                    Console.WriteLine($"{i + 1}){items[i]}");
                } 
            }
        }
    }
}
