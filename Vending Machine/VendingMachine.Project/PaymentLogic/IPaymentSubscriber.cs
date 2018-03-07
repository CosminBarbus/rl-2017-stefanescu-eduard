using VendingMachine.Project.ProductsLogic;

namespace VendingMachine.Project.PaymentLogic
{
    public interface IPaymentSubscriber
    {
        void OnPay(ContainableItem containableItem);
    }
}
