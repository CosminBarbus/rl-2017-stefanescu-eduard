using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using VendingMachine.Project.Exceptions;
using VendingMachine.Project.ReportsLogic;

namespace VendingMachine.UnitTests
{
    [TestClass]
    public class SalesDatabaseTests
    {
        private SalesDatabase _salesDatabase;
        private Sale _sale;

        [TestInitialize]
        public void InitializeConstructors()
        {
            var date = new DateTime(2018, 01, 11);
            _salesDatabase = SalesDatabase.Instance;
            _sale = new Sale("KitKat", 3.57m, date);
        }

        [TestCleanup]
        public void CleanSalesDatabase()
        {
            foreach (var sale in _salesDatabase.Sales)
                _salesDatabase.RemoveSale(sale);
        }

        [TestMethod]
        public void AddSale_AddOneSale_CountReturnOne()
        {
            _salesDatabase.AddSale(_sale);

            Assert.AreEqual(1, _salesDatabase.Sales.Count);
        }

        [TestMethod]
        public void RemoveSale_RemoveOneSale_CountReturnZero()
        {
            _salesDatabase.AddSale(_sale);
            _salesDatabase.RemoveSale(_sale);

            Assert.AreEqual(0, _salesDatabase.Sales.Count);
        }

        [TestMethod]
        public void RemoveSale_RemoveOneSale_ThrowSaleNotFoundException()
        {
            Assert.ThrowsException<SalesNotFoundException>(() => _salesDatabase.RemoveSale(_sale));
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
        public void GetSalesByDate_GetSalesFromPreviousMonth_Succesfully()
        {
            _salesDatabase.AddSale(_sale);

            var date = DateTime.Now;
            var startDate = new DateTime(date.Year, date.AddMonths(-1).Month, 1);
            var endDate = startDate.AddMonths(1).AddDays(-1);
            var previousMonthSales = _salesDatabase.GetSalesByDate(startDate, endDate);

            Assert.IsTrue(previousMonthSales.Count > 0);
        }
    }
}
