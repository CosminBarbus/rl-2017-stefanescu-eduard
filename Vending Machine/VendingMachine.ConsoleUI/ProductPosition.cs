using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VendingMachine.ConsoleUI
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

        public int Row => _row;

        public int Column => _column;
    }
}
