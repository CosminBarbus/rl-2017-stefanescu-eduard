using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VendingMachine.FormUI
{
    public class ContainableItem
    {
        private int _size;
        private Product _product;
        private ProductPosition _productPositon;

        public ContainableItem(ProductPosition productPosition, int size, Product product)
        {
            _productPositon = productPosition;
            _size = size;
            _product = product;
        }

        public ContainableItem() { }

        public int Size => _size;

        public Product GetProduct => _product;

        public ProductPosition GetProductPosition => _productPositon;
    }
}
