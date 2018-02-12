using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VendingMachine.Project
{
    class ProductPosition
    {
        private int _row;
        private int _column;
        public ProductPosition(int row, int column)
        {
            _row = row;
            _column = column;
        }
    }
}
