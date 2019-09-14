using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsForms
{
    public partial class BasicCalculator : Form
    {

        private double firstNumber;
        private double secondNumber;
        private double result;

        public BasicCalculator()
        {
            InitializeComponent();
        }

        
        private void InputFirstNumber(object sender, EventArgs e)
        {
            string textBoxValue = "";

            if (checkTextisNumber(firstNumberTextBox.Text)) textBoxValue = firstNumberTextBox.Text;
            else firstNumberTextBox.Text = textBoxValue;
            
            if (textBoxValue == "") firstNumber = 0;
            else firstNumber = double.Parse(textBoxValue);
        }

        private void InputSecondNumber(object sender, EventArgs e)
        {
            string textBoxValue = "";

            if (checkTextisNumber(secondNumberTextBox.Text)) textBoxValue = secondNumberTextBox.Text;
            else secondNumberTextBox.Text = textBoxValue;

            if (textBoxValue == "") secondNumber = 0;
            else secondNumber = double.Parse(textBoxValue);
        }

        private void AddNumbers(object sender, EventArgs e)
        {
            result = firstNumber + secondNumber;
            DisplayOutput();
        }

        private void MultiplyNumbers(object sender, EventArgs e)
        {
            result = firstNumber * secondNumber;
            DisplayOutput();
        }

        private void SubtractNumbers(object sender, EventArgs e)
        {
            result = 0;
            resultTextBox.Text = "";

            if (firstNumber < secondNumber)
            {
                MessageBox.Show("first number is less than second number");
            }
            else
            {
                result = firstNumber - secondNumber;
                DisplayOutput();
            }
            
        }

        private void DivideNumbers(object sender, EventArgs e)
        {
            result = 0;
            resultTextBox.Text = "";
            /*
                try
                {
                    result = firstNumber / secondNumber;
                    DisplayOutput();
                }
                catch (DivideByZeroException ex)
                {
                    MessageBox.Show(ex.Message);
                }
            */

            if(secondNumber != 0)
            {
                result = firstNumber / secondNumber;
                DisplayOutput();
            }
            else
            {
                MessageBox.Show("can not divide by zero");
            }
            
        }

        private void DisplayOutput()
        {
            resultTextBox.Text = result.ToString();
        }

        private static bool checkTextisNumber(string numberVal)
        {
            bool numResult;
            try
            {
                if (numberVal.Equals("."))
                {
                    numResult = true;
                }
                else if (numberVal.Equals(""))
                {
                    numResult = true;
                }
                else
                {
                    bool canConvert = decimal.TryParse(numberVal, out decimal number3);
                    if (canConvert == true)
                    {
                        numResult = true;
                    }
                    else
                    {
                        numResult = false;
                    }
                }

            }
            catch (Exception)
            {
                numResult = false;
            }
            return numResult;
        }

        private void ResetButton_Click(object sender, EventArgs e)
        {
            firstNumber = 0;
            firstNumberTextBox.Text = "";
            secondNumber = 0;
            secondNumberTextBox.Text = "";
            result = 0;
            resultTextBox.Text = "";
        }
    }
}
