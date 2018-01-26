using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VendingMachine.UnitTests.Coins
{
    class FiftyBani : Coin
    {
        private double _fiftyBani = 0.50;
        public override string Type()
        {
            return "50 bani";
        }

        public override double Amount
        {
            get { return _fiftyBani; }
        }
    }
}
