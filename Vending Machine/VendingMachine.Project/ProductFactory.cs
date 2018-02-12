namespace VendingMachine.Project
{
    public static class ProductFactory
    {
        public static ContainableItem CreatePringlesProduct()
        {
            var pringlesCategory = new ProductCategory(categoryName: "Snacks",
                                                       description: "Snacks with salt");
            var pringlesProduct = new Product(name: "Pringles",
                                              price: 7.9m,
                                              category: pringlesCategory);
            var pringlesPosition = new ProductPosition(row: 2,
                                                       column: 5);
            var pringlesItem = new ContainableItem(productPosition: pringlesPosition,
                                                   size: 3,
                                                   product: pringlesProduct);

            return pringlesItem;
        }
        public static ContainableItem CreateSnickersProduct()
        {
            var snickersCategory = new ProductCategory(categoryName: "Chocolate",
                                                       description: "Chocolate with caramel");
            var snickersProduct = new Product(name: "Snickers",
                                              price: 2.5m,
                                              category: snickersCategory);
            var snickersPosition = new ProductPosition(row: 1,
                                                       column: 1);
            var snickersItem = new ContainableItem(productPosition: snickersPosition,
                                                   size: 2,
                                                   product: snickersProduct);

            return snickersItem;
        }
        public static ContainableItem CreateTwixProduct()
        {
            var twixCategory = new ProductCategory(categoryName: "Chocolate",
                                                   description: "Two bars of chocolate");
            var twixProduct = new Product(name: "Twix",
                                          price: 3,
                                          category: twixCategory);
            var twixPosition = new ProductPosition(row: 1,
                                                   column: 7);
            var twixItem = new ContainableItem(productPosition: twixPosition,
                                               size: 2,
                                               product: twixProduct);
            return twixItem;
        }

        public static ContainableItem CreateSkittlesProduct()
        {
            var skittlesCategory = new ProductCategory(categoryName: "Biscuits",
                                                       description: "Biscuits with cream");
            var skittlesProduct = new Product(name: "Oreo",
                                              price: 5.59m,
                                              category: skittlesCategory);
            var skittlesPosition = new ProductPosition(row: 2,
                                                       column: 5);
            var skittlesItem = new ContainableItem(productPosition: skittlesPosition,
                                                   size: 2,
                                                   product: skittlesProduct);

            return skittlesItem;
        }

        public static ContainableItem CreateOreoItem()
        {
            var oreoCategory = new ProductCategory(categoryName: "Biscuits",
                                                   description: "Biscuits with cream");
            var oreoProduct = new Product(name: "Oreo",
                                          price: 5.59m,
                                          category: oreoCategory);
            var oreoPosition = new ProductPosition(row: 3,
                                                   column: 7);
            var oreoItem = new ContainableItem(productPosition: oreoPosition,
                                               size: 5,
                                               product: oreoProduct);

            return oreoItem;
        }
    }
}
