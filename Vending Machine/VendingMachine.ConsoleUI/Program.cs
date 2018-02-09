using System;
using VendingMachine.Project;
using VendingMachine.ConsoleUI.Exceptions;
using VendingMachine.Project.Banknotes;
using VendingMachine.Project.Coins;
using VendingMachine.Project.Exceptions;

namespace VendingMachine.ConsoleUI
{
    class Program
    {
        static void Main()
        {
            var pringlesBand = new ProductBand();
            var pringlesItem = ProductFactory.CreatePringlesProduct();
            var paymentTerminal = new PaymentTerminal();
            var visaCard = new CreditCard("4012888888881881");
            var dispenser = new Dispenser();

            try
            {
                pringlesBand.Add(pringlesItem);
                ProductDepot.AddProductInDepot(pringlesItem);
                dispenser.Add(pringlesBand);
                paymentTerminal.Attach(dispenser);

                paymentTerminal.Pay(visaCard, 1, "Pringles");
            }
            catch (Exception exception)
            {
                if (exception is BandIsFullException)
                    Console.WriteLine("Band is full! It can't store any items.");
                if (exception is BandIsEmptyException)
                    Console.WriteLine("Band is empty! You can't {0} any item!", exception.Message);
                if (exception is FormatException)
                    Console.WriteLine("You entered a wrong value! Press any key and try again!");
                if (exception is CardNotValidException)
                    Console.WriteLine("This credit card is not valid! Try another payment method.");
                if (exception is CardNotFoundException)
                    Console.WriteLine("Card was not found! Payment canceled!");
            }

            Console.ReadKey();
        }
    }
}
