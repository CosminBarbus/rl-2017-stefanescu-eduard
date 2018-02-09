using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VendingMachine.Project.Banknotes
{
    public class FiveRon : Banknote
    {
        private decimal _fiveRon = 5;
        public override string Type() => "5 RON";

        public override decimal Amount
        {
            get { return _fiveRon; }
        }
    }
}
