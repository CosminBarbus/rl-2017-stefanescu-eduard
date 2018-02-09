using System;

namespace VendingMachine.Project
{
    class InternalAccountant
    {
        public decimal TotalAmount(IPayment iPayment, int numberOfMoney)
        {
            decimal totalAmount = 0;
            if (iPayment is Banknote || iPayment is Coin)
                totalAmount = iPayment.Amount * numberOfMoney;
            else if (iPayment is CreditCard)
                totalAmount = iPayment.Amount;
            return totalAmount;
        }

        public decimal CalculateChange(decimal productPrice, IPayment payment, int numberOfMoney)
        {
            var totalAmount = TotalAmount(payment, numberOfMoney);
            if (totalAmount > productPrice)
                return Math.Floor((totalAmount - productPrice) * 100 + 0.5m) / 100;
            return 0;
        }

        public bool IsEnoughMoney(ContainableItem containableItem, decimal totalAmount)
        {
            if (containableItem.Product.Price <= totalAmount)
                return true;
            return false;
        }

        
    }
}
