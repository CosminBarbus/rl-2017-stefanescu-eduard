using VendingMachine.Project.PaymentLogic;

namespace VendingMachine.Project.ProductsLogic
{
    public class Dispenser : IPaymentSubscriber
    {
        public void OnPay(ContainableItem containableItem)
        {
            ProductBand.Instance.Remove(containableItem);
        }
    }
}
