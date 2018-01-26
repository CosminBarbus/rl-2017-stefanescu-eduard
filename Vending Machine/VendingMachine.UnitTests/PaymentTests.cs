using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using VendingMachine.UnitTests.Banknotes;
using VendingMachine.UnitTests.Coins;

namespace VendingMachine.UnitTests
{
    [TestClass]
    public class PaymentTests
    {
        private ProductCategory twixCategory;
        private Product twixProduct;
        private ProductPosition twixPosition;
        private ContainableItem twixItem;
        private ProductBand twixBand;
        private Payment payment;

        [TestInitialize]
        public void InitializeConstructors()
        {
            twixCategory = new ProductCategory("Chocolate", "Two bars of chocolate");
            twixProduct = new Product("Twix", 3.5, twixCategory);
            twixPosition = new ProductPosition(1, 3);
            twixItem = new ContainableItem(twixPosition, 2, twixProduct);
            twixBand = new ProductBand(new List<ContainableItem>());
        }

        [TestMethod]
        public void Pay_PayForOneTwixWithOneFiveRonBanknote_Successfully()
        {
            IMoney money = new FiveRon();
            payment = new Payment(money, 1);

            twixBand.Add(twixItem);
            double returnedValue = payment.Pay(twixBand, twixItem);

            Assert.IsTrue(returnedValue > 0);
        }

        [TestMethod]
        public void Pay_PayForOneTwixWithInsufficientMoney_ThrowException()
        {
            IMoney money = new OneRon();
            payment = new Payment(money, 1);

            twixBand.Add(twixItem);
            Assert.ThrowsException<InsufficientMemoryException>(() => payment.Pay(twixBand, twixItem));
        }

        [TestMethod]
        public void Pay_PayForOneTwixWithExactAmountOfMoney_Successfully()
        {
            IMoney money = new FiftyBani();
            payment = new Payment(money, 7);

            twixBand.Add(twixItem);
            double returnedValue = payment.Pay(twixBand, twixItem);

            Assert.IsTrue(returnedValue == 0);
        }
    }
}
