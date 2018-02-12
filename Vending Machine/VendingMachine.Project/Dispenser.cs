using System;
using System.Collections.Generic;

namespace VendingMachine.Project
{
    public class Dispenser : IDispenser
    {
       public void Dispense(ContainableItem containableItem)
       {
            ContainableItem product = ProductBand.Instance().GetByName(containableItem.Product.Name);
            ProductBand.Instance().Remove(product);
        }
    }
}
