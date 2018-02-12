namespace VendingMachine.Project
{
    public abstract class Banknote : IPayment
    {
        public abstract decimal Amount { get; set; }
        public decimal GetChange()
        {
            throw new System.NotImplementedException();
        }
    }
}
