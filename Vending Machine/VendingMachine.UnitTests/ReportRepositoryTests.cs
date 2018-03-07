using Microsoft.VisualStudio.TestTools.UnitTesting;
using VendingMachine.Project.Exceptions;
using VendingMachine.Project.PaymentLogic;
using VendingMachine.Project.PaymentLogic.Banknotes;
using VendingMachine.Project.ProductsLogic;
using VendingMachine.Project.ReportsLogic;

namespace VendingMachine.UnitTests
{
    [TestClass]
    public class ReportRepositoryTests
    {
        private ReportRepository _reportRepository;
        private Report _report;
        private ContainableItem _snickersItem;
        private ProductBand _snickersBand;
        private PaymentTerminal _paymentTerminal;
        private Dispenser _dispenser;
        private SalesDatabase _salesDatabase;
        private Sale _sale;
        private IPayment _fiveRon;

        [TestInitialize]
        public void InitializeConstructorsAndMethods()
        {
            _reportRepository = new ReportRepository();
            _snickersItem = ProductFactory.CreateSnickersProduct();
            _snickersBand = ProductBand.Instance;
            _dispenser = new Dispenser();
            _paymentTerminal = new PaymentTerminal();
            _salesDatabase = SalesDatabase.Instance;
            _sale = new Sale();
            _fiveRon = new FiveRon();

            _snickersBand.Add(_snickersItem);
            _paymentTerminal.Subscribe(_dispenser);
            _paymentTerminal.Subscribe(_sale);

            _paymentTerminal.Pay(_fiveRon, 1, "Snickers");
            _report = new Report("reportName.csv", _salesDatabase.Sales);
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
            Assert.AreEqual(0, _reportRepository.Reports.Count);
        }
    }
}
