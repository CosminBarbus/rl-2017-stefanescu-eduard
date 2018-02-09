using System;

namespace VendingMachine.Project
{
    class InternalAccountant
    {
        public decimal TotalAmount(IMoney iMoney, int numberOfMoney)
        {
            decimal totalAmount = 0;
            if (iMoney is Banknote || iMoney is Coin)
                totalAmount = iMoney.Amount * numberOfMoney;
            else if (iMoney is CreditCard)
                totalAmount = iMoney.Amount;
            return totalAmount;
        }

        public decimal CalculateChange(decimal productPrice, decimal totalAmount)
        {
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
