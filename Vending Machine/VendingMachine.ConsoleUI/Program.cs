using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VendingMachine.ConsoleUI.Exceptions;

namespace VendingMachine.ConsoleUI
{
    class Program
    {
        static void Main()
        {
            ProductBand snickersBand = new ProductBand(new List<ContainableItem>());
            ContainableItem snickers = new ContainableItem();
            try
            {
                snickers.ReadProductCharacteristics();
                snickersBand.Add(snickers);
                snickersBand.Add(snickers);
                ProductOutput.DisplayCount(snickersBand);
                snickersBand.Remove(snickers);
                ProductOutput.DisplayCount(snickersBand);

                ContainableItem snickersItem = snickersBand.GetFirstItem();
                ProductOutput.DisplayProduct(snickersItem);
            }
            catch (BandIsFullException bandIsFull)
            {
                Console.WriteLine(bandIsFull.Message);
            }
            catch (BandIsEmptyException bandIsEmpty)
            {
                bandIsEmpty.DisplayException();
            }
            catch (FormatException)
            {
                Console.WriteLine("You enter a wrong value! Press any key and try again!");
            }

            Console.ReadKey();
        }
    }
}
