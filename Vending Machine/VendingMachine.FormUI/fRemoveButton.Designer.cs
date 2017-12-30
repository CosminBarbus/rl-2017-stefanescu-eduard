namespace VendingMachine.FormUI
{
    partial class fRemoveButton
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
            this.removeButton = new System.Windows.Forms.Button();
            this.lProductName = new System.Windows.Forms.Label();
            this.tProductName = new System.Windows.Forms.TextBox();
            this.actionPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // actionPanel
            // 
            this.actionPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(31)))), ((int)(((byte)(32)))));
            this.actionPanel.Controls.Add(this.removeButton);
            this.actionPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.actionPanel.Location = new System.Drawing.Point(0, 82);
            this.actionPanel.Name = "actionPanel";
            this.actionPanel.Size = new System.Drawing.Size(259, 44);
            this.actionPanel.TabIndex = 1;
            // 
            // removeButton
            // 
            this.removeButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.removeButton.FlatAppearance.BorderSize = 0;
            this.removeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.removeButton.Image = global::VendingMachine.FormUI.Properties.Resources.URemoveButton;
            this.removeButton.Location = new System.Drawing.Point(68, 9);
            this.removeButton.Name = "removeButton";
            this.removeButton.Size = new System.Drawing.Size(122, 23);
            this.removeButton.TabIndex = 0;
            this.removeButton.UseVisualStyleBackColor = true;
            this.removeButton.Click += new System.EventHandler(this.removeButton_Click);
            // 
            // lProductName
            // 
            this.lProductName.AutoSize = true;
            this.lProductName.Font = new System.Drawing.Font("Century Gothic", 8.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lProductName.ForeColor = System.Drawing.Color.White;
            this.lProductName.Location = new System.Drawing.Point(12, 19);
            this.lProductName.Name = "lProductName";
            this.lProductName.Size = new System.Drawing.Size(47, 17);
            this.lProductName.TabIndex = 2;
            this.lProductName.Text = "Name:";
            // 
            // tProductName
            // 
            this.tProductName.Location = new System.Drawing.Point(12, 39);
            this.tProductName.Name = "tProductName";
            this.tProductName.Size = new System.Drawing.Size(235, 20);
            this.tProductName.TabIndex = 3;
            // 
            // fRemoveButton
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(23)))), ((int)(((byte)(23)))));
            this.ClientSize = new System.Drawing.Size(259, 126);
            this.Controls.Add(this.tProductName);
            this.Controls.Add(this.lProductName);
            this.Controls.Add(this.actionPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "fRemoveButton";
            this.Text = "Remove Product";
            this.actionPanel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel actionPanel;
        private System.Windows.Forms.Label lProductName;
        private System.Windows.Forms.TextBox tProductName;
        private System.Windows.Forms.Button removeButton;
    }
}