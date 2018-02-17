namespace VendingMachine.Project.PaymentLogic.Coins
{
    public class FiftyBani : Coin
    {
        private decimal _fiftyBani = 0.5m;

        public override decimal Amount
        {
            get => _fiftyBani;
            set { }
        }
    }
}
