using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductsStorage
{
    class ProductCategory
    {
        private string categoryName;
        private string description;

        public ProductCategory(string _categoryName, string _description)
        {
            categoryName = _categoryName;
            description = _description;
        }
    }
}
