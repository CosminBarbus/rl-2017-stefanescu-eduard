using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VendingMachine.ConsoleUI.Exceptions
{
    class BandIsEmptyException : Exception
    {
        private string _operationType;

        public BandIsEmptyException(string _operationType)
        {
            this._operationType = _operationType;
        }

        public void DisplayException()
        {
            Console.WriteLine("\nBand is empty! You can't {0} any item!\n" +
                              "Press any key and try again!", _operationType);
        }
    }
}
