namespace VendingMachine.FormUI
{
    partial class fGetItemButton
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fGetItemButton));
            this.lProductName = new System.Windows.Forms.Label();
            this.tProductName = new System.Windows.Forms.TextBox();
            this.lProductCharacteristics = new System.Windows.Forms.Label();
            this.iLProductImages = new System.Windows.Forms.ImageList(this.components);
            this.actionPanel = new System.Windows.Forms.Panel();
            this.addButton = new System.Windows.Forms.Button();
            this.pBProductImage = new System.Windows.Forms.PictureBox();
            this.actionPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pBProductImage)).BeginInit();
            this.SuspendLayout();
            // 
            // lProductName
            // 
            this.lProductName.AutoSize = true;
            this.lProductName.Font = new System.Drawing.Font("Century Gothic", 8.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lProductName.ForeColor = System.Drawing.Color.White;
            this.lProductName.Location = new System.Drawing.Point(12, 12);
            this.lProductName.Name = "lProductName";
            this.lProductName.Size = new System.Drawing.Size(47, 17);
            this.lProductName.TabIndex = 0;
            this.lProductName.Text = "Name:";
            // 
            // tProductName
            // 
            this.tProductName.Location = new System.Drawing.Point(12, 30);
            this.tProductName.Name = "tProductName";
            this.tProductName.Size = new System.Drawing.Size(235, 20);
            this.tProductName.TabIndex = 1;
            // 
            // lProductCharacteristics
            // 
            this.lProductCharacteristics.Font = new System.Drawing.Font("Century Gothic", 8.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lProductCharacteristics.ForeColor = System.Drawing.Color.White;
            this.lProductCharacteristics.Location = new System.Drawing.Point(15, 59);
            this.lProductCharacteristics.Name = "lProductCharacteristics";
            this.lProductCharacteristics.Size = new System.Drawing.Size(230, 144);
            this.lProductCharacteristics.TabIndex = 2;
            // 
            // iLProductImages
            // 
            this.iLProductImages.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("iLProductImages.ImageStream")));
            this.iLProductImages.TransparentColor = System.Drawing.Color.Transparent;
            this.iLProductImages.Images.SetKeyName(0, "ItemNotFound");
            this.iLProductImages.Images.SetKeyName(1, "Snickers");
            this.iLProductImages.Images.SetKeyName(2, "Doritos");
            this.iLProductImages.Images.SetKeyName(3, "Skittles");
            this.iLProductImages.Images.SetKeyName(4, "KitKat");
            this.iLProductImages.Images.SetKeyName(5, "Twix");
            this.iLProductImages.Images.SetKeyName(6, "ImageNotFound");
            // 
            // actionPanel
            // 
            this.actionPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(31)))), ((int)(((byte)(32)))));
            this.actionPanel.Controls.Add(this.addButton);
            this.actionPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.actionPanel.Location = new System.Drawing.Point(0, 200);
            this.actionPanel.Name = "actionPanel";
            this.actionPanel.Size = new System.Drawing.Size(509, 41);
            this.actionPanel.TabIndex = 3;
            // 
            // addButton
            // 
            this.addButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.addButton.FlatAppearance.BorderSize = 0;
            this.addButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addButton.Image = global::VendingMachine.FormUI.Properties.Resources.uGetItem;
            this.addButton.Location = new System.Drawing.Point(191, 6);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(127, 35);
            this.addButton.TabIndex = 0;
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.getItemButton);
            // 
            // pBProductImage
            // 
            this.pBProductImage.BackColor = System.Drawing.Color.Transparent;
            this.pBProductImage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pBProductImage.Location = new System.Drawing.Point(265, 30);
            this.pBProductImage.Name = "pBProductImage";
            this.pBProductImage.Size = new System.Drawing.Size(233, 164);
            this.pBProductImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pBProductImage.TabIndex = 5;
            this.pBProductImage.TabStop = false;
            // 
            // fGetItemButton
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(23)))), ((int)(((byte)(23)))));
            this.ClientSize = new System.Drawing.Size(509, 241);
            this.Controls.Add(this.actionPanel);
            this.Controls.Add(this.lProductCharacteristics);
            this.Controls.Add(this.pBProductImage);
            this.Controls.Add(this.tProductName);
            this.Controls.Add(this.lProductName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "fGetItemButton";
            this.Text = "Get Item";
            this.actionPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pBProductImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lProductName;
        private System.Windows.Forms.TextBox tProductName;
        private System.Windows.Forms.Label lProductCharacteristics;
        private System.Windows.Forms.ImageList iLProductImages;
        private System.Windows.Forms.Panel actionPanel;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.PictureBox pBProductImage;
    }
}