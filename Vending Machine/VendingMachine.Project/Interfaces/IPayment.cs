namespace VendingMachine.Project.Interfaces
{
    public interface IPayment
    {
        decimal Amount { get; set; }
        bool IsChangeable { get; }
    }
}
