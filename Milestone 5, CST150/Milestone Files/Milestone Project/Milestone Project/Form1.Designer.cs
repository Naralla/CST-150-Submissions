namespace Milestone_Project
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.searchProductPriceBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.searchProductNameBox = new System.Windows.Forms.TextBox();
            this.orderMoreButton = new System.Windows.Forms.Button();
            this.searchInventoryButton = new System.Windows.Forms.Button();
            this.closeButton = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.itemNameBox = new System.Windows.Forms.TextBox();
            this.itemPriceBox = new System.Windows.Forms.TextBox();
            this.itemQtyBox = new System.Windows.Forms.TextBox();
            this.addItemButton = new System.Windows.Forms.Button();
            this.removeItemButton = new System.Windows.Forms.Button();
            this.currentInventoryButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.LightGray;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(75, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(189, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "Search Inventory";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(14, 136);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(139, 19);
            this.label2.TabIndex = 1;
            this.label2.Text = "Enter Product Price";
            // 
            // searchProductPriceBox
            // 
            this.searchProductPriceBox.Location = new System.Drawing.Point(173, 131);
            this.searchProductPriceBox.Name = "searchProductPriceBox";
            this.searchProductPriceBox.Size = new System.Drawing.Size(155, 29);
            this.searchProductPriceBox.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(8, 67);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(145, 19);
            this.label3.TabIndex = 3;
            this.label3.Text = "Enter Product Name";
            // 
            // searchProductNameBox
            // 
            this.searchProductNameBox.Location = new System.Drawing.Point(173, 62);
            this.searchProductNameBox.Name = "searchProductNameBox";
            this.searchProductNameBox.Size = new System.Drawing.Size(155, 29);
            this.searchProductNameBox.TabIndex = 5;
            // 
            // orderMoreButton
            // 
            this.orderMoreButton.BackColor = System.Drawing.Color.DimGray;
            this.orderMoreButton.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.orderMoreButton.Location = new System.Drawing.Point(36, 231);
            this.orderMoreButton.Name = "orderMoreButton";
            this.orderMoreButton.Size = new System.Drawing.Size(163, 50);
            this.orderMoreButton.TabIndex = 9;
            this.orderMoreButton.Text = "Order More by Name";
            this.orderMoreButton.UseVisualStyleBackColor = false;
            this.orderMoreButton.Click += new System.EventHandler(this.orderMoreButton_Click);
            // 
            // searchInventoryButton
            // 
            this.searchInventoryButton.BackColor = System.Drawing.Color.DimGray;
            this.searchInventoryButton.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchInventoryButton.Location = new System.Drawing.Point(205, 231);
            this.searchInventoryButton.Name = "searchInventoryButton";
            this.searchInventoryButton.Size = new System.Drawing.Size(163, 50);
            this.searchInventoryButton.TabIndex = 10;
            this.searchInventoryButton.Text = "Search for Item, Name and Price";
            this.searchInventoryButton.UseVisualStyleBackColor = false;
            this.searchInventoryButton.Click += new System.EventHandler(this.searchInventoryButton_Click);
            // 
            // closeButton
            // 
            this.closeButton.BackColor = System.Drawing.Color.DimGray;
            this.closeButton.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.closeButton.Location = new System.Drawing.Point(662, 287);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(163, 48);
            this.closeButton.TabIndex = 11;
            this.closeButton.Text = "Close Program";
            this.closeButton.UseVisualStyleBackColor = false;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.LightGray;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(527, 22);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(249, 26);
            this.label5.TabIndex = 14;
            this.label5.Text = "Add Items to Inventory";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(457, 72);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(125, 19);
            this.label7.TabIndex = 15;
            this.label7.Text = "Enter Item Name";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(463, 141);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(119, 19);
            this.label8.TabIndex = 16;
            this.label8.Text = "Enter Item Price";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(457, 214);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(102, 19);
            this.label9.TabIndex = 17;
            this.label9.Text = "Item Quantity";
            // 
            // itemNameBox
            // 
            this.itemNameBox.Location = new System.Drawing.Point(621, 67);
            this.itemNameBox.Name = "itemNameBox";
            this.itemNameBox.Size = new System.Drawing.Size(155, 29);
            this.itemNameBox.TabIndex = 19;
            // 
            // itemPriceBox
            // 
            this.itemPriceBox.Location = new System.Drawing.Point(621, 136);
            this.itemPriceBox.Name = "itemPriceBox";
            this.itemPriceBox.Size = new System.Drawing.Size(155, 29);
            this.itemPriceBox.TabIndex = 20;
            // 
            // itemQtyBox
            // 
            this.itemQtyBox.Location = new System.Drawing.Point(621, 209);
            this.itemQtyBox.Name = "itemQtyBox";
            this.itemQtyBox.Size = new System.Drawing.Size(155, 29);
            this.itemQtyBox.TabIndex = 21;
            // 
            // addItemButton
            // 
            this.addItemButton.BackColor = System.Drawing.Color.DimGray;
            this.addItemButton.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addItemButton.Location = new System.Drawing.Point(493, 287);
            this.addItemButton.Name = "addItemButton";
            this.addItemButton.Size = new System.Drawing.Size(163, 48);
            this.addItemButton.TabIndex = 23;
            this.addItemButton.Text = "Add Item to Inventory";
            this.addItemButton.UseVisualStyleBackColor = false;
            this.addItemButton.Click += new System.EventHandler(this.addItemButton_Click);
            // 
            // removeItemButton
            // 
            this.removeItemButton.BackColor = System.Drawing.Color.DimGray;
            this.removeItemButton.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.removeItemButton.Location = new System.Drawing.Point(36, 287);
            this.removeItemButton.Name = "removeItemButton";
            this.removeItemButton.Size = new System.Drawing.Size(163, 48);
            this.removeItemButton.TabIndex = 26;
            this.removeItemButton.Text = "Use Name to remove from inventory";
            this.removeItemButton.UseVisualStyleBackColor = false;
            this.removeItemButton.Click += new System.EventHandler(this.removeItemButton_Click);
            // 
            // currentInventoryButton
            // 
            this.currentInventoryButton.BackColor = System.Drawing.Color.DimGray;
            this.currentInventoryButton.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.currentInventoryButton.Location = new System.Drawing.Point(205, 285);
            this.currentInventoryButton.Name = "currentInventoryButton";
            this.currentInventoryButton.Size = new System.Drawing.Size(163, 50);
            this.currentInventoryButton.TabIndex = 27;
            this.currentInventoryButton.Text = "Display Current Inventory";
            this.currentInventoryButton.UseVisualStyleBackColor = false;
            this.currentInventoryButton.Click += new System.EventHandler(this.currentInventoryButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Plum;
            this.ClientSize = new System.Drawing.Size(857, 354);
            this.Controls.Add(this.currentInventoryButton);
            this.Controls.Add(this.removeItemButton);
            this.Controls.Add(this.addItemButton);
            this.Controls.Add(this.itemQtyBox);
            this.Controls.Add(this.itemPriceBox);
            this.Controls.Add(this.itemNameBox);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.closeButton);
            this.Controls.Add(this.searchInventoryButton);
            this.Controls.Add(this.orderMoreButton);
            this.Controls.Add(this.searchProductNameBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.searchProductPriceBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.Name = "Form1";
            this.Text = "Inventory Management Form";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox searchProductPriceBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox searchProductNameBox;
        private System.Windows.Forms.Button orderMoreButton;
        private System.Windows.Forms.Button searchInventoryButton;
        private System.Windows.Forms.Button closeButton;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        public System.Windows.Forms.TextBox itemNameBox;
        public System.Windows.Forms.TextBox itemPriceBox;
        public System.Windows.Forms.TextBox itemQtyBox;
        private System.Windows.Forms.Button addItemButton;
        private System.Windows.Forms.Button removeItemButton;
        private System.Windows.Forms.Button currentInventoryButton;
    }
}

