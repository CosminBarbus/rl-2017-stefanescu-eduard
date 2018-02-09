using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VendingMachine.Project.Banknotes
{
    class FiveRon : Banknote
    {
        private double _fiveRon = 5;
        public override string Type() => "5 RON";

        public override double Amount
        {
            get { return _fiveRon; }
        }
    }
}
