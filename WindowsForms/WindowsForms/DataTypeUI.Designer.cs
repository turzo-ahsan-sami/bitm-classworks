namespace WindowsForms
{
    partial class DataTypeUI
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
            this.itemList = new System.Windows.Forms.ComboBox();
            this.showItems = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // itemList
            // 
            this.itemList.FormattingEnabled = true;
            this.itemList.Items.AddRange(new object[] {
            "pen",
            "paper",
            "eraser",
            "pencil",
            "none"});
            this.itemList.Location = new System.Drawing.Point(121, 81);
            this.itemList.Name = "itemList";
            this.itemList.Size = new System.Drawing.Size(121, 21);
            this.itemList.TabIndex = 0;
            // 
            // showItems
            // 
            this.showItems.Location = new System.Drawing.Point(287, 81);
            this.showItems.Name = "showItems";
            this.showItems.Size = new System.Drawing.Size(75, 23);
            this.showItems.TabIndex = 1;
            this.showItems.Text = "Show";
            this.showItems.UseVisualStyleBackColor = true;
            this.showItems.Click += new System.EventHandler(this.showItems_Click);
            // 
            // DataTypeUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.showItems);
            this.Controls.Add(this.itemList);
            this.Name = "DataTypeUI";
            this.Text = "DataTypeUI";
            this.Load += new System.EventHandler(this.DataTypeUI_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox itemList;
        private System.Windows.Forms.Button showItems;
    }
}