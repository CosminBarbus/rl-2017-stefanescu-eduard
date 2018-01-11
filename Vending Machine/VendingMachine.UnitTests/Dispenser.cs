using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VendingMachine.UnitTests
{
    class Dispenser
    {
        private List<ProductBand> _bands;

        public Dispenser(List<ProductBand> bands)
        {
            _bands = bands;
        }

        public void AddCell(ProductBand productBand)
        {
            int bandExist = 0;
            foreach (ProductBand band in _bands)
                foreach (ContainableItem item in band.Products)
                    if (item.Product.Name == productBand.GetFirstItem().Product.Name)
                        bandExist = 1;
            if (bandExist == 0)
                _bands.Add(productBand);
        }

        public void Dispense(ContainableItem containableItem)
        {
            foreach (ProductBand band in _bands)
                foreach (ContainableItem item in band.Products.Take(1))
                    if (containableItem.Product.Name == item.Product.Name)
                        band.Remove(item);
        }

        public List<ProductBand> Bands => _bands;
    }
}
