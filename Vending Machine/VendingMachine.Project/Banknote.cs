namespace VendingMachine.Project
{
    public abstract class Banknote : IMoney
    {
        public abstract decimal Amount { get; set; }
    }
}
