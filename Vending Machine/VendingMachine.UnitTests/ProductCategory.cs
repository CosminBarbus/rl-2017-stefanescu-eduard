using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VendingMachine.UnitTests
{
    class ProductCategory
    {
        readonly string _categoryName;
        readonly string _description;

        public ProductCategory(string categoryName, string description)
        {
            _categoryName = categoryName;
            _description = description;
        }
    }
}
