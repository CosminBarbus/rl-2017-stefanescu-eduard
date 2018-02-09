using System;
using System.Collections.Generic;

namespace VendingMachine.Project
{
    public class PaymentTerminal
    {
       private List<IPaymentSubscriber> _subscribers;
        

        public PaymentTerminal()
        {
            _subscribers = new List<IPaymentSubscriber>();
        }

        public void Subscribe(IPaymentSubscriber subscriber)
        {
            _subscribers.Add(subscriber);
        }

        public void Unsubscribe(IPaymentSubscriber subscriber)
        {
            _subscribers.Remove(subscriber);
        }

        private void Notify(string productName)
        {
            foreach (IPaymentSubscriber paymentSubscriber in _subscribers)
            {
                paymentSubscriber.DispenseProduct(productName);
            }

            Console.WriteLine("");
        }

        public decimal Pay(IMoney iMoney, int numberOfMoney, string productName)
        {
            var change = CalculateChange(productName);

            if (IsEnoughMoney(containableItem))
            {
                Notify(containableItem.Product.Name);
            }

            return change;
        }

        private bool IsEnoughMoney(ContainableItem containableItem)
        {
            return CalculateTotalAmount() >= containableItem.Product.Price;
        }

        private decimal CalculateChange(string productName)
        {
            var totalAmount = CalculateTotalAmount();

            decimal result;
            if (totalAmount < containableItem.Product.Price)
            {
                result = totalAmount;
            }
            else
            {
                result = Math.Floor((totalAmount - containableItem.Product.Price) * 100 + 0.5m) / 100;
            }

            return result;
        }

        private decimal CalculateTotalAmount(IMoney iMoney, int numberOfMoney)
        {
            decimal totalAmount = 0;
            if (iMoney is Banknote || iMoney is Coin)
                totalAmount = iMoney.Amount * numberOfMoney;
            else if (iMoney is CreditCard)
                totalAmount = iMoney.Amount;
            return totalAmount;
        }

        public void Pay(ProductBand pringlesBand, string productName)
        {
            throw new NotImplementedException();
        }
    }

    public interface IPaymentSubscriber
    {
        void DispenseProduct(string productName);
    }
}
