namespace VendingMachine.Project.PaymentLogic.Banknotes
{
    public class OneRon : Banknote
    {
        private decimal _oneRon = 1;

        public override decimal Amount
        {
            get => _oneRon;
            set { }
        }
    }
}
