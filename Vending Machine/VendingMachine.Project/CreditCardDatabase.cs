using VendingMachine.Project.Exceptions;

namespace VendingMachine.Project
{
    public class CreditCardDatabase
    {
        private decimal _creditCardAmount;
        private string _creditCreditCardNumber;
        private static readonly CreditCardDatabase[] _creditCards =
        {
            new CreditCardDatabase("30569309025904", 1000),
            new CreditCardDatabase("38520000023237", 250),
            new CreditCardDatabase("6011111111111117", 50),
            new CreditCardDatabase("6011000990139424", 7590.1m),
            new CreditCardDatabase("3530111333300000", 3555),
            new CreditCardDatabase("3566002020360505", 550),
            new CreditCardDatabase("5555555555554444", 12.5m),
            new CreditCardDatabase("5105105105105100", 11100),
            new CreditCardDatabase("4111111111111111", 1),
            new CreditCardDatabase("4012888888881881", 25700)
        };

        private CreditCardDatabase(string creditCardNumber, decimal creditCardAmount)
        {
            _creditCreditCardNumber = creditCardNumber;
            _creditCardAmount = creditCardAmount;
        }

        public static decimal GetAccountBalance(string creditCardNumber)
        {
            foreach (var creditCard in _creditCards)
            {
                    if (creditCard._creditCreditCardNumber == creditCardNumber)
                        return creditCard._creditCardAmount;
            }

            throw new CardNotFoundException();
        }

        public static void SetAccountBalance(string creditCardNumber, decimal amount)
        {
            foreach (CreditCardDatabase creditCard in _creditCards)
            {
                if (creditCard._creditCreditCardNumber == creditCardNumber)
                    creditCard._creditCardAmount = amount;
            }
        }
    }
}
