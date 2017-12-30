using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VendingMachine.ConsoleUI.Exceptions
{
    class BandIsFullException : Exception
    {
        public BandIsFullException()
            : base("\nBand is full! It can't store any products!\n " +
                   "Press any key and try again!")
        {

        }
    }
}
