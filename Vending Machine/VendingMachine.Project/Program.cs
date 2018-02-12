using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VendingMachine.Project
{
    class Program
    {
        static void Main()
        {
            ProductBand pringlesBand = new ProductBand(new List<ContainableItem>());
            ProductCategory pringlesCategory = new ProductCategory(categoryName: "Snacks",
                                                                   description: "Snacks with salt");
            Product pringlesProduct = new Product(name: "Pringles",
                                                  price: 7.59,
                                                  category: pringlesCategory);
            ProductPosition pringlesPosition = new ProductPosition(2, 5);
            ContainableItem pringlesItem = new ContainableItem(productPosition: pringlesPosition,
                                                               size: 3,
                                                               product: pringlesProduct);

            pringlesBand.Add(pringlesItem);
            pringlesBand.Remove(pringlesItem);
            pringlesBand.Count();
            ContainableItem pringles = pringlesBand.GetFirstItem();
        }
    }
}
