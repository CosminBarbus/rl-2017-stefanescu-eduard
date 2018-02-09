using System.Collections.Generic;
using VendingMachine.Project;
using VendingMachine.Project.Banknotes;

namespace VendingMachine.ConsoleUI
{
    class Program
    {
        static void Main()
        {
            ProductBand pringlesBand = new ProductBand();
            LoadPringles(pringlesBand);
            Dispenser dispenser = new Dispenser();
            dispenser.Add(pringlesBand);

            PaymentTerminal paymentTerminal = new PaymentTerminal();
            paymentTerminal.Subscribe(dispenser);

            //
            IMoney fiveRon = new FiveRon();
            paymentTerminal.Pay(fiveRon,1, "pringles");
        }

        private static void LoadPringles(ProductBand pringlesBand)
        {
            pringlesBand.Add(ProductFactory.CreatePringlesProduct());
        }
    }
}
