using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VendingMachine.Project
{
    class Dispenser
    {
        public void Dispense(ProductBand productBand, ContainableItem containableItem) => productBand.Remove(containableItem);
    }
}
