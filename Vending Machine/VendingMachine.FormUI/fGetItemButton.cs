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
    public partial class fGetItemButton : Form
    {
        ContainableItem containableItem;
        List<ProductBand> bandList;

        public fGetItemButton()
        {
            InitializeComponent();
        }

        public fGetItemButton(ContainableItem containableItem, List<ProductBand> bandList)
        {
            InitializeComponent();
            this.containableItem = containableItem;
            this.bandList = bandList;
        }

        private void getItemButton(object sender, EventArgs e)
        {
            string productName = tProductName.Text;
            int imageIndex = 0;

            foreach (ProductBand band in bandList)
            {
                if (band.GetProductsList.Count == 0)
                {
                    lProductCharacteristics.Text = productName + " band is empty! You can't get any item!" +
                                                                 " Please try again with another product!";
                    imageIndex = 3;
                }
                foreach (ContainableItem item in band.GetProductsList)
                {
                    if (item.GetProduct.Name == productName)
                    {
                        lProductCharacteristics.Text = "Name: " + item.GetProduct.Name +
                                                       "\nPrice: " + item.GetProduct.Price +
                                                       "$\nCategory name: " + item.GetProduct.Category.CategoryName + 
                                                       "\nDescription: " + item.GetProduct.Category.Description +
                                                       "\nRow: " + item.GetProductPosition.Row +
                                                       "\nColumn: " + item.GetProductPosition.Column +
                                                       "\nSize: " + item.Size;
                        imageIndex = iLProductImages.Images.IndexOfKey(productName);
                        if (imageIndex == -1)
                            imageIndex = 6;
                        break;
                    }
                }
            }
            this.pBProductImage.BackgroundImage = iLProductImages.Images[imageIndex];
        }
    }
}
