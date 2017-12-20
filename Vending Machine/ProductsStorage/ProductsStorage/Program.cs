using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductsStorage
{
    class Program
    {
        static void Main(string[] args)
        {
            ProductBand snickersBand = new ProductBand();
            snickersBand.Add();
            DisplayCount(snickersBand);
            snickersBand.Remove(3);
            DisplayCount(snickersBand);
            ContainableItem snickers = snickersBand.GetItem();

            Console.ReadKey();
        }

        public static void DisplayCount(ProductBand band)
        {
            if (band.Count() == 1)
                Console.WriteLine("Band has 1 product");
            else
                Console.WriteLine("Band has {0} products", band.Count());
        }
    }
}
