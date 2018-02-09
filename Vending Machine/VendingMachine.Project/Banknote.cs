using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VendingMachine.Project
{
    abstract class Banknote : IMoney
    {
        public abstract string Type();
        public string MoneyType() => "banknotes";
        public abstract double Amount { get; }
    }
}
