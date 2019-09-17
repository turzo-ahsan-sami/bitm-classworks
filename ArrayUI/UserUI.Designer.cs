namespace ArrayUI
{
    partial class UserUI
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
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.addButton = new System.Windows.Forms.Button();
            this.richTextBox = new System.Windows.Forms.RichTextBox();
            this.nameLabel = new System.Windows.Forms.Label();
            this.showButton = new System.Windows.Forms.Button();
            this.ageLabel = new System.Windows.Forms.Label();
            this.ageTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // nameTextBox
            // 
            this.nameTextBox.Location = new System.Drawing.Point(397, 117);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(50, 20);
            this.nameTextBox.TabIndex = 0;
            this.nameTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.InputName);
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(377, 144);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(75, 23);
            this.addButton.TabIndex = 1;
            this.addButton.Text = "Add";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.Add);
            // 
            // richTextBox
            // 
            this.richTextBox.Location = new System.Drawing.Point(478, 90);
            this.richTextBox.Name = "richTextBox";
            this.richTextBox.Size = new System.Drawing.Size(100, 96);
            this.richTextBox.TabIndex = 2;
            this.richTextBox.Text = "";
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Location = new System.Drawing.Point(418, 97);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(35, 13);
            this.nameLabel.TabIndex = 3;
            this.nameLabel.Text = "Name";
            // 
            // showButton
            // 
            this.showButton.Location = new System.Drawing.Point(294, 144);
            this.showButton.Name = "showButton";
            this.showButton.Size = new System.Drawing.Size(75, 23);
            this.showButton.TabIndex = 4;
            this.showButton.Text = "Show";
            this.showButton.UseVisualStyleBackColor = true;
            this.showButton.Click += new System.EventHandler(this.ShowNames);
            // 
            // ageLabel
            // 
            this.ageLabel.AutoSize = true;
            this.ageLabel.Location = new System.Drawing.Point(303, 93);
            this.ageLabel.Name = "ageLabel";
            this.ageLabel.Size = new System.Drawing.Size(26, 13);
            this.ageLabel.TabIndex = 3;
            this.ageLabel.Text = "Age";
            // 
            // ageTextBox
            // 
            this.ageTextBox.Location = new System.Drawing.Point(277, 117);
            this.ageTextBox.Name = "ageTextBox";
            this.ageTextBox.Size = new System.Drawing.Size(100, 20);
            this.ageTextBox.TabIndex = 5;
            // 
            // UserUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ageTextBox);
            this.Controls.Add(this.showButton);
            this.Controls.Add(this.ageLabel);
            this.Controls.Add(this.nameLabel);
            this.Controls.Add(this.richTextBox);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.nameTextBox);
            this.Name = "UserUI";
            this.Text = "UserUI";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.RichTextBox richTextBox;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.Button showButton;
        private System.Windows.Forms.Label ageLabel;
        private System.Windows.Forms.TextBox ageTextBox;
    }
}