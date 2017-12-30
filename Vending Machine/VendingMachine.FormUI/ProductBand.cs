using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VendingMachine.FormUI
{
    public class ProductBand
    {
        private List<ContainableItem> _products;
        private int _bandSize = 20;

        public List<ContainableItem> GetProductsList => _products;

        public ProductBand(List<ContainableItem> products)
        {
            _products = products;
        }

        public void AddManyItems(ContainableItem containableItem, int quantity)
        {
            for (int item = 0; item < quantity; item++)
            {
                if (_bandSize > 0 && _bandSize >= containableItem.Size)
                {
                    _products.Add(containableItem);
                    _bandSize -= containableItem.Size;
                }
                else
                {
                    string notificationMessage = "Band is full! It contains " +
                                                  _products.Count + " " +
                                                  containableItem.GetProduct.Name +
                                                  "!\nYou can't add any items!";
                    MessageBox.Show(notificationMessage, "Band is full", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    break;
                }
            }
        }

        public void Remove(ContainableItem containableItem)
        {
            if (_products.Count > 0)
            {
                _products.Remove(containableItem);
                _bandSize += containableItem.Size;
            }
        }

        public int Count() => _products.Count();

        public ContainableItem GetFirstItem()
        {
            ContainableItem emptyProduct = new ContainableItem();
            if (_products.Count > 0)
                return _products[0];
            return emptyProduct;
        }
    }
}
