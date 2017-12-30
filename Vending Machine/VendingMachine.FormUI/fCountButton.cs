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
    public partial class fCountButton : Form
    {
        private ContainableItem containableItem;
        private List<ProductBand> bandList;
        public fCountButton()
        {
            InitializeComponent();
        }

        public fCountButton(ContainableItem containableItem, List<ProductBand> bandList)
        {
            InitializeComponent();
            this.containableItem = containableItem;
            this.bandList = bandList;
        }

        private void countButton(object sender, EventArgs e)
        {
            string name = tProductName.Text;
            string productName = "undefined";
            int count = 0;
            foreach (ProductBand band in bandList)
            {
                if (band.GetProductsList.Count == 0)
                    productName = name;
                else
                {
                    foreach (ContainableItem item in band.GetProductsList)
                    {
                        if (item.GetProduct.Name == name)
                        {
                            count = band.Count();
                            productName = item.GetProduct.Name;
                            break;
                        }
                    }
                }
            }
            lCount.Text = productName + " band contains " + count + " items";
        }
    }
}
