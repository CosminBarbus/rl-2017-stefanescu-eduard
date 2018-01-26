using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VendingMachine.UnitTests
{
    class Product
    {
        private string _name;
        private double _price;
        private ProductCategory _category;

        public Product(string _name, double _price, ProductCategory _category)
        {
            this._name = _name;
            this._price = _price;
            this._category = _category;
        }

        public string Name => _name;

        public double Price => _price;
    }
}
