using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VendingMachine.Project
{
    public interface IMoney
    {
        string MoneyType();

        decimal Amount
        {
            get;
        }
    }
}
