using System.IO.Compression;

namespace ShoppingCartApplication
{
    internal class Program
    {
        static void Main(string[] args)
        { 
                var shoppingCart = new ShoppingCart();
                var groceryStore = new GroceryStore();
                var clothingStore = new ClothingStore();
                var electronics = new ElectronicsStore();

                Console.WriteLine("Welcome to the Smart Shopping Cart!");

                while (true)
                {
                    Console.WriteLine("1. Shop at Grocery Store");
                    Console.WriteLine("2. Shop at Clothing Store");
                    Console.WriteLine("3. Shop at Electronics Store");
                    Console.WriteLine("4. View Shopping Cart");
                    Console.WriteLine("5. Calculate Total Cost");
                    Console.WriteLine("6. Check Out and Exit");
                    Console.Write("Select an option: ");
                    var option = Console.ReadLine();

                    switch (option)
                    {
                        case "1":
                            Shop(groceryStore, shoppingCart);
                            break;
                        case "2":
                            Shop(clothingStore, shoppingCart);
                            break;
                        case "3":
                            Shop(electronics, shoppingCart);
                            break;
                        case "4":
                            shoppingCart.ViewItems();
                            break;
                        case "5":
                            Console.WriteLine($"\nTotal Cost: ${shoppingCart.CalculateTotalCost():F2}\n");
                            break;
                        case "6":
                            Console.WriteLine("\nThank you for shopping with us!");
                            return;
                        default:
                            Console.WriteLine("Invalid option. Please try again.");
                            break;
                    }
                }
            }

            static void Shop(dynamic store, ShoppingCart cart)
            {
                store.DisplayAvailableProducts();
            Console.Write("Do you wnat to pic some thing? (Y / N): ");
            var askUserToEnterYOrN = Console.ReadLine().ToLower();
            if(askUserToEnterYOrN == "y")
            {
                Console.Write("Enter the product name to add to the cart: ");
                var productName = Console.ReadLine();
                var product = store.SelectProduct(productName);

                if (product != null)
                {
                    cart.AddItem(product);
                }
                else
                {
                    Console.WriteLine($"Product {productName} not found in the store.");
                }
            }
            else
            {
                Console.WriteLine("\nContinue shopping:");
            }


        }
     }
}
