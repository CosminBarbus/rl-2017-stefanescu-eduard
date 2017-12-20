using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vending_Machine
{
    class ProductBand
    {
        private List<ContainableItem> products = new List<ContainableItem>();
        int bandSize = 20;

        public void Add()
        {
            Console.Write("Enter the name of the product: ");
            string name = Console.ReadLine();

            Console.Write("Enter the row of {0} product: ", name);
            int row = Int32.Parse(Console.ReadLine());

            Console.Write("Enter the column of {0} product: ", name);
            int column = Int32.Parse(Console.ReadLine());

            Console.Write("Enter the size of {0} product: ", name);
            int size = Int32.Parse(Console.ReadLine());

            Console.Write("Enter the price of {0} product: ", name);
            double price = Double.Parse(Console.ReadLine());

            Console.Write("Enter the category name of {0} product: ", name);
            string categoryName = Console.ReadLine();

            Console.Write("Enter the description of {0} product: ", name);
            string description = Console.ReadLine();

            ProductCategory category = new ProductCategory(categoryName, description);
            ContainableItem item = new ContainableItem(name, price, category);
            item.SetPosition(row, column);
            item.Size = size;

            Console.Write("Enter how many {0} products you want to add: ", name);
            int numberOfProducts = Int32.Parse(Console.ReadLine());
            Console.WriteLine();

            for (int product = 0; product < numberOfProducts && bandSize > 0 && item.Size > 0; product++)
            {
                bandSize -= item.Size;
                products.Add(item);
            }
        }

        public void Remove(int numberOfItemsToRemove)
        {
            if (numberOfItemsToRemove > products.Count)
            {
                Console.WriteLine("Band has {0} items, will be removed only {0} items", products.Count);
                products.RemoveRange(0, products.Count);
            }
            else
                products.RemoveRange(0, numberOfItemsToRemove);
        }

        public int Count() => products.Count();

        public ContainableItem GetItem()
        {
            if (products.Count > 0)
                return products[0];
            throw new ArgumentException("Band is empty");
        }
    }
}
