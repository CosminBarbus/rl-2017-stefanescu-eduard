namespace VendingMachine.Project
{
    public abstract class Coin : IMoney
    {
        public abstract decimal Amount { get; set; }
    }
}
