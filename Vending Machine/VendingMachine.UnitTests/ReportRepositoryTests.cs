using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using VendingMachine.Project.Exceptions;
using VendingMachine.Project.ReportsLogic;

namespace VendingMachine.UnitTests
{
    [TestClass]
    public class ReportRepositoryTests
    {
        private Sale _sale;
        private SalesDatabase _salesDatabase;
        private ReportRepository _reportRepository;
        private Report _report;

        [TestInitialize]
        public void InitializeConstructors()
        {
            _sale = new Sale("MilkyWay", 2.35m, DateTime.Now);
            _salesDatabase = SalesDatabase.Instance;
            _reportRepository = new ReportRepository();
            _report = new Report("reportName.csv", _salesDatabase.Sales);
        }

        [TestCleanup]
        public void CleanSalesDatabase()
        {
            foreach (var sale in _salesDatabase.Sales)
                _salesDatabase.RemoveSale(sale);
        }

        [TestMethod]
        public void AddReport_AddOneReport_CountReturnOne()
        {
            _reportRepository.AddReport(_report);

            Assert.AreEqual(1, _reportRepository.Reports.Count);
        }

        [TestMethod]
        public void DeleteReport_DeleteOneReportWhenReportRepositoryIsEmpty_ThrowReportNotFoundException()
        {
            Assert.ThrowsException<ReportNotFoundException>(() => _reportRepository.DeleteReport("reportName.csv"));
        }

        [TestMethod]
        public void DeleteReport_DeleteOneReportSuccessfully_CountReturnZero()
        {
            _reportRepository.AddReport(_report);
            _reportRepository.DeleteReport("reportName.csv");

            Assert.AreEqual(0, _reportRepository.Reports.Count);
        }
    }
}
