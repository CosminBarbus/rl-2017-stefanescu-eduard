namespace VendingMachine.Project.Coins
{
    public class FiftyBani : Coin
    {
        private decimal _fiftyBani = 0.5m;

        public override decimal Amount
        {
            get { return _fiftyBani; }
            set { }
        }
    }
}
