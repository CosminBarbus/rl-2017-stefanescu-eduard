using System;
using VendingMachine.Project.ProductsLogic;

namespace VendingMachine.Project.PaymentLogic
{
    class InternalAccountant
    {
        public decimal TotalAmount(IPayment payment, int numberOfMoney)
        {
            return payment.Amount * numberOfMoney;
        }

        public decimal CalculateChange(decimal productPrice, decimal totalAmount)
        {
            return Math.Floor((totalAmount - productPrice) * 100 + 0.5m) / 100;
        }

        public bool IsEnoughMoney(ContainableItem containableItem, decimal totalAmount)
        {
            if (containableItem.Product.Price <= totalAmount)
                return true;
            return false;
        }


    }
}
