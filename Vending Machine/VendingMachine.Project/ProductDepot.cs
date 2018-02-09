using System;
using System.Collections.Generic;

namespace VendingMachine.Project
{
    public static class ProductDepot
    {
        private static List<ContainableItem> productDepot;

        static ProductDepot()
        {
            productDepot = new List<ContainableItem>();
        }

        public static void AddProductInDepot(ContainableItem containableItem)
        {
            productDepot.Add(containableItem);
        }

        public static ContainableItem GetProductByName(string productName)
        {
            foreach (ContainableItem containableItem in productDepot)
                if (string.Equals(containableItem.Product.Name, productName, StringComparison.OrdinalIgnoreCase))
                    return containableItem;

            throw new ArgumentException("The product was not found in depot");
        }
    }
}
