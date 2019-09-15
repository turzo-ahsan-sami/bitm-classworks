using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ArrayUI
{
    public partial class ArrayUI : Form
    {
        const int size = 3;

        int[] array = new int[size];
        int index = 0;

        public ArrayUI()
        {
            InitializeComponent();
        }


        private void ResetArray(object sender, EventArgs e)
        {
            outputRichTextBox.Text = "";
            for (int i = 0; i < size; i++)
            {
                array[i] = 0;
            }
        }

        private void AddInput(object sender, EventArgs e)
        {

            if (index < size)
            {
                array[index] = int.Parse(inputTextBox.Text);
                inputTextBox.Text = "";
                DisplayInput();
                index++;
            }
            else
            {
                MessageBox.Show("Array is full");
            }
        }

        private void DisplayInput()
        {
            string message = "";
            for (int i = 0; i <= index; i++)
            {
                message += "Number " + (i + 1).ToString() + ": " + array[i].ToString() + "\n";
            }

            outputRichTextBox.Text = message;
        }


        private void ShowOutput(object sender, EventArgs e)
        {
            string message = "Output: \n\n";
            for (int i = 0; i < size; i++)
            {
                message += "Number " + (i + 1).ToString() + ": " + array[i].ToString() + "\n";
            }

            outputRichTextBox.Text = message;
        }
               


        private void ShowReverse(object sender, EventArgs e)
        {
            string message = "Reverse: \n\n";
            for (int i = (size-1); i > -1; i--)
            {
                message += "Number " + (i + 1).ToString() + ": " + array[i].ToString() + "\n";
            }

            outputRichTextBox.Text = message;
        }


        private void ShowSum(object sender, EventArgs e)
        {
            string message = "";
            int sum = 0;
            for (int i = 0; i < size; i++)
            {
                message += "Number " + (i + 1).ToString() + ": " + array[i].ToString() + "\n";
                sum += array[i];
            }

            outputRichTextBox.Text = message + "\n" + "SUM : " + sum.ToString();
        }

        private void FindDuplicate(object sender, EventArgs e)
        {
            string message = "Duplicate \n\n";
            
            var duplicates = array.GroupBy(i => i).Where(g => g.Count() > 1).Select(g => g.Key);

            foreach (var d in duplicates)
            {
                message += d + "\n";
            }

            outputRichTextBox.Text = message;
        }

        private void FindUnique(object sender, EventArgs e)
        {
            string message = "Unique \n\n";

            var duplicates = array.Distinct().ToArray();

            foreach (var d in duplicates)
            {
                message += d + "\n";
            }

            outputRichTextBox.Text = message;
        }


        private void FindMaximumMinimum(object sender, EventArgs e)
        {
            string message = "Maximum \n\n";
            int indexAtMax = array.ToList().IndexOf(array.Max());
            message += array[indexAtMax] + "\n\n";

            message += "Minimum \n\n";
            int indexAtMin = array.ToList().IndexOf(array.Min());
            message += array[indexAtMin] + "\n\n";

            outputRichTextBox.Text = message;
        }


        private void SortArray(object sender, EventArgs e)
        {
            string message = "Ascending \n\n";
            
            int[] ascendingArray = (from i in array orderby i ascending select i).ToArray();
            for (int i = 0; i < size; i++)
            {
                message += ascendingArray[i].ToString() + "\n";
            }

            message += "\n\nDescending \n\n";
            int[] descendingArray = (from i in array orderby i descending select i).ToArray();
            for (int i = 0; i < size; i++)
            {
                message += descendingArray[i].ToString() + "\n";
            }

            outputRichTextBox.Text = message;
        }

        private void SeparateOddEven(object sender, EventArgs e)
        {
            string message = "Odd \n\n";
            var oddNumbers = array.ToList().Where((c, i) => i % 2 == 0);
            foreach (var d in oddNumbers)
            {
                message += d + "\n";
            }

            message += "\n\nEven \n\n";
            var evenNumbers = array.ToList().Where((c, i) => i % 2 != 0);
            foreach (var d in evenNumbers)
            {
                message += d + "\n";
            }

            /*
                Indexes start a 0 not 1
                0 % 2 = 0
                0 index is odd
            */

            outputRichTextBox.Text = message;
        }


        private void InsertNewInput(object sender, EventArgs e)
        {
            string message = "";
            int[] newArray = array;

            int newValue = int.Parse(insertNewTextBox.Text);

            newArray = newArray.Concat(new int[] { newValue }).ToArray();

            newArray = (from i in newArray orderby i ascending select i).ToArray();

            for (int i = 0; i < newArray.Length; i++)
            {
                message += newArray[i].ToString() + "\n";
            }

            outputRichTextBox.Text = message;
        }

    }
}
