namespace VendingMachine.Project.ProductsLogic
{
    public class ProductPosition
    {
        private int _row;
        private int _column;
        public ProductPosition(int row, int column)
        {
            _row = row;
            _column = column;
        }

        public int Row => _row;

        public int Column => _column;
    }
}
