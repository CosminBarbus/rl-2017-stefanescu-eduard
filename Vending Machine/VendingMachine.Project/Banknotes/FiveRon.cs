namespace VendingMachine.Project.Banknotes
{
    public class FiveRon : Banknote
    {
        private decimal _fiveRon = 5;

        public override decimal Amount
        {
            get { return _fiveRon; }
            set { }
        }
    }
}
