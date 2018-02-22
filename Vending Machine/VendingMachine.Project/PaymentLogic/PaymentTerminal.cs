using System;
using System.Collections.Generic;
using VendingMachine.Project.Exceptions;
using VendingMachine.Project.Interfaces;
using VendingMachine.Project.ProductsLogic;
using VendingMachine.Project.ReportsLogic;

namespace VendingMachine.Project.PaymentLogic
{
    public class PaymentTerminal
    {
        private readonly IList<IDispenser> _dispensers;
        private readonly InternalAccountant _internalAccountant;

        public PaymentTerminal()
        {
            _dispensers = new List<IDispenser>();
            _internalAccountant = new InternalAccountant();
        }

        public void Subscribe(IDispenser dispenser)
        {
            _dispensers.Add(dispenser);
        }

        public void Unsubscribe(IDispenser iDispenser)
        {
            _dispensers.Remove(iDispenser);
        }

        private void Notify(ContainableItem containableItem)
        {
            foreach (var dispenser in _dispensers)
                dispenser.Dispense(containableItem);
        }

        public decimal Pay(IPayment payment, int numberOfMoney, string productName)
        {
            var containableItem = ProductBand.Instance.GetByName(productName);
            var totalAmount = _internalAccountant.TotalAmount(payment, numberOfMoney);

            if (!_internalAccountant.IsEnoughMoney(containableItem, totalAmount))
                throw new InsufficientMoneyException();

            var sale = new Sale(containableItem.Product.Name, containableItem.Product.Price, DateTime.Now);
            SalesDatabase.Instance.AddSale(sale);
            Notify(containableItem);
            payment.Amount -= containableItem.Product.Price;

            return payment.IsChangeable
                ? _internalAccountant.CalculateChange(containableItem.Product.Price, totalAmount)
                : 0;
        }
    }
}
