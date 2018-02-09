namespace VendingMachine.Project
{
    public interface IPayment
    {
        decimal Amount { get; set; }
        decimal GetChange();
    }
}
