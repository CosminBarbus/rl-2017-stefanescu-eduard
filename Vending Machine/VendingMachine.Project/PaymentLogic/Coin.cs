using VendingMachine.Project.Interfaces;

namespace VendingMachine.Project.PaymentLogic
{
    public abstract class Coin : IPayment
    {
        public abstract decimal Amount { get; set; }
        public bool IsChangeable => true;
    }
}
