using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VendingMachine.Project
{
    class Payment
    {
        private IMoney _iMoney;
        private int _numberOfMoney;
        private Dispenser _dispenser = new Dispenser();

        public Payment(IMoney iMoney, int numberOfMoney)
        {
            _iMoney = iMoney;
            _numberOfMoney = numberOfMoney;
        }

        public double Pay(ProductBand productBand, ContainableItem containableItem)
        {
            double totalAmount = 0;
            if (_iMoney is Banknote || _iMoney is Coin)
                totalAmount = _iMoney.Amount * _numberOfMoney;
            else if (_iMoney is CreditCard)
                totalAmount = _iMoney.Amount;
            if (totalAmount > containableItem.Product.Price)
            {
                _dispenser.Dispense(productBand, containableItem);
                return Math.Floor((totalAmount - containableItem.Product.Price) * 100 + 0.5) / 100;
            }
            if (containableItem.Product.Price == totalAmount)
                _dispenser.Dispense(productBand, containableItem);
            return 0;
        }
    }
}
