using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VendingMachine.UnitTests
{
    interface IMoney
    {
        string MoneyType();

        double Amount
        { get; }
    }
}
