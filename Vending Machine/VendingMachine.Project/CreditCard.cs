using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VendingMachine.Project
{
    class CreditCard : IMoney
    {
        private decimal _cardAmount;
        public string MoneyType() => "credit card";

        public decimal Amount
        {
            get { return _cardAmount; }
            set { _cardAmount = value; }
        }
    }
}
