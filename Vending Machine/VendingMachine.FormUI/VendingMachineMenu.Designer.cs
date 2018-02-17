#pragma warning disable 169
namespace VendingMachine.FormUI
{
    partial class VendingMachineForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.actionPanel = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.getItemButton = new System.Windows.Forms.Button();
            this.addButton = new System.Windows.Forms.Button();
            this.countButton = new System.Windows.Forms.Button();
            this.removeButton = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // actionPanel
            // 
            this.actionPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(31)))), ((int)(((byte)(32)))));
            this.actionPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.actionPanel.Location = new System.Drawing.Point(0, 323);
            this.actionPanel.Name = "actionPanel";
            this.actionPanel.Size = new System.Drawing.Size(259, 44);
            this.actionPanel.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.getItemButton);
            this.panel1.Controls.Add(this.addButton);
            this.panel1.Controls.Add(this.countButton);
            this.panel1.Controls.Add(this.removeButton);
            this.panel1.Location = new System.Drawing.Point(0, -1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(259, 331);
            this.panel1.TabIndex = 6;
            // 
            // getItemButton
            // 
            this.getItemButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(23)))), ((int)(((byte)(23)))));
            this.getItemButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.getItemButton.FlatAppearance.BorderSize = 0;
            this.getItemButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.getItemButton.Image = global::VendingMachine.FormUI.Properties.Resources.GetItemButton;
            this.getItemButton.Location = new System.Drawing.Point(43, 206);
            this.getItemButton.Name = "getItemButton";
            this.getItemButton.Size = new System.Drawing.Size(163, 41);
            this.getItemButton.TabIndex = 4;
            this.getItemButton.UseVisualStyleBackColor = false;
            this.getItemButton.Click += new System.EventHandler(this.getItemButton_Click);
            // 
            // addButton
            // 
            this.addButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(23)))), ((int)(((byte)(23)))));
            this.addButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.addButton.FlatAppearance.BorderSize = 0;
            this.addButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addButton.Image = global::VendingMachine.FormUI.Properties.Resources.AddButton;
            this.addButton.Location = new System.Drawing.Point(43, 65);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(163, 41);
            this.addButton.TabIndex = 1;
            this.addButton.UseVisualStyleBackColor = false;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // countButton
            // 
            this.countButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(23)))), ((int)(((byte)(23)))));
            this.countButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.countButton.FlatAppearance.BorderSize = 0;
            this.countButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.countButton.Image = global::VendingMachine.FormUI.Properties.Resources.CountButton;
            this.countButton.Location = new System.Drawing.Point(43, 159);
            this.countButton.Name = "countButton";
            this.countButton.Size = new System.Drawing.Size(163, 41);
            this.countButton.TabIndex = 3;
            this.countButton.UseVisualStyleBackColor = false;
            this.countButton.Click += new System.EventHandler(this.countButton_Click);
            // 
            // removeButton
            // 
            this.removeButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(23)))), ((int)(((byte)(23)))));
            this.removeButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.removeButton.FlatAppearance.BorderSize = 0;
            this.removeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.removeButton.Image = global::VendingMachine.FormUI.Properties.Resources.RemoveButton;
            this.removeButton.Location = new System.Drawing.Point(43, 112);
            this.removeButton.Name = "removeButton";
            this.removeButton.Size = new System.Drawing.Size(163, 41);
            this.removeButton.TabIndex = 2;
            this.removeButton.UseVisualStyleBackColor = false;
            this.removeButton.Click += new System.EventHandler(this.removeButton_Click);
            // 
            // VendingMachineForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(23)))), ((int)(((byte)(23)))));
            this.ClientSize = new System.Drawing.Size(259, 367);
            this.Controls.Add(this.actionPanel);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "VendingMachineForm";
            this.Text = "Vending Machine - Menu";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel actionPanel;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Button removeButton;
        private System.Windows.Forms.Button countButton;
        private System.Windows.Forms.Button getItemButton;
        private uCAddButton uCAddButton1;
        private System.Windows.Forms.Panel panel1;
    }
}

