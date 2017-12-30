namespace VendingMachine.FormUI
{
    partial class uCAddButton
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.actionPanel = new System.Windows.Forms.Panel();
            this.backButton = new System.Windows.Forms.Button();
            this.addButton = new System.Windows.Forms.Button();
            this.lProductName = new System.Windows.Forms.Label();
            this.tProductName = new System.Windows.Forms.TextBox();
            this.tProductPrice = new System.Windows.Forms.TextBox();
            this.lProductPrice = new System.Windows.Forms.Label();
            this.tProductCategoryName = new System.Windows.Forms.TextBox();
            this.lProductCategoryName = new System.Windows.Forms.Label();
            this.tProductDescription = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tProductRow = new System.Windows.Forms.TextBox();
            this.lProductRow = new System.Windows.Forms.Label();
            this.tProductColumn = new System.Windows.Forms.TextBox();
            this.lProductColumn = new System.Windows.Forms.Label();
            this.tProductQuantity = new System.Windows.Forms.TextBox();
            this.lProductQuantity = new System.Windows.Forms.Label();
            this.lProductDescription = new System.Windows.Forms.Label();
            this.tProductSize = new System.Windows.Forms.TextBox();
            this.lProductSize = new System.Windows.Forms.Label();
            this.actionPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // actionPanel
            // 
            this.actionPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(31)))), ((int)(((byte)(32)))));
            this.actionPanel.Controls.Add(this.backButton);
            this.actionPanel.Controls.Add(this.addButton);
            this.actionPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.actionPanel.Location = new System.Drawing.Point(0, 327);
            this.actionPanel.Name = "actionPanel";
            this.actionPanel.Size = new System.Drawing.Size(259, 41);
            this.actionPanel.TabIndex = 0;
            // 
            // backButton
            // 
            this.backButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.backButton.FlatAppearance.BorderSize = 0;
            this.backButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.backButton.Font = new System.Drawing.Font("Century Gothic", 12.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.backButton.ForeColor = System.Drawing.Color.White;
            this.backButton.Location = new System.Drawing.Point(0, 0);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(26, 41);
            this.backButton.TabIndex = 16;
            this.backButton.Text = "<";
            this.backButton.UseVisualStyleBackColor = true;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // addButton
            // 
            this.addButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.addButton.FlatAppearance.BorderSize = 0;
            this.addButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addButton.Image = global::VendingMachine.FormUI.Properties.Resources.UAddButton;
            this.addButton.Location = new System.Drawing.Point(79, 3);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(105, 35);
            this.addButton.TabIndex = 0;
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // lProductName
            // 
            this.lProductName.AutoSize = true;
            this.lProductName.Font = new System.Drawing.Font("Century Gothic", 8.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lProductName.ForeColor = System.Drawing.Color.Transparent;
            this.lProductName.Location = new System.Drawing.Point(16, 7);
            this.lProductName.Name = "lProductName";
            this.lProductName.Size = new System.Drawing.Size(47, 17);
            this.lProductName.TabIndex = 1;
            this.lProductName.Text = "Name:";
            // 
            // tProductName
            // 
            this.tProductName.Location = new System.Drawing.Point(16, 23);
            this.tProductName.Name = "tProductName";
            this.tProductName.Size = new System.Drawing.Size(227, 20);
            this.tProductName.TabIndex = 2;
            // 
            // tProductPrice
            // 
            this.tProductPrice.Location = new System.Drawing.Point(16, 61);
            this.tProductPrice.Name = "tProductPrice";
            this.tProductPrice.Size = new System.Drawing.Size(227, 20);
            this.tProductPrice.TabIndex = 4;
            // 
            // lProductPrice
            // 
            this.lProductPrice.AutoSize = true;
            this.lProductPrice.Font = new System.Drawing.Font("Century Gothic", 8.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lProductPrice.ForeColor = System.Drawing.Color.Transparent;
            this.lProductPrice.Location = new System.Drawing.Point(16, 44);
            this.lProductPrice.Name = "lProductPrice";
            this.lProductPrice.Size = new System.Drawing.Size(41, 17);
            this.lProductPrice.TabIndex = 3;
            this.lProductPrice.Text = "Price:";
            // 
            // tProductCategoryName
            // 
            this.tProductCategoryName.Location = new System.Drawing.Point(16, 99);
            this.tProductCategoryName.Name = "tProductCategoryName";
            this.tProductCategoryName.Size = new System.Drawing.Size(227, 20);
            this.tProductCategoryName.TabIndex = 6;
            // 
            // lProductCategoryName
            // 
            this.lProductCategoryName.AutoSize = true;
            this.lProductCategoryName.Font = new System.Drawing.Font("Century Gothic", 8.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lProductCategoryName.ForeColor = System.Drawing.Color.Transparent;
            this.lProductCategoryName.Location = new System.Drawing.Point(16, 83);
            this.lProductCategoryName.Name = "lProductCategoryName";
            this.lProductCategoryName.Size = new System.Drawing.Size(104, 17);
            this.lProductCategoryName.TabIndex = 5;
            this.lProductCategoryName.Text = "Category name:";
            // 
            // tProductDescription
            // 
            this.tProductDescription.Location = new System.Drawing.Point(16, 140);
            this.tProductDescription.Name = "tProductDescription";
            this.tProductDescription.Size = new System.Drawing.Size(227, 20);
            this.tProductDescription.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 8.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Transparent;
            this.label3.Location = new System.Drawing.Point(16, 136);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 17);
            this.label3.TabIndex = 7;
            // 
            // tProductRow
            // 
            this.tProductRow.Location = new System.Drawing.Point(16, 179);
            this.tProductRow.Name = "tProductRow";
            this.tProductRow.Size = new System.Drawing.Size(227, 20);
            this.tProductRow.TabIndex = 10;
            // 
            // lProductRow
            // 
            this.lProductRow.AutoSize = true;
            this.lProductRow.Font = new System.Drawing.Font("Century Gothic", 8.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lProductRow.ForeColor = System.Drawing.Color.Transparent;
            this.lProductRow.Location = new System.Drawing.Point(16, 162);
            this.lProductRow.Name = "lProductRow";
            this.lProductRow.Size = new System.Drawing.Size(36, 17);
            this.lProductRow.TabIndex = 9;
            this.lProductRow.Text = "Row:";
            // 
            // tProductColumn
            // 
            this.tProductColumn.Location = new System.Drawing.Point(16, 218);
            this.tProductColumn.Name = "tProductColumn";
            this.tProductColumn.Size = new System.Drawing.Size(227, 20);
            this.tProductColumn.TabIndex = 12;
            // 
            // lProductColumn
            // 
            this.lProductColumn.AutoSize = true;
            this.lProductColumn.Font = new System.Drawing.Font("Century Gothic", 8.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lProductColumn.ForeColor = System.Drawing.Color.Transparent;
            this.lProductColumn.Location = new System.Drawing.Point(16, 201);
            this.lProductColumn.Name = "lProductColumn";
            this.lProductColumn.Size = new System.Drawing.Size(56, 17);
            this.lProductColumn.TabIndex = 11;
            this.lProductColumn.Text = "Column:";
            // 
            // tProductQuantity
            // 
            this.tProductQuantity.Location = new System.Drawing.Point(16, 298);
            this.tProductQuantity.Name = "tProductQuantity";
            this.tProductQuantity.Size = new System.Drawing.Size(227, 20);
            this.tProductQuantity.TabIndex = 16;
            // 
            // lProductQuantity
            // 
            this.lProductQuantity.AutoSize = true;
            this.lProductQuantity.Font = new System.Drawing.Font("Century Gothic", 8.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lProductQuantity.ForeColor = System.Drawing.Color.Transparent;
            this.lProductQuantity.Location = new System.Drawing.Point(16, 281);
            this.lProductQuantity.Name = "lProductQuantity";
            this.lProductQuantity.Size = new System.Drawing.Size(57, 17);
            this.lProductQuantity.TabIndex = 15;
            this.lProductQuantity.Text = "Quantiy:";
            // 
            // lProductDescription
            // 
            this.lProductDescription.AutoSize = true;
            this.lProductDescription.Font = new System.Drawing.Font("Century Gothic", 8.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lProductDescription.ForeColor = System.Drawing.Color.Transparent;
            this.lProductDescription.Location = new System.Drawing.Point(16, 123);
            this.lProductDescription.Name = "lProductDescription";
            this.lProductDescription.Size = new System.Drawing.Size(79, 17);
            this.lProductDescription.TabIndex = 15;
            this.lProductDescription.Text = "Description:";
            // 
            // tProductSize
            // 
            this.tProductSize.Location = new System.Drawing.Point(16, 258);
            this.tProductSize.Name = "tProductSize";
            this.tProductSize.Size = new System.Drawing.Size(227, 20);
            this.tProductSize.TabIndex = 14;
            // 
            // lProductSize
            // 
            this.lProductSize.AutoSize = true;
            this.lProductSize.Font = new System.Drawing.Font("Century Gothic", 8.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lProductSize.ForeColor = System.Drawing.Color.Transparent;
            this.lProductSize.Location = new System.Drawing.Point(16, 241);
            this.lProductSize.Name = "lProductSize";
            this.lProductSize.Size = new System.Drawing.Size(34, 17);
            this.lProductSize.TabIndex = 13;
            this.lProductSize.Text = "Size:";
            // 
            // uCAddButton
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(23)))), ((int)(((byte)(23)))));
            this.Controls.Add(this.tProductSize);
            this.Controls.Add(this.lProductSize);
            this.Controls.Add(this.lProductDescription);
            this.Controls.Add(this.tProductQuantity);
            this.Controls.Add(this.lProductQuantity);
            this.Controls.Add(this.tProductColumn);
            this.Controls.Add(this.lProductColumn);
            this.Controls.Add(this.tProductRow);
            this.Controls.Add(this.lProductRow);
            this.Controls.Add(this.tProductDescription);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tProductCategoryName);
            this.Controls.Add(this.lProductCategoryName);
            this.Controls.Add(this.tProductPrice);
            this.Controls.Add(this.lProductPrice);
            this.Controls.Add(this.tProductName);
            this.Controls.Add(this.lProductName);
            this.Controls.Add(this.actionPanel);
            this.Name = "uCAddButton";
            this.Size = new System.Drawing.Size(259, 368);
            this.actionPanel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel actionPanel;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Label lProductName;
        private System.Windows.Forms.TextBox tProductName;
        private System.Windows.Forms.TextBox tProductPrice;
        private System.Windows.Forms.Label lProductPrice;
        private System.Windows.Forms.TextBox tProductCategoryName;
        private System.Windows.Forms.Label lProductCategoryName;
        private System.Windows.Forms.TextBox tProductDescription;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tProductRow;
        private System.Windows.Forms.Label lProductRow;
        private System.Windows.Forms.TextBox tProductColumn;
        private System.Windows.Forms.Label lProductColumn;
        private System.Windows.Forms.TextBox tProductQuantity;
        private System.Windows.Forms.Label lProductQuantity;
        private System.Windows.Forms.Label lProductDescription;
        private System.Windows.Forms.Button backButton;
        private System.Windows.Forms.TextBox tProductSize;
        private System.Windows.Forms.Label lProductSize;
    }
}
