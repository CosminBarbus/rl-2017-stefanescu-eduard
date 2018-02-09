using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VendingMachine.Project.Banknotes
{
    class TenRon : Banknote
    {
        private decimal _tenRon = 10;
        public override string Type() => "10 RON";

        public override decimal Amount
        {
            get { return _tenRon; }
        }
    }
}
