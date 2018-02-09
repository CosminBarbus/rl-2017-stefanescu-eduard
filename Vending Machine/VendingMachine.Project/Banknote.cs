using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VendingMachine.Project
{
    public abstract class Banknote : IMoney
    {
        public abstract string Type();
        public string MoneyType() => "banknotes";
        public abstract decimal Amount { get; }
    }
}
