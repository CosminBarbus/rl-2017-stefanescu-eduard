using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using VendingMachine.Project.Exceptions;
using VendingMachine.Project.PaymentLogic;
using VendingMachine.Project.PaymentLogic.Banknotes;
using VendingMachine.Project.ProductsLogic;
using VendingMachine.Project.ReportsLogic;

namespace VendingMachine.UnitTests
{
    [TestClass]
    public class SalesDatabaseTests
    {
        private ContainableItem _snickersItem;
        private ProductBand _snickersBand;
        private PaymentTerminal _paymentTerminal;
        private Dispenser _dispenser;
        private IPayment _fiveRon;
        private SalesDatabase _salesDatabase;
        private Sale _sale;

        [TestInitialize]
        public void InitializeConstructorsAndMethods()
        {
            _snickersItem = ProductFactory.CreateSnickersProduct();
            _snickersBand = ProductBand.Instance;
            _dispenser = new Dispenser();
            _paymentTerminal = new PaymentTerminal();
            _fiveRon = new FiveRon();
            _salesDatabase = SalesDatabase.Instance;
            _sale = new Sale();

            _snickersBand.Add(_snickersItem);
            _paymentTerminal.Subscribe(_dispenser);
            _paymentTerminal.Subscribe(_sale);
        }

        [TestCleanup]
        public void CleanSalesDatabase()
        {
            foreach (var product in _snickersBand.Products)
                _snickersBand.Remove(product);
            foreach (var sale in _salesDatabase.Sales)
                _salesDatabase.RemoveSale(sale);
        }

        [TestMethod]
        public void AddSale_AddOneSale_CountReturnOne()
        {
            _paymentTerminal.Pay(_fiveRon, 1, "Snickers");

            Assert.AreEqual(1, _salesDatabase.Sales.Count);
        }

        [TestMethod]
        public void RemoveSale_RemoveOneSale_CountReturnZero()
        {
            _paymentTerminal.Pay(_fiveRon, 1, "Snickers");
            var startDate = new DateTime(2018, 03, 01);
            var endDate = new DateTime(2018, 03, 31);
            var sales = _salesDatabase.GetSalesByDate(startDate, endDate);
            foreach (var sale in sales)
                _salesDatabase.RemoveSale(sale);

            Assert.AreEqual(0, _salesDatabase.Sales.Count);
        }

        [TestMethod]
        public void RemoveSale_GetOneSaleWhenNoSaleWasMade_ThrowSaleNotFoundException()
        {
            var startDate = new DateTime(2018, 02, 01);
            var endDate = new DateTime(2018, 02, 28);
            Assert.ThrowsException<SalesNotFoundException>(() => _salesDatabase.GetSalesByDate(startDate, endDate));
        }

        [TestMethod]
        public void GetSalesByDate_GetSalesFromPreviousMonth_ThrowSalesNotFoundException()
        {
            var date = DateTime.Now;
            var startDate = new DateTime(date.Year, date.AddMonths(-1).Month, 1);
            var endDate = startDate.AddMonths(1).AddDays(-1);

            Assert.ThrowsException<SalesNotFoundException>(() => _salesDatabase.GetSalesByDate(startDate, endDate));
        }

        [TestMethod]
        public void GetSalesByDate_GetSalesFromThisMonth_Succesfully()
        {
            _paymentTerminal.Pay(_fiveRon, 1, "Snickers");

            var date = DateTime.Now;
            var startDate = new DateTime(date.Year, date.Month, 1);
            var endDate = startDate.AddMonths(1).AddDays(-1);
            var previousMonthSales = _salesDatabase.GetSalesByDate(startDate, endDate);

            Assert.IsTrue(previousMonthSales.Count > 0);
        }
    }
}
