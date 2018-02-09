namespace VendingMachine.Project.Coins
{
    public class TenBani : Coin
    {
        private decimal _tenBani = 0.1m;

        public override decimal Amount
        {
            get { return _tenBani; }
            set { }
        }
    }
}
