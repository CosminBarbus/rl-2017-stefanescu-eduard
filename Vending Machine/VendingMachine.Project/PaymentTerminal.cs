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

        public decimal Pay(IMoney iMoney, int numberOfMoney, string productName)
        {
            ContainableItem containableItem = ProductDepot.GetProductByName(productName);
            if (_internalAccountant.IsEnoughMoney(containableItem,
                _internalAccountant.TotalAmount(iMoney, numberOfMoney)))
            {
                Notify(containableItem);
                if (iMoney is Coin)
                {
                    return _internalAccountant.CalculateChange(containableItem.Product.Price,
                        _internalAccountant.TotalAmount(iMoney, numberOfMoney));
                }
                if (iMoney is CreditCard)
                {
                    iMoney.Amount -= containableItem.Product.Price;
                    return 0;
                }
                if (iMoney is Banknote)
                    return 0;
            }
            throw new ArgumentException("You need to enter more money.");
        }
    }
}
