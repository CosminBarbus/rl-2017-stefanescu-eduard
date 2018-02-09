using VendingMachine.Project.Exceptions;

namespace VendingMachine.Project
{
    public class CreditCard : IPayment
    {
        private string _creditCreditCardNumber;

        public CreditCard(string creditCardNumber)
        {
            if (IsCreditCardValid(creditCardNumber))
            {
                _creditCreditCardNumber = creditCardNumber;
            }
            else
                throw new CardNotValidException();
        }

        private bool IsCreditCardValid(string creditCardNumber)
        {
            // Luhn Algorithm
            int totalSum = 0;
            for (int cardNumberIndex = 0; cardNumberIndex < creditCardNumber.Length; cardNumberIndex++)
            {
                if (cardNumberIndex % 2 != 0)
                    totalSum += creditCardNumber[cardNumberIndex] - '0';
                else
                {
                    int digitMultiplier = (creditCardNumber[cardNumberIndex] - '0') * 2;
                    if (digitMultiplier > 9)
                    {
                        int firstDigit = digitMultiplier / 10;
                        int secondDigit = digitMultiplier % 10;
                        totalSum += firstDigit + secondDigit;
                    }
                    else
                        totalSum += digitMultiplier;
                }
            }
            if (totalSum != 0 && totalSum % 10 == 0)
                return true;
            return false;
        }

        public decimal Amount
        {
            get => CreditCardDatabase.GetAccountBalance(_creditCreditCardNumber);
            set => CreditCardDatabase.SetAccountBalance(_creditCreditCardNumber, value);
        }

        public decimal GetChange()
        {
            throw new System.NotImplementedException();
        }
    }
}
