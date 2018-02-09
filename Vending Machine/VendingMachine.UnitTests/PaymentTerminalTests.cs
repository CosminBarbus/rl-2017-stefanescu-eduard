using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using VendingMachine.Project;
using VendingMachine.Project.Banknotes;
using VendingMachine.Project.Coins;
using VendingMachine.Project.Exceptions;

namespace VendingMachine.UnitTests
{
    [TestClass]
    public class PaymentTerminalTests
    {
        private ContainableItem twixItem;
        private ProductBand twixBand;
        private PaymentTerminal paymentTerminal;
        private Dispenser dispenser;

        [TestInitialize]
        public void InitializeConstructors()
        {
            twixBand = new ProductBand();
            paymentTerminal = new PaymentTerminal();
            dispenser = new Dispenser();

            twixItem = ProductFactory.CreateTwixProduct();
            twixBand.Add(twixItem);
            ProductBand.Instance().Add(twixItem);
           
            paymentTerminal.Attach(dispenser);
        }

        [TestMethod]
        public void Pay_PayForOneTwixWithOneFiveRonBanknote_Successfully()
        {            
            var fiveRon = new FiveRon();

            paymentTerminal.Pay(fiveRon, 1, "Twix");

            Assert.AreEqual(0, twixBand.Count());
        }

        [TestMethod]
        public void Pay_PayForOneTwixWithInsufficientMoney_ThrowException()
        {
            var oneRon = new OneRon();

            Assert.ThrowsException<ArgumentException>(() => paymentTerminal.Pay(oneRon, 1, "Twix"));
        }

        [TestMethod]
        public void Pay_PayForOneTwixWithExactAmountOfMoney_Successfully()
        {
            var fiftyBani = new FiftyBani();

            decimal change = paymentTerminal.Pay(fiftyBani, 6, "Twix");

            Assert.IsTrue(change == 0);
        }

        [TestMethod]
        public void Pay_PayForOneTwixWithCreditCard_Succesfully()
        {
            var masterCard = new CreditCard("5105105105105100");

            decimal change = paymentTerminal.Pay(masterCard, 1, "Twix");

            Assert.AreEqual(0, change);
        }

        [TestMethod]
        public void Pay_PayForOneTwixWithCreditCard_ThrowCardNotFoundException()
        {
            var creditCard = new CreditCard("6331101999990016");

            Assert.ThrowsException<CardNotFoundException>(() => paymentTerminal.Pay(creditCard, 1, "Twix"));
        }
    }
}
