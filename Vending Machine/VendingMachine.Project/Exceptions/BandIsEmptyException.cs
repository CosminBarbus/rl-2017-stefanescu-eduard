using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VendingMachine.ConsoleUI.Exceptions
{
    public class BandIsEmptyException : Exception
    {
        public BandIsEmptyException(string operationType) : base(operationType) { }
    }
}
