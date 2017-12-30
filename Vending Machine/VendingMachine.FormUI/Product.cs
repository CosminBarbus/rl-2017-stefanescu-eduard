using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VendingMachine.FormUI
{
    public class Product
    {
        private string _name;
        private double _price;
        private ProductCategory _category;

        public Product(string name, double price, ProductCategory category)
        {
            _name = name;
            _price = price;
            _category = category;
        }

        public string Name => _name;

        public double Price => _price;

        public ProductCategory Category => _category;
    }
}
