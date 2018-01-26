using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VendingMachine.UnitTests
{
    class CreditCard : IMoney
    {
        private double _cardAmount;
        public string MoneyType() => "credit card";

        public double Amount
        {
            get { return _cardAmount; }
            set { _cardAmount = value; }
        }
    }
}
