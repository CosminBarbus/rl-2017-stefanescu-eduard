namespace VendingMachine.Project.PaymentLogic.Banknotes
{
    public class FiveRon : Banknote
    {
        private decimal _fiveRon = 5;

        public override decimal Amount
        {
            get => _fiveRon;
            set { }
        }
    }
}
