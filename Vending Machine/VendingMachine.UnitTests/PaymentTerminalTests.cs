using Microsoft.VisualStudio.TestTools.UnitTesting;
using VendingMachine.Project.Exceptions;
using VendingMachine.Project.PaymentLogic;
using VendingMachine.Project.PaymentLogic.Banknotes;
using VendingMachine.Project.PaymentLogic.Coins;
using VendingMachine.Project.ProductsLogic;
using VendingMachine.Project.ReportsLogic;

namespace VendingMachine.UnitTests
{
    [TestClass]
    public class PaymentTerminalTests
    {
        private ContainableItem _twixItem;
        private ProductBand _twixBand;
        private PaymentTerminal _paymentTerminal;
        private Dispenser _dispenser;
        private SalesDatabase _salesDatabase;

        [TestInitialize]
        public void InitializeConstructorsAndMethods()
        {
            _paymentTerminal = new PaymentTerminal();
            _dispenser = new Dispenser();

            _twixItem = ProductFactory.CreateTwixProduct();
            _twixBand = ProductBand.Instance;
            _salesDatabase = SalesDatabase.Instance;

            _paymentTerminal.Subscribe(_dispenser);
        }

        [TestCleanup]
        public void CleanupConstructors()
        {
            foreach (var product in _twixBand.Products)
                _twixBand.Remove(product);
            foreach (var sale in _salesDatabase.Sales)
                _salesDatabase.RemoveSale(sale);
        }

        [TestMethod]
        public void Pay_PayForOneTwixWithFiveRonBanknote_Successfully()
        {
            var fiveRon = new FiveRon();

            _twixBand.Add(_twixItem);
            _paymentTerminal.Pay(fiveRon, 1, "Twix");

            Assert.AreEqual(0, ProductBand.Instance.Count());
        }

        [TestMethod]
        public void Pay_PayForOneTwixWithInsufficientMoney_ThrowInsufficientMoneyException()
        {
            var oneRon = new OneRon();

            _twixBand.Add(_twixItem);

            Assert.ThrowsException<InvalidTransaction>(() => _paymentTerminal.Pay(oneRon, 1, "Twix"));
        }

        [TestMethod]
        public void Pay_PayWithForOneTwixWithBanknote_PayReturnZero()
        {
            var fiveRon = new FiveRon();

            _twixBand.Add(_twixItem);
            var change = _paymentTerminal.Pay(fiveRon, 1, "Twix");

            Assert.IsTrue(change == 0);
        }

        [TestMethod]
        public void Pay_PayForOneTwixWithExactAmountOfCoins_Successfully()
        {
            var fiftyBani = new FiftyBani();

            _twixBand.Add(_twixItem);
            var change = _paymentTerminal.Pay(fiftyBani, 6, "Twix");

            Assert.IsTrue(change == 0);
        }

        [TestMethod]
        public void Pay_PayWithCoins_PaymentTerminalGiveBackChange()
        {
            var tenBani = new TenBani();

            _twixBand.Add(_twixItem);
            var change = _paymentTerminal.Pay(tenBani, 35, "Twix");

            Assert.IsTrue(change > 0);
        }

        [TestMethod]
        public void Pay_PayForOneTwixWithCreditCard_ThrowCardNotFoundException()
        {
            var creditCard = new CreditCard("6331101999990016");

            _twixBand.Add(_twixItem);

            Assert.ThrowsException<CardNotFoundException>(() => _paymentTerminal.Pay(creditCard, 1, "Twix"));
        }

        [TestMethod]
        public void Pay_PayForOneTwixWithCreditCard_Succesfully()
        {
            var masterCard = new CreditCard("5105105105105100");

            _twixBand.Add(_twixItem);
            _paymentTerminal.Pay(masterCard, 1, "Twix");

            Assert.AreEqual(0, _twixBand.Count());
        }
    }
}
