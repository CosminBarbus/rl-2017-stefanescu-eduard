using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
            Console.WriteLine("\nName: {0}\nRow: {1}\nColumn: {2}\nSize: {3}\nPrice: {4}\nCategory name: {5}\nDescription: {6}",
                              containableItem.GetProduct.Name,
                              containableItem.GetPostion.Row,
                              containableItem.GetPostion.Column,
                              containableItem.Size,
                              containableItem.GetProduct.Price,
                              containableItem.GetProduct.Category.CategoryName,
                              containableItem.GetProduct.Category.Description);
        }
    }
}
