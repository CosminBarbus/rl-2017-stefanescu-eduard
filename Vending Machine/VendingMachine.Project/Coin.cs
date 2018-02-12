namespace VendingMachine.Project
{
    public abstract class Coin : IPayment
    {
        public abstract decimal Amount { get; set; }
        public decimal GetChange()
        {
            throw new System.NotImplementedException();
        }
    }
}
