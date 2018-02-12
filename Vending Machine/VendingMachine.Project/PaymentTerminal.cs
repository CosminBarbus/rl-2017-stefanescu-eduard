using System;
using System.Collections.Generic;

namespace VendingMachine.Project
{
    public class PaymentTerminal
    {
        private List<IDispenser> _dispensers;
        private InternalAccountant _internalAccountant;

        public PaymentTerminal()
        {
            _dispensers = new List<IDispenser>();
            _internalAccountant = new InternalAccountant();
        }

        public void Attach(IDispenser iDispenser)
        {
            _dispensers.Add(iDispenser);
        }

        public void Detach(IDispenser iDispenser)
        {
            _dispensers.Remove(iDispenser);
        }

        private void Notify(ContainableItem containableItem)
        {
            foreach (var dispenser in _dispensers)
            {
                dispenser.Dispense(containableItem);
            }
        }

        public decimal Pay(IPayment payment, int numberOfMoney, string productName)
        {
            ContainableItem containableItem = ProductBand.Instance().GetByName(productName);
            if (_internalAccountant.IsEnoughMoney(containableItem,
                _internalAccountant.TotalAmount(payment, numberOfMoney)))
            {
                Notify(containableItem);

                return payment.GetChange();
                //if (payment is Coin)
                //{
                //    return _internalAccountant.CalculateChange(containableItem.Product.Price, payment, numberOfMoney);
                //}
                //if (payment is CreditCard)
                //{
                //    payment.Amount -= containableItem.Product.Price;
                //    return 0;
                //}
                //if (payment is Banknote)
                //    return 0;
            }
            throw new ArgumentException("You need to enter more money.");
        }
    }
}
