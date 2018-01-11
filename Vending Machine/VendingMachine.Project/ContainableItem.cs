using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VendingMachine.Project
{
    class ContainableItem
    {
        private int _size;
        private Product _product;
        private ProductPosition _productPositon;

        public ContainableItem() { }

        public ContainableItem(ProductPosition productPosition, int size, Product product)
        {
            _productPositon = productPosition;
            _size = size;
            _product = product;
        }

        public int Size => _size;

        public Product Product => _product;
    }
}
