using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VendingMachine.Project.Banknotes
{
    class OneRon : Banknote
    {
        private decimal _oneRon = 1;
        public override string Type() => "1 RON";

        public override decimal Amount
        {
            get { return _oneRon; }
        }
    }
}
