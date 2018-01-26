using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VendingMachine.UnitTests.Banknotes
{
    class TenRon : Banknote
    {
        private double _tenRon = 10;
        public override string Type() => "10 RON";

        public override double Amount
        {
            get { return _tenRon; }
        }
    }
}
