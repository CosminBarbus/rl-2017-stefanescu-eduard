using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VendingMachine.ConsoleUI
{
    class ContainableItem
    {
        private int _size;
        private ProductPosition _productPosition;
        private Product _product;

        public int Size => _size;

        public ProductPosition GetPostion => _productPosition;

        public Product GetProduct => _product;

        public void ReadProductCharacteristics()
        {
            Console.Write("Enter the name of the product: ");
            string name = Console.ReadLine();

            Console.Write("Enter the row of {0} product: ", name);
            int row = Int32.Parse(Console.ReadLine());

            Console.Write("Enter the column of {0} product: ", name);
            int column = Int32.Parse(Console.ReadLine());

            Console.Write("Enter the size of {0} product: ", name);
            _size = Int32.Parse(Console.ReadLine());

            Console.Write("Enter the price of {0} product: ", name);
            double price = Double.Parse(Console.ReadLine());

            Console.Write("Enter the category name of {0} product: ", name);
            string categoryName = Console.ReadLine();

            Console.Write("Enter the description of {0} product: ", name);
            string description = Console.ReadLine();
            Console.WriteLine();

            ProductCategory productCategory = new ProductCategory(categoryName, description);
            _productPosition = new ProductPosition(row, column);
            _product = new Product(name, price, productCategory);
        }
    }
}
