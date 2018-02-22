﻿using VendingMachine.Project.Exceptions;

namespace VendingMachine.Project.PaymentLogic
{
    public class CreditCard : IPayment
    {
        private readonly string _creditCardNumber;

        public CreditCard(string creditCardNumber)
        {
            if (IsCreditCardValid(creditCardNumber))
                _creditCardNumber = creditCardNumber;
            else
                throw new CardNotValidException();
        }

        private bool IsCreditCardValid(string creditCardNumber)
        {
            // Luhn Algorithm
            var totalSum = 0;
            for (var cardNumberIndex = 0; cardNumberIndex < creditCardNumber.Length; cardNumberIndex++)
            {
                if (cardNumberIndex % 2 != 0)
                    totalSum += creditCardNumber[cardNumberIndex] - '0';
                else
                {
                    var digitMultiplier = (creditCardNumber[cardNumberIndex] - '0') * 2;
                    if (digitMultiplier > 9)
                    {
                        var firstDigit = digitMultiplier / 10;
                        var secondDigit = digitMultiplier % 10;
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
            get => CreditCardDatabase.Instance.GetAccountBalance(_creditCardNumber);
            set => CreditCardDatabase.Instance.SetAccountBalance(_creditCardNumber, value);
        }

        public bool IsChangeable => false;
    }
}