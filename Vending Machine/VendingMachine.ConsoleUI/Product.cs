using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VendingMachine.ConsoleUI
{
    class Product
    {
        private string _name;
        private double _price;
        private ProductCategory _productCategory;

        public Product(string name, double price, ProductCategory category)
        {
            _name = name;
            _price = price;
            _productCategory = category;
        }

        public string Name => _name;

        public double Price => _price;

        public ProductCategory Category => _productCategory;
    }
}
