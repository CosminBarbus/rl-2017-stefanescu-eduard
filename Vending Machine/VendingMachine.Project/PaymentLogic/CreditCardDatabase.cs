using VendingMachine.Project.Exceptions;

namespace VendingMachine.Project.PaymentLogic
{
    public class CreditCardDatabase
    {
        private decimal _creditCardAmount;
        private readonly string _creditCreditCardNumber;
        private static CreditCardDatabase _instanceCardDatabase;
        private static CreditCardDatabase[] _creditCards;
        private static readonly object SynLock = new object();

        private CreditCardDatabase()
        {
            _creditCards = new[]
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
        }

        public static CreditCardDatabase Instance
        {
            get
            {
                if (_instanceCardDatabase == null)
                    lock (SynLock)
                        if (_instanceCardDatabase == null)
                            _instanceCardDatabase = new CreditCardDatabase();

                return _instanceCardDatabase;
            }
        }

        private CreditCardDatabase(string creditCardNumber, decimal creditCardAmount)
        {
            _creditCreditCardNumber = creditCardNumber;
            _creditCardAmount = creditCardAmount;
        }

        public decimal GetAccountBalance(string creditCardNumber)
        {
            foreach (var creditCard in _creditCards)
                if (creditCard._creditCreditCardNumber == creditCardNumber)
                    return creditCard._creditCardAmount;

            throw new CardNotFoundException();
        }

        public void SetAccountBalance(string creditCardNumber, decimal amount)
        {
            foreach (CreditCardDatabase creditCard in _creditCards)
                if (creditCard._creditCreditCardNumber == creditCardNumber)
                    creditCard._creditCardAmount = amount;
        }
    }
}
