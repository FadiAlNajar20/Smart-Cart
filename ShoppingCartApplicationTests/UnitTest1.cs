using ShoppingCartApplication;

namespace ShoppingCartApplicationTests
{
    public class UnitTest1
    {
        [Fact]
        public void TestAddItemsFromTheCart()
        {
            var cart = new ShoppingCart();
            var product = new Product("Aplle", 10.0, ProductCategory.Food);

            cart.AddItem(product);
            Assert.Contains(product, cart.items);
        }

        [Fact]
        public void TestRemoveItemsFromTheCart()
        {
            var cart = new ShoppingCart();
            var product = new Product("Apple", 10.0, ProductCategory.Food);

            cart.AddItem(product);
            cart.RemoveItem(product);
            Assert.DoesNotContain(product, cart.items);
        }

        [Fact]
        public void TestCalculateTotalCost()
        {
            var cart = new ShoppingCart();
            var product1 = new Product("Apple", 10.0, ProductCategory.Food);
            var product2 = new Product("Banana", 20.0, ProductCategory.Clothing);

            cart.AddItem(product1);
            cart.AddItem(product2);
            var totalCost = cart.CalculateTotalCost();

            Assert.Equal(30.0, totalCost);
        }
    }
}