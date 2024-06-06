using System.Collections.Generic;

namespace ListApplication.Types
{
    public class Product(string name, double price)
    {
        public string Name { get; private set; } = name;
        public double Price { get; private set; } = price;

        public static readonly List<Product> availableProducts = [
                new Product("Apple", 0.99),
                new Product("Banana", 0.49),
                new Product("Orange", 0.79),
                new Product("Grapes", 1.99),
                new Product("Strawberries", 2.49),
                new Product("Watermelon", 3.99),
                new Product("Pineapple", 1.49),
                new Product("Mango", 1.99),
                new Product("Peach", 0.89),
                new Product("Pear", 0.79),
                new Product("Cherry", 1.29),
                new Product("Blueberry", 2.99),
                new Product("Raspberry", 2.49),
                new Product("Kiwi", 0.99),
                new Product("Lemon", 0.69),
                new Product("Avocado", 1.99),
                new Product("Pomegranate", 2.99),
                new Product("Plum", 0.79),
                new Product("Coconut", 2.49),
                new Product("Papaya", 1.99)
        ];

        public override string ToString()
        {
            return Name;
        }
    }
}


