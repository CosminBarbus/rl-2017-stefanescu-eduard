using System;
using VendingMachine.Project.PaymentLogic;
using VendingMachine.Project.ProductsLogic;

namespace VendingMachine.Project.ReportsLogic
{
    public class Sale : IPaymentSubscriber
    {
        private readonly ContainableItem _containableItem;
        private readonly DateTime _sellingDates;

        public Sale() { }

        private Sale(ContainableItem containableItem)
        {
            _containableItem = containableItem;
            _sellingDates = DateTime.Now;
        }

        public void OnPay(ContainableItem containableItem)
        {
            SalesDatabase.Instance.AddSale(new Sale(containableItem));
        }

        public ContainableItem ContainableItem => _containableItem;

        public DateTime SellingDates => _sellingDates;
    }
}
