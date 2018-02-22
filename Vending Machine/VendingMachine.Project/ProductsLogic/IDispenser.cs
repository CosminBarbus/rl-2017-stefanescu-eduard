using VendingMachine.Project.ProductsLogic;

namespace VendingMachine.Project.Interfaces
{
    public interface IDispenser
    {
        void Dispense(ContainableItem containableItem);
    }
}
