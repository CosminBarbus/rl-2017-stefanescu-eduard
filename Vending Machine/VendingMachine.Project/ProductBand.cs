using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VendingMachine.Project
{
    public class ProductBand
    {
        private List<ContainableItem> _products;
        private int _bandSize = 20;

        public ProductBand()
        {
            _products = new List<ContainableItem>();
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

        public decimal GetProductPrice(string productName)
        {
            ContainableItem containableItem = _products.
                FirstOrDefault(x =>
                x.Product.Name.Equals(productName, StringComparison.InvariantCultureIgnoreCase));
            if (containableItem != null)
                return containableItem.Product.Price;
            throw new ArgumentException($"No product found with name {productName}");
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
