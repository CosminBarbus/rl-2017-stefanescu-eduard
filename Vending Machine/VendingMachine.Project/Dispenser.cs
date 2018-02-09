using System;
using System.Collections.Generic;

namespace VendingMachine.Project
{
    public class Dispenser : IDispenser
    {
        private List<ProductBand> _productBands;

        public Dispenser()
        {
            _productBands = new List<ProductBand>();
        }

        public void Add(ProductBand productBand)
        {
            _productBands.Add(productBand);
        }

        public void Dispense(ContainableItem containableItem)
        {
            foreach (ProductBand productBand in _productBands)
            {
                if (string.Equals(productBand.GetFirstItem().Product.Name, containableItem.Product.Name,
                    StringComparison.OrdinalIgnoreCase))
                    productBand.Remove(containableItem);
            }
        }
    }
}
