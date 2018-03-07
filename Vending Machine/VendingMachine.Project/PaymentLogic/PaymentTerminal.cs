using System.Collections.Generic;
using VendingMachine.Project.Exceptions;
using VendingMachine.Project.ProductsLogic;

namespace VendingMachine.Project.PaymentLogic
{
    public class PaymentTerminal
    {
        private readonly IList<IPaymentSubscriber> _paymentSubscribers;
        private readonly InternalAccountant _internalAccountant;

        public PaymentTerminal()
        {
            _paymentSubscribers = new List<IPaymentSubscriber>();
            _internalAccountant = new InternalAccountant();
        }

        public void Subscribe(IPaymentSubscriber paymentSubscriber)
        {
            _paymentSubscribers.Add(paymentSubscriber);
        }

        public void Unsubscribe(IPaymentSubscriber paymentSubscriber)
        {
            _paymentSubscribers.Remove(paymentSubscriber);
        }

        private void Notify(ContainableItem containableItem)
        {
            foreach (var dispenser in _paymentSubscribers)
                dispenser.OnPay(containableItem);
        }

        public decimal Pay(IPayment payment, int numberOfMoney, string productName)
        {
            var containableItem = ProductBand.Instance.GetByName(productName);
            var totalAmount = _internalAccountant.TotalAmount(payment, numberOfMoney);

            if (!_internalAccountant.IsEnoughMoney(containableItem, totalAmount) || containableItem == null)
                throw new InvalidTransaction();

            Notify(containableItem);
            payment.Amount -= containableItem.Product.Price;

            return payment.IsChangeable
                ? _internalAccountant.CalculateChange(containableItem.Product.Price, totalAmount)
                : 0;
        }
    }
}
