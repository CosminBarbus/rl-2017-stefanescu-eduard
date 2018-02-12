namespace VendingMachine.Project
{
    public class Product
    {
        private string _name;
        private decimal _price;
        private ProductCategory _category;

        public Product(string name, decimal price, ProductCategory category)
        {
            _name = name;
            _price = price;
            _category = category;
        }

        public string Name => _name;

        public decimal Price => _price;

        public ProductCategory Category => _category;
    }
}
