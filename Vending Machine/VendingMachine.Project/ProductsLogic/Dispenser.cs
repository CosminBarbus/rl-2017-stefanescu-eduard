using VendingMachine.Project.Interfaces;

namespace VendingMachine.Project.ProductsLogic
{
    public class Dispenser : IDispenser
    {
        public void Dispense(ContainableItem containableItem)
        {
            ProductBand.Instance.Remove(containableItem);
        }
    }
}
