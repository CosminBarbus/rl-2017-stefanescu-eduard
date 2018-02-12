namespace VendingMachine.Project.Banknotes
{
    public class OneRon : Banknote
    {
        private decimal _oneRon = 1;

        public override decimal Amount
        {
            get { return _oneRon; }
            set { }
        }
    }
}
