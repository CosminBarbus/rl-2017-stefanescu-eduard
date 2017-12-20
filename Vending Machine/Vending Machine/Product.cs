using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vending_Machine
{
    class Product
    {
        private string name;
        private double price;
        private ProductCategory category;

        public Product(string _name, double _price, ProductCategory _category)
        {
            name = _name;
            price = _price;
            category = _category;
        }
    }
}
