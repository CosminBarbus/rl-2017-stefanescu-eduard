namespace VendingMachine.Project
{
    public interface IDispenser
    {
        void Add(ProductBand productBand);
        void Dispense(ContainableItem containableItem);
    }
}
