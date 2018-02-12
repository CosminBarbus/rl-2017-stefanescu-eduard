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
    public partial class VendingMachineForm : Form
    {
        uCAddButton uAddButton;
        fRemoveButton uRemoveButton;
        fCountButton uCountButton;
        fGetItemButton uGetItemButton;
        ContainableItem containableItem;
        List<ProductBand> bandList;
        public VendingMachineForm()
        {
            InitializeComponent();
            containableItem = new ContainableItem();
            bandList = new List<ProductBand>();
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            uAddButton = new uCAddButton(containableItem, bandList);
            Controls.Add(uAddButton);
            uAddButton.BringToFront();
            uAddButton.Show();
        }

        private void removeButton_Click(object sender, EventArgs e)
        {
            uRemoveButton = new fRemoveButton(containableItem, bandList);
            uRemoveButton.ShowDialog();
        }

        private void countButton_Click(object sender, EventArgs e)
        {
            uCountButton = new fCountButton(containableItem, bandList);
            uCountButton.ShowDialog();
        }

        private void getItemButton_Click(object sender, EventArgs e)
        {
            uGetItemButton = new fGetItemButton(containableItem, bandList);
            uGetItemButton.ShowDialog();
        }
    }
}
