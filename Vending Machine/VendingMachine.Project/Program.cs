using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VendingMachine.Project
{
    class Program
    {
        static void Main()
        {
            ProductBand pringlesBand = new ProductBand(new List<ContainableItem>());
            ContainableItem pringlesItem = CreateProducts.CreatePringlesProduct();
            Dispenser dispenser = new Dispenser(new List<ProductBand>());

            dispenser.AddCell(pringlesBand);

            pringlesBand.Add(pringlesItem);
            pringlesBand.Remove(pringlesItem);
            pringlesBand.Count();
            ContainableItem pringles = pringlesBand.GetFirstItem();

            pringlesBand.Add(pringlesItem);
            dispenser.Dispense(pringlesItem);
        }
    }
}
