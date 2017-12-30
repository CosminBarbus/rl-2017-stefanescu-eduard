using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VendingMachine.FormUI
{
    public partial class fRemoveButton : Form
    {
        ContainableItem containableItem;
        List<ProductBand> bandList;

        public fRemoveButton()
        {
            InitializeComponent();
            uCAddButton uAddButton = new uCAddButton();
            // uAddButton.Parent = this;
        }

        public fRemoveButton(ContainableItem containableItem, List<ProductBand> bandList)
        {
            InitializeComponent();
            this.containableItem = containableItem;
            this.bandList = bandList;
        }

        public ContainableItem SetContainableItem
        {
            set => containableItem = value;
        }

        public List<ProductBand> SetBandList
        {
            set => bandList = value;
        }

        private void removeButton_Click(object sender, EventArgs e)
        {
            string name = tProductName.Text;
            foreach (ProductBand band in bandList)
            {
                if (band.GetProductsList.Count == 0)
                {
                    MessageBox.Show("Band is empty! You can't remove any item!", "Band is empty",
                             MessageBoxButtons.OK,
                             MessageBoxIcon.Exclamation);
                }
                else
                {
                    foreach (ContainableItem item in band.GetProductsList)
                    {
                        if (item.GetProduct.Name == name)
                        {
                            band.Remove(item);
                            break;
                        }
                    }
                }
            }
        }
    }
}
