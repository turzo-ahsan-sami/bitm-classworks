namespace ArrayUI
{
    partial class ArrayUI
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
            this.showButton = new System.Windows.Forms.Button();
            this.inputTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.addButton = new System.Windows.Forms.Button();
            this.outputRichTextBox = new System.Windows.Forms.RichTextBox();
            this.reverseButton = new System.Windows.Forms.Button();
            this.sumButton = new System.Windows.Forms.Button();
            this.findDuplicateButton = new System.Windows.Forms.Button();
            this.resetButton = new System.Windows.Forms.Button();
            this.findQuiqueButton = new System.Windows.Forms.Button();
            this.findMaxMinButton = new System.Windows.Forms.Button();
            this.sortButton = new System.Windows.Forms.Button();
            this.separateOddEvenButton = new System.Windows.Forms.Button();
            this.insertNewButton = new System.Windows.Forms.Button();
            this.insertNewTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // showButton
            // 
            this.showButton.Location = new System.Drawing.Point(433, 72);
            this.showButton.Name = "showButton";
            this.showButton.Size = new System.Drawing.Size(75, 23);
            this.showButton.TabIndex = 0;
            this.showButton.Text = "Show";
            this.showButton.UseVisualStyleBackColor = true;
            this.showButton.Click += new System.EventHandler(this.ShowOutput);
            // 
            // inputTextBox
            // 
            this.inputTextBox.Location = new System.Drawing.Point(283, 36);
            this.inputTextBox.Name = "inputTextBox";
            this.inputTextBox.Size = new System.Drawing.Size(118, 20);
            this.inputTextBox.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(246, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Input";
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(326, 62);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(75, 23);
            this.addButton.TabIndex = 3;
            this.addButton.Text = "Add";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.AddInput);
            // 
            // outputRichTextBox
            // 
            this.outputRichTextBox.Location = new System.Drawing.Point(245, 101);
            this.outputRichTextBox.Name = "outputRichTextBox";
            this.outputRichTextBox.Size = new System.Drawing.Size(156, 238);
            this.outputRichTextBox.TabIndex = 4;
            this.outputRichTextBox.Text = "";
            // 
            // reverseButton
            // 
            this.reverseButton.Location = new System.Drawing.Point(514, 72);
            this.reverseButton.Name = "reverseButton";
            this.reverseButton.Size = new System.Drawing.Size(75, 23);
            this.reverseButton.TabIndex = 5;
            this.reverseButton.Text = "Reverse";
            this.reverseButton.UseVisualStyleBackColor = true;
            this.reverseButton.Click += new System.EventHandler(this.ShowReverse);
            // 
            // sumButton
            // 
            this.sumButton.Location = new System.Drawing.Point(595, 72);
            this.sumButton.Name = "sumButton";
            this.sumButton.Size = new System.Drawing.Size(75, 23);
            this.sumButton.TabIndex = 5;
            this.sumButton.Text = "Sum";
            this.sumButton.UseVisualStyleBackColor = true;
            this.sumButton.Click += new System.EventHandler(this.ShowSum);
            // 
            // findDuplicateButton
            // 
            this.findDuplicateButton.Location = new System.Drawing.Point(514, 101);
            this.findDuplicateButton.Name = "findDuplicateButton";
            this.findDuplicateButton.Size = new System.Drawing.Size(75, 23);
            this.findDuplicateButton.TabIndex = 5;
            this.findDuplicateButton.Text = "Duplicate";
            this.findDuplicateButton.UseVisualStyleBackColor = true;
            this.findDuplicateButton.Click += new System.EventHandler(this.FindDuplicate);
            // 
            // resetButton
            // 
            this.resetButton.Location = new System.Drawing.Point(245, 62);
            this.resetButton.Name = "resetButton";
            this.resetButton.Size = new System.Drawing.Size(75, 23);
            this.resetButton.TabIndex = 3;
            this.resetButton.Text = "Reset";
            this.resetButton.UseVisualStyleBackColor = true;
            this.resetButton.Click += new System.EventHandler(this.ResetArray);
            // 
            // findQuiqueButton
            // 
            this.findQuiqueButton.Location = new System.Drawing.Point(595, 101);
            this.findQuiqueButton.Name = "findQuiqueButton";
            this.findQuiqueButton.Size = new System.Drawing.Size(75, 23);
            this.findQuiqueButton.TabIndex = 5;
            this.findQuiqueButton.Text = "Unique";
            this.findQuiqueButton.UseVisualStyleBackColor = true;
            this.findQuiqueButton.Click += new System.EventHandler(this.FindUnique);
            // 
            // findMaxMinButton
            // 
            this.findMaxMinButton.Location = new System.Drawing.Point(433, 100);
            this.findMaxMinButton.Name = "findMaxMinButton";
            this.findMaxMinButton.Size = new System.Drawing.Size(75, 23);
            this.findMaxMinButton.TabIndex = 5;
            this.findMaxMinButton.Text = "Max_Min";
            this.findMaxMinButton.UseVisualStyleBackColor = true;
            this.findMaxMinButton.Click += new System.EventHandler(this.FindMaximumMinimum);
            // 
            // sortButton
            // 
            this.sortButton.Location = new System.Drawing.Point(433, 129);
            this.sortButton.Name = "sortButton";
            this.sortButton.Size = new System.Drawing.Size(75, 23);
            this.sortButton.TabIndex = 5;
            this.sortButton.Text = "Sort";
            this.sortButton.UseVisualStyleBackColor = true;
            this.sortButton.Click += new System.EventHandler(this.SortArray);
            // 
            // separateOddEvenButton
            // 
            this.separateOddEvenButton.Location = new System.Drawing.Point(514, 129);
            this.separateOddEvenButton.Name = "separateOddEvenButton";
            this.separateOddEvenButton.Size = new System.Drawing.Size(75, 23);
            this.separateOddEvenButton.TabIndex = 5;
            this.separateOddEvenButton.Text = "Odd_Even";
            this.separateOddEvenButton.UseVisualStyleBackColor = true;
            this.separateOddEvenButton.Click += new System.EventHandler(this.SeparateOddEven);
            // 
            // insertNewButton
            // 
            this.insertNewButton.Location = new System.Drawing.Point(514, 38);
            this.insertNewButton.Name = "insertNewButton";
            this.insertNewButton.Size = new System.Drawing.Size(75, 23);
            this.insertNewButton.TabIndex = 0;
            this.insertNewButton.Text = "Insert_New";
            this.insertNewButton.UseVisualStyleBackColor = true;
            this.insertNewButton.Click += new System.EventHandler(this.InsertNewInput);
            // 
            // insertNewTextBox
            // 
            this.insertNewTextBox.Location = new System.Drawing.Point(433, 38);
            this.insertNewTextBox.Name = "insertNewTextBox";
            this.insertNewTextBox.Size = new System.Drawing.Size(75, 20);
            this.insertNewTextBox.TabIndex = 1;
            // 
            // ArrayUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.findQuiqueButton);
            this.Controls.Add(this.separateOddEvenButton);
            this.Controls.Add(this.sortButton);
            this.Controls.Add(this.findMaxMinButton);
            this.Controls.Add(this.findDuplicateButton);
            this.Controls.Add(this.sumButton);
            this.Controls.Add(this.reverseButton);
            this.Controls.Add(this.outputRichTextBox);
            this.Controls.Add(this.resetButton);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.insertNewTextBox);
            this.Controls.Add(this.inputTextBox);
            this.Controls.Add(this.insertNewButton);
            this.Controls.Add(this.showButton);
            this.Name = "ArrayUI";
            this.Text = "Array UI";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button showButton;
        private System.Windows.Forms.TextBox inputTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.RichTextBox outputRichTextBox;
        private System.Windows.Forms.Button reverseButton;
        private System.Windows.Forms.Button sumButton;
        private System.Windows.Forms.Button findDuplicateButton;
        private System.Windows.Forms.Button resetButton;
        private System.Windows.Forms.Button findQuiqueButton;
        private System.Windows.Forms.Button findMaxMinButton;
        private System.Windows.Forms.Button sortButton;
        private System.Windows.Forms.Button separateOddEvenButton;
        private System.Windows.Forms.Button insertNewButton;
        private System.Windows.Forms.TextBox insertNewTextBox;
    }
}

