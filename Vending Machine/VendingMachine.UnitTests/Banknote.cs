using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VendingMachine.UnitTests
{
    abstract class Banknote : IMoney
    {
        public abstract string Type();

        public abstract double Amount { get; }
        public string MoneyType() => "banknotes";
    }
}
