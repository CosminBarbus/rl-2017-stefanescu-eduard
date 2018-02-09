namespace VendingMachine.Project.Banknotes
{
    public class TenRon : Banknote
    {
        private decimal _tenRon = 10;

        public override decimal Amount
        {
            get { return _tenRon; }
            set { }
        }
    }
}
