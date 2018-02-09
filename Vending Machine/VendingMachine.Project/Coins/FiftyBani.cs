using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VendingMachine.Project.Coins
{
    class FiftyBani : Coin
    {
        private decimal _fiftyBani = 0.5m;
        public override string Type()
        {
            return "50 bani";
        }

        public override decimal Amount
        {
            get { return _fiftyBani; }
        }
    }
}
