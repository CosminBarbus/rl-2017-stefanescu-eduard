using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VendingMachine.Project
{
    class CreateProducts
    {
        public static ContainableItem CreatePringlesProduct()
        {
            ProductBand pringlesBand = new ProductBand(new List<ContainableItem>());
            ProductCategory pringlesCategory = new ProductCategory(categoryName: "Snacks",
                                                                   description: "Snacks with salt");
            Product pringlesProduct = new Product(name: "Pringles",
                                                  price: 7.59,
                                                  category: pringlesCategory);
            ProductPosition pringlesPosition = new ProductPosition(row: 2,
                                                                   column: 5);
            ContainableItem pringlesItem = new ContainableItem(productPosition: pringlesPosition,
                                                               size: 3,
                                                               product: pringlesProduct);
            return pringlesItem;
        }
        public static ContainableItem CreateSnickersProduct()
        {
            ProductBand snickersBand = new ProductBand(new List<ContainableItem>());
            ProductCategory snickersCategory = new ProductCategory(categoryName: "Chocolate",
                                                                   description: "Chocolate with caramel");
            Product snickersProduct = new Product(name: "Snickers",
                                                  price: 2.55,
                                                  category: snickersCategory);
            ProductPosition snickersPosition = new ProductPosition(row: 1,
                                                                   column: 1);
            ContainableItem snickersItem = new ContainableItem(productPosition: snickersPosition,
                                                               size: 2,
                                                               product: snickersProduct);
            return snickersItem;
        }
        public static ContainableItem CreateTwixProduct()
        {
            ProductBand twixBand = new ProductBand(new List<ContainableItem>());
            ProductCategory twixCategory = new ProductCategory(categoryName: "Chocolate",
                                                                   description: "Two bars of chocolate");
            Product twixProduct = new Product(name: "Twix",
                                                  price: 3.05,
                                                  category: twixCategory);
            ProductPosition twixPosition = new ProductPosition(row: 1,
                                                               column: 7);
            ContainableItem twixItem = new ContainableItem(productPosition: twixPosition,
                                                               size: 2,
                                                               product: twixProduct);
            return twixItem;
        }
    }
}
