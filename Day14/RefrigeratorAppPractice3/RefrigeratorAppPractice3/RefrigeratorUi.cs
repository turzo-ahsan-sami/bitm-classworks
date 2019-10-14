using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RefrigeratorAppPractice3
{
    public partial class RefrigeratorUi : Form
    {
        Refrigerator aRefrigerator = new Refrigerator();

        public RefrigeratorUi()
        {
            InitializeComponent();
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            int maxweight = string.IsNullOrEmpty(maxWeightTextBox.Text) ? 0 : Convert.ToInt32(maxWeightTextBox.Text);
            aRefrigerator.MaxWeight = maxweight;
            maxWeightTextBox.Clear();
        }

        private void EnterButton_Click(object sender, EventArgs e)
        {
            int noOfItems = string.IsNullOrEmpty(itemTextBox.Text) ? 0 : Convert.ToInt32(itemTextBox.Text);
            int weightOfItems = string.IsNullOrEmpty(weightTextBox.Text) ? 0 : Convert.ToInt32(weightTextBox.Text);

            itemTextBox.Clear();
            weightTextBox.Clear();

            double totalWeight = noOfItems * weightOfItems;

            if (!aRefrigerator.CheckValidity(totalWeight))
            {
                MessageBox.Show("Weight limit exceeded");
                return;
            }

            aRefrigerator.SetWeight(totalWeight);          
            DisplayCurrentAndRemainingWeight();
        }

        private void DisplayCurrentAndRemainingWeight()
        {
            maxWeightTextBox.Text = aRefrigerator.MaxWeight.ToString();
            currentWeightTextBox.Text = aRefrigerator.GetCurrentweight().ToString();
            remainingWeightTextBox.Text = aRefrigerator.GetRemainWeight().ToString();
        }

    }
}
