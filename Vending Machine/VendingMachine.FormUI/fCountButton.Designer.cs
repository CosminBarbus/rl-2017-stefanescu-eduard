namespace VendingMachine.FormUI
{
    partial class fCountButton
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
            this.addButton = new System.Windows.Forms.Button();
            this.lCount = new System.Windows.Forms.Label();
            this.lProductName = new System.Windows.Forms.Label();
            this.tProductName = new System.Windows.Forms.TextBox();
            this.actionPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // actionPanel
            // 
            this.actionPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(31)))), ((int)(((byte)(32)))));
            this.actionPanel.Controls.Add(this.addButton);
            this.actionPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.actionPanel.Location = new System.Drawing.Point(0, 101);
            this.actionPanel.Name = "actionPanel";
            this.actionPanel.Size = new System.Drawing.Size(259, 41);
            this.actionPanel.TabIndex = 1;
            // 
            // addButton
            // 
            this.addButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.addButton.FlatAppearance.BorderSize = 0;
            this.addButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addButton.Image = global::VendingMachine.FormUI.Properties.Resources.uCountButton;
            this.addButton.Location = new System.Drawing.Point(79, 3);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(105, 35);
            this.addButton.TabIndex = 0;
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.countButton);
            // 
            // lCount
            // 
            this.lCount.AutoSize = true;
            this.lCount.Font = new System.Drawing.Font("Century Gothic", 8.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lCount.ForeColor = System.Drawing.Color.White;
            this.lCount.Location = new System.Drawing.Point(17, 64);
            this.lCount.Name = "lCount";
            this.lCount.Size = new System.Drawing.Size(0, 17);
            this.lCount.TabIndex = 2;
            // 
            // lProductName
            // 
            this.lProductName.AutoSize = true;
            this.lProductName.Font = new System.Drawing.Font("Century Gothic", 8.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lProductName.ForeColor = System.Drawing.Color.White;
            this.lProductName.Location = new System.Drawing.Point(12, 11);
            this.lProductName.Name = "lProductName";
            this.lProductName.Size = new System.Drawing.Size(47, 17);
            this.lProductName.TabIndex = 4;
            this.lProductName.Text = "Name:";
            // 
            // tProductName
            // 
            this.tProductName.Location = new System.Drawing.Point(12, 29);
            this.tProductName.Name = "tProductName";
            this.tProductName.Size = new System.Drawing.Size(235, 20);
            this.tProductName.TabIndex = 5;
            // 
            // fCountButton
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(23)))), ((int)(((byte)(23)))));
            this.ClientSize = new System.Drawing.Size(259, 142);
            this.Controls.Add(this.tProductName);
            this.Controls.Add(this.lProductName);
            this.Controls.Add(this.lCount);
            this.Controls.Add(this.actionPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "fCountButton";
            this.Text = "Count Products";
            this.actionPanel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel actionPanel;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Label lCount;
        private System.Windows.Forms.Label lProductName;
        private System.Windows.Forms.TextBox tProductName;
    }
}