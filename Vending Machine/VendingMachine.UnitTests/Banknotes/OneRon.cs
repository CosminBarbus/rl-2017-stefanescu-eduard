using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VendingMachine.UnitTests.Banknotes
{
    class OneRon : Banknote
    {
        private double _oneRon = 1;
        public override string Type() => "1 RON";

        public override double Amount
        {
            get { return _oneRon; }
        }
    }
}
