using System;
using System.Collections.Generic;
using VendingMachine.Project.Exceptions;

namespace VendingMachine.Project.ProductsLogic
{
    public class ProductBand
    {
        private readonly List<ContainableItem> _products;
        private int _bandSize = 20;

        private static ProductBand _instance;

        private static readonly object SyncLock = new object();

        private ProductBand()
        {
            _products = new List<ContainableItem>();
        }

        public static ProductBand Instance
        {
            get
            {
                if (_instance == null)
                    lock (SyncLock)
                        if (_instance == null)
                            _instance = new ProductBand();

                return _instance;
            }
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

        public ContainableItem GetByName(string productName)
        {
            foreach (var containableItem in _products)
                if (string.Equals(containableItem.Product.Name, productName, StringComparison.OrdinalIgnoreCase))
                    return containableItem;

            throw new ProductNotFoundException();
        }

        public int BandSize => _bandSize;

        public IEnumerable<ContainableItem> Products => new List<ContainableItem>(_products);
    }
}
