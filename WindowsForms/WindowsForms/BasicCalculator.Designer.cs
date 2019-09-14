using System;
using System.Windows.Forms;

namespace WindowsForms
{
    partial class BasicCalculator
    {

        private System.ComponentModel.IContainer components = null;

        private void InitializeComponent()
        {
            this.firstNumberTextBox = new System.Windows.Forms.TextBox();
            this.secondNumberTextBox = new System.Windows.Forms.TextBox();
            this.resultTextBox = new System.Windows.Forms.TextBox();
            this.addButton = new System.Windows.Forms.Button();
            this.subtractButton = new System.Windows.Forms.Button();
            this.multiplicatonButton = new System.Windows.Forms.Button();
            this.divisionButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.resetButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // firstNumberTextBox
            // 
            this.firstNumberTextBox.Location = new System.Drawing.Point(147, 12);
            this.firstNumberTextBox.Name = "firstNumberTextBox";
            this.firstNumberTextBox.Size = new System.Drawing.Size(321, 20);
            this.firstNumberTextBox.TabIndex = 0;
            this.firstNumberTextBox.TextChanged += new System.EventHandler(this.InputFirstNumber);
            // 
            // secondNumberTextBox
            // 
            this.secondNumberTextBox.Location = new System.Drawing.Point(147, 52);
            this.secondNumberTextBox.Name = "secondNumberTextBox";
            this.secondNumberTextBox.Size = new System.Drawing.Size(320, 20);
            this.secondNumberTextBox.TabIndex = 1;
            this.secondNumberTextBox.TextChanged += new System.EventHandler(this.InputSecondNumber);
            // 
            // resultTextBox
            // 
            this.resultTextBox.Location = new System.Drawing.Point(147, 103);
            this.resultTextBox.Name = "resultTextBox";
            this.resultTextBox.Size = new System.Drawing.Size(319, 20);
            this.resultTextBox.TabIndex = 2;
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(145, 146);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(75, 23);
            this.addButton.TabIndex = 3;
            this.addButton.Text = "Add";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.AddNumbers);
            // 
            // subtractButton
            // 
            this.subtractButton.Location = new System.Drawing.Point(227, 146);
            this.subtractButton.Name = "subtractButton";
            this.subtractButton.Size = new System.Drawing.Size(75, 23);
            this.subtractButton.TabIndex = 4;
            this.subtractButton.Text = "Subtract";
            this.subtractButton.UseVisualStyleBackColor = true;
            this.subtractButton.Click += new System.EventHandler(this.SubtractNumbers);
            // 
            // multiplicatonButton
            // 
            this.multiplicatonButton.Location = new System.Drawing.Point(309, 146);
            this.multiplicatonButton.Name = "multiplicatonButton";
            this.multiplicatonButton.Size = new System.Drawing.Size(75, 23);
            this.multiplicatonButton.TabIndex = 5;
            this.multiplicatonButton.Text = "Multiply";
            this.multiplicatonButton.UseVisualStyleBackColor = true;
            this.multiplicatonButton.Click += new System.EventHandler(this.MultiplyNumbers);
            // 
            // divisionButton
            // 
            this.divisionButton.Location = new System.Drawing.Point(391, 146);
            this.divisionButton.Name = "divisionButton";
            this.divisionButton.Size = new System.Drawing.Size(75, 23);
            this.divisionButton.TabIndex = 6;
            this.divisionButton.Text = "Divide";
            this.divisionButton.UseVisualStyleBackColor = true;
            this.divisionButton.Click += new System.EventHandler(this.DivideNumbers);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(62, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "First Number";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(57, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Second Number";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(104, 103);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Result";
            // 
            // resetButton
            // 
            this.resetButton.Location = new System.Drawing.Point(63, 146);
            this.resetButton.Name = "resetButton";
            this.resetButton.Size = new System.Drawing.Size(76, 23);
            this.resetButton.TabIndex = 10;
            this.resetButton.Text = "Reset";
            this.resetButton.UseVisualStyleBackColor = true;
            this.resetButton.Click += new System.EventHandler(this.ResetButton_Click);
            // 
            // BasicCalculator
            // 
            this.ClientSize = new System.Drawing.Size(523, 334);
            this.Controls.Add(this.resetButton);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.divisionButton);
            this.Controls.Add(this.multiplicatonButton);
            this.Controls.Add(this.subtractButton);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.resultTextBox);
            this.Controls.Add(this.secondNumberTextBox);
            this.Controls.Add(this.firstNumberTextBox);
            this.Name = "BasicCalculator";
            this.Click += new System.EventHandler(this.AddNumbers);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private TextBox firstNumberTextBox;
        private TextBox secondNumberTextBox;
        private TextBox resultTextBox;
        private Button addButton;
        private Button subtractButton;
        private Button multiplicatonButton;
        private Button divisionButton;
        private Label label1;
        private Label label2;
        private Label label3;
        private Button resetButton;
    }
}

