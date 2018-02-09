using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VendingMachine.Project;

namespace VendingMachine.ConsoleUI
{
    class ProductOutput
    {
        public static void DisplayCount(ProductBand productBand)
        {
            if (productBand.Count() == 1)
                Console.WriteLine("Band contains 1 product.");
            else
                Console.WriteLine("Band contains {0} products.", productBand.Count());
        }

        public static void DisplayProduct(ContainableItem containableItem)
        {
            Console.WriteLine("Name: {0}\nRow: {1}\nColumn: {2}\nSize: {3}\nPrice: {4}\nCategory name: {5}\nDescription: {6}",
                              containableItem.Product.Name,
                              containableItem.Position.Row,
                              containableItem.Position.Column,
                              containableItem.Size,
                              containableItem.Product.Price,
                              containableItem.Product.Category.CategoryName,
                              containableItem.Product.Category.Description);
        }
    }
}
