namespace VendingMachine.Project.ProductsLogic
{
    public class ContainableItem
    {
        private int _size;
        private Product _product;
        private ProductPosition _productPosition;

        public ContainableItem() { }

        public ContainableItem(ProductPosition productPosition, int size, Product product)
        {
            _productPosition = productPosition;
            _size = size;
            _product = product;
        }

        public int Size => _size;

        public Product Product => _product;

        public ProductPosition Position => _productPosition;
    }
}
