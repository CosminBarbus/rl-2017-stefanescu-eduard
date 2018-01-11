using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VendingMachine.UnitTests
{
    class ContainableItem
    {
        private int _size;
        private Product _product;
        private ProductPosition _productPosition;

        public ContainableItem(ProductPosition productPosition, int size, Product product)
        {
            _productPosition = productPosition;
            _size = size;
            _product = product;
        }

        public ContainableItem() { }

        public int Size => _size;

        public Product Product => _product;
    }
}
