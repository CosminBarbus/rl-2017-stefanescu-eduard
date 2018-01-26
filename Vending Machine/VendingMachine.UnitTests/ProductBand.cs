using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VendingMachine.UnitTests.Exceptions;

namespace VendingMachine.UnitTests
{
    class ProductBand
    {
        private List<ContainableItem> _products;
        private int _bandSize = 20;

        public int BandSize => _bandSize;

        public ProductBand(List<ContainableItem> products)
        {
            _products = products;
        }

        public void Add(ContainableItem containableItem)
        {
            if (_bandSize > 0)
            {
                _products.Add(containableItem);
                _bandSize -= containableItem.Size;
            }
            else
                throw new BandIsFullException();
        }

        public void Remove(ContainableItem containableItem)
        {
            if (_products.Count == 0)
                throw new BandIsEmptyException();
            if (_products.Count > 0)
            {
                _products.Remove(containableItem);
                _bandSize += containableItem.Size;
            }
            else
                throw new BandIsFullException();
        }

        public int Count() => _products.Count();

        public ContainableItem GetFirstItem()
        {
            ContainableItem emptyProduct = new ContainableItem();
            if (_products.Count > 0)
                return _products[0];
            return emptyProduct;
        }

        public List<ContainableItem> Products => _products;
    }
}
