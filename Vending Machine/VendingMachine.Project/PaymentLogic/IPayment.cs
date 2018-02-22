namespace VendingMachine.Project.PaymentLogic
{
    public interface IPayment
    {
        decimal Amount { get; set; }
        bool IsChangeable { get; }
    }
}
