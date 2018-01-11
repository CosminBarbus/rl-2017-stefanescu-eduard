using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VendingMachine.Project
{
    class ProductBand
    {
        private List<ContainableItem> _products;
        private int _bandSize = 20;

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
        }

        public void Remove(ContainableItem containableItem)
        {
            if (_products.Count > 0)
            {
                _products.Remove(containableItem);
                _bandSize += containableItem.Size;
            }
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
