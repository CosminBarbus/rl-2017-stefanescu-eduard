namespace VendingMachine.Project.PaymentLogic
{
    public abstract class Banknote : IPayment
    {
        public abstract decimal Amount { get; set; }
        public bool IsChangeable => false;
    }
}
