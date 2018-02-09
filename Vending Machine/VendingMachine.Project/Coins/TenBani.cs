using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VendingMachine.Project.Coins
{
    class TenBani : Coin
    {
        private decimal _tenBani = 0.1m;
        public override string Type()
        {
            return "10 bani";
        }

        public override decimal Amount
        {
            get { return _tenBani; }
        }
    }
}
