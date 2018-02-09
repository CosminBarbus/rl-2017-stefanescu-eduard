using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VendingMachine.Project
{
    abstract class Coin : IMoney
    {
        public abstract string Type();
        public string MoneyType() => "coins";
        public abstract decimal Amount { get; }
    }
}
