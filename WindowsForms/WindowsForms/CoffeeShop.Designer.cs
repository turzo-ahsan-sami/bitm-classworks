namespace WindowsForms
{
    partial class CoffeeShop
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
            this.customerNameLabel = new System.Windows.Forms.Label();
            this.contactLabel = new System.Windows.Forms.Label();
            this.addressLabel = new System.Windows.Forms.Label();
            this.orderLabel = new System.Windows.Forms.Label();
            this.quantityLabel = new System.Windows.Forms.Label();
            this.customerNameTextbox = new System.Windows.Forms.TextBox();
            this.contactTextbox = new System.Windows.Forms.TextBox();
            this.addressTextbox = new System.Windows.Forms.TextBox();
            this.quantityTextBox = new System.Windows.Forms.TextBox();
            this.orderCombo = new System.Windows.Forms.ComboBox();
            this.orderDetailsRichTextbox = new System.Windows.Forms.RichTextBox();
            this.saveButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // customerNameLabel
            // 
            this.customerNameLabel.AutoSize = true;
            this.customerNameLabel.Location = new System.Drawing.Point(131, 101);
            this.customerNameLabel.Name = "customerNameLabel";
            this.customerNameLabel.Size = new System.Drawing.Size(82, 13);
            this.customerNameLabel.TabIndex = 0;
            this.customerNameLabel.Text = "Customer Name";
            // 
            // contactLabel
            // 
            this.contactLabel.AutoSize = true;
            this.contactLabel.Location = new System.Drawing.Point(169, 141);
            this.contactLabel.Name = "contactLabel";
            this.contactLabel.Size = new System.Drawing.Size(44, 13);
            this.contactLabel.TabIndex = 1;
            this.contactLabel.Text = "Contact";
            // 
            // addressLabel
            // 
            this.addressLabel.AutoSize = true;
            this.addressLabel.Location = new System.Drawing.Point(168, 185);
            this.addressLabel.Name = "addressLabel";
            this.addressLabel.Size = new System.Drawing.Size(45, 13);
            this.addressLabel.TabIndex = 2;
            this.addressLabel.Text = "Address";
            // 
            // orderLabel
            // 
            this.orderLabel.AutoSize = true;
            this.orderLabel.Location = new System.Drawing.Point(180, 252);
            this.orderLabel.Name = "orderLabel";
            this.orderLabel.Size = new System.Drawing.Size(33, 13);
            this.orderLabel.TabIndex = 3;
            this.orderLabel.Text = "Order";
            // 
            // quantityLabel
            // 
            this.quantityLabel.AutoSize = true;
            this.quantityLabel.Location = new System.Drawing.Point(167, 316);
            this.quantityLabel.Name = "quantityLabel";
            this.quantityLabel.Size = new System.Drawing.Size(46, 13);
            this.quantityLabel.TabIndex = 4;
            this.quantityLabel.Text = "Quantity";
            // 
            // customerNameTextbox
            // 
            this.customerNameTextbox.Location = new System.Drawing.Point(219, 101);
            this.customerNameTextbox.Name = "customerNameTextbox";
            this.customerNameTextbox.Size = new System.Drawing.Size(100, 20);
            this.customerNameTextbox.TabIndex = 5;
            this.customerNameTextbox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.storeCustomerName);
            // 
            // contactTextbox
            // 
            this.contactTextbox.Location = new System.Drawing.Point(219, 141);
            this.contactTextbox.Name = "contactTextbox";
            this.contactTextbox.Size = new System.Drawing.Size(100, 20);
            this.contactTextbox.TabIndex = 6;
            this.contactTextbox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.storeContact);
            // 
            // addressTextbox
            // 
            this.addressTextbox.Location = new System.Drawing.Point(219, 182);
            this.addressTextbox.Name = "addressTextbox";
            this.addressTextbox.Size = new System.Drawing.Size(100, 20);
            this.addressTextbox.TabIndex = 7;
            this.addressTextbox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.storeAddress);
            // 
            // quantityTextBox
            // 
            this.quantityTextBox.Location = new System.Drawing.Point(219, 316);
            this.quantityTextBox.Name = "quantityTextBox";
            this.quantityTextBox.Size = new System.Drawing.Size(100, 20);
            this.quantityTextBox.TabIndex = 8;
            this.quantityTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.storeQuantity);
            // 
            // orderCombo
            // 
            this.orderCombo.FormattingEnabled = true;
            this.orderCombo.Items.AddRange(new object[] {
            "black",
            "hot",
            "cold"});
            this.orderCombo.Location = new System.Drawing.Point(219, 252);
            this.orderCombo.Name = "orderCombo";
            this.orderCombo.Size = new System.Drawing.Size(100, 21);
            this.orderCombo.TabIndex = 9;
            this.orderCombo.SelectedIndexChanged += new System.EventHandler(this.orderCombo_SelectedIndexChanged);
            // 
            // orderDetailsRichTextbox
            // 
            this.orderDetailsRichTextbox.Location = new System.Drawing.Point(447, 101);
            this.orderDetailsRichTextbox.Name = "orderDetailsRichTextbox";
            this.orderDetailsRichTextbox.Size = new System.Drawing.Size(270, 274);
            this.orderDetailsRichTextbox.TabIndex = 10;
            this.orderDetailsRichTextbox.Text = "";
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(244, 354);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(75, 23);
            this.saveButton.TabIndex = 11;
            this.saveButton.Text = "Save";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // CoffeeShop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.orderDetailsRichTextbox);
            this.Controls.Add(this.orderCombo);
            this.Controls.Add(this.quantityTextBox);
            this.Controls.Add(this.addressTextbox);
            this.Controls.Add(this.contactTextbox);
            this.Controls.Add(this.customerNameTextbox);
            this.Controls.Add(this.quantityLabel);
            this.Controls.Add(this.orderLabel);
            this.Controls.Add(this.addressLabel);
            this.Controls.Add(this.contactLabel);
            this.Controls.Add(this.customerNameLabel);
            this.Name = "CoffeeShop";
            this.Text = "CoffeeShop";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label customerNameLabel;
        private System.Windows.Forms.Label contactLabel;
        private System.Windows.Forms.Label addressLabel;
        private System.Windows.Forms.Label orderLabel;
        private System.Windows.Forms.Label quantityLabel;
        private System.Windows.Forms.TextBox customerNameTextbox;
        private System.Windows.Forms.TextBox contactTextbox;
        private System.Windows.Forms.TextBox addressTextbox;
        private System.Windows.Forms.TextBox quantityTextBox;
        private System.Windows.Forms.ComboBox orderCombo;
        private System.Windows.Forms.RichTextBox orderDetailsRichTextbox;
        private System.Windows.Forms.Button saveButton;
    }
}