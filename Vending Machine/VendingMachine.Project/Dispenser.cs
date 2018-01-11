using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VendingMachine.Project
{
    class Dispenser
    {
        private List<ProductBand> _bands;

        public Dispenser(List<ProductBand> bands)
        {
            _bands = bands;
        }

        public void AddCell(ProductBand productBand) => _bands.Add(productBand);

        public void Dispense(ContainableItem containableItem)
        {
            foreach (ProductBand band in _bands)
                foreach (ContainableItem item in band.Products.Take(1))
                    if (containableItem.Product.Name == item.Product.Name)
                        band.Remove(item);
        }
    }
}
