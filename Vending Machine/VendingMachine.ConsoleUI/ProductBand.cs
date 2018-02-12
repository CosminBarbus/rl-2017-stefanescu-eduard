using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VendingMachine.ConsoleUI.Exceptions;

namespace VendingMachine.ConsoleUI
{
    class ProductBand
    {
        private List<ContainableItem> _products;
        private int _bandSize = 20;

        public ProductBand(List<ContainableItem> products)
        {
            this._products = products;
        }

        public void Add(ContainableItem containableItem)
        {
            if (_bandSize > 0)
            {
                _products.Add(containableItem);
                _bandSize -= containableItem.Size;
                Console.WriteLine("{0} product was added successfully!", containableItem.GetProduct.Name);
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
                Console.WriteLine("{0} product was removed successfully!", containableItem.GetProduct.Name);
            }
            else
                throw new BandIsEmptyException("remove");
        }

        public int Count() => _products.Count();

        public ContainableItem GetFirstItem()
        {
            if (_products.Count > 0)
                return _products[0];
            throw new BandIsEmptyException("get");
        }
    }
}
