using System;

namespace VendingMachine.Project.ReportsLogic
{
    public class Sale
    {
        private string _productName;
        private decimal _productPrice;
        private readonly DateTime _sellingDates;

        public Sale(string productName, decimal productPrice, DateTime sellingDate)
        {
            _productName = productName;
            _productPrice = productPrice;
            _sellingDates = sellingDate;
        }

        public DateTime SellingDates => _sellingDates;
    }
}
