using System.Collections.Generic;
using VendingMachine.ConsoleUI.Exceptions;

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
            else
                throw new BandIsFullException();
        }

        public void Remove(ContainableItem containableItem)
        {
            if (_products.Count > 0)
            {
                _products.Remove(containableItem);
                _bandSize += containableItem.Size;
            }
            else
                throw new BandIsEmptyException("remove");
        }

        public ContainableItem GetFirstItem()
        {
            if (_products.Count > 0)
                return _products[0];
            throw new BandIsEmptyException("get");
        }

        public int Count() => _products.Count;

        public int BandSize => _bandSize;
    }
}
