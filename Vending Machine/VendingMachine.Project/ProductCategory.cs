namespace VendingMachine.Project
{
    public class ProductCategory
    {
        private string _categoryName;
        private string _description;

        public ProductCategory(string categoryName, string description)
        {
            _categoryName = categoryName;
            _description = description;
        }

        public string CategoryName => _categoryName;

        public string Description => _description;
    }
}
