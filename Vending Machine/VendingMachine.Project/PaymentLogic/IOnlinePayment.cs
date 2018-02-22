namespace VendingMachine.Project.PaymentLogic
{
    public interface IOnlinePayment
    {
        decimal Amount { get; }
        string IdentificationNumber { get; }
    }
}
