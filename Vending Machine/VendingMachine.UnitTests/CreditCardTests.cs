using Microsoft.VisualStudio.TestTools.UnitTesting;
using VendingMachine.Project.Exceptions;
using VendingMachine.Project.PaymentLogic;

namespace VendingMachine.UnitTests
{
    [TestClass]
    public class CreditCardTests
    {
        [TestMethod]
        public void CreditCard_EnterAnInvalidCreditCard_ThrowCardNotValidException()
        {
            Assert.ThrowsException<CardNotValidException>(() => new CreditCard("01123581321345589144233"));
        }

        [TestMethod]
        public void CreditCard_EnterAValidCreditCard_Successfully()
        {
            var creditCardNumber = "5105105105105100";

            try
            {
                var masterCard = new CreditCard(creditCardNumber);
            }
            catch (CardNotValidException)
            {
                Assert.Fail();
            }
        }
    }
}
