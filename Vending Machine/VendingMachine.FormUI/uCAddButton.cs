using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VendingMachine.FormUI
{
    public partial class uCAddButton : UserControl
    {
        private ContainableItem containableItem;
        private List<ProductBand> bandList;
        public uCAddButton()
        {
            InitializeComponent();
            containableItem = new ContainableItem();
            bandList = new List<ProductBand>();
        }

        public uCAddButton(ContainableItem containableItem, List<ProductBand> bandList)
        {
            InitializeComponent();
            this.containableItem = containableItem;
            this.bandList = bandList;
        }

        public ContainableItem GetContainableItem => containableItem;

        public List<ProductBand> GetBandList => bandList;

        private void addButton_Click(object sender, EventArgs e)
        {
            try
            {
                string name = tProductName.Text;
                double price = double.Parse(tProductPrice.Text);
                string categoryName = tProductCategoryName.Text;
                string description = tProductDescription.Text;
                int row = int.Parse(tProductRow.Text);
                int column = int.Parse(tProductColumn.Text);
                int size = int.Parse(tProductSize.Text);
                int quantity = int.Parse(tProductQuantity.Text);
                ProductCategory productCategory = new ProductCategory(categoryName, description);
                Product product = new Product(name, price, productCategory);
                ProductPosition productPosition = new ProductPosition(row, column);
                containableItem = new ContainableItem(productPosition, size, product);
                ProductBand productBand = new ProductBand(new List<ContainableItem>());
                productBand.AddManyItems(containableItem, quantity);
                bandList.Add(productBand);
            }
            catch (FormatException)
            {
                MessageBox.Show("Some input value is wrong! Please try again!",
                                "Wrong input",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Information);
            }
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
