using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VendingMachine.UnitTests.Coins
{
    class TenBani : Coin
    {
        private double _tenBani = 0.10;
        public override string Type()
        {
            return "10 bani";
        }

        public override double Amount
        {
            get { return _tenBani; }
        }
    }
}
