using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VendingMachine.Project.Banknotes;

namespace VendingMachine.Project
{
    class Program
    {
        static void Main()
        {
            ProductBand pringlesBand = new ProductBand(new List<ContainableItem>());
            ContainableItem pringlesItem = ProductFactory.CreatePringlesProduct();
            IMoney fiveRon = new FiveRon();
            Payment payment = new Payment(fiveRon, 2);

            pringlesBand.Add(pringlesItem);
            payment.Pay(pringlesBand, pringlesItem);
        }
    }
}
