namespace VendingMachine.Project.PaymentLogic.Banknotes
{
    public class TenRon : Banknote
    {
        private decimal _tenRon = 10;

        public override decimal Amount
        {
            get => _tenRon;
            set { }
        }
    }
}
