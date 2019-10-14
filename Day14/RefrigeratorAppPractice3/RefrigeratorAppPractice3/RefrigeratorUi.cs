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
        public RefrigeratorUi()
        {
            InitializeComponent();
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            int maxweight = Convert.ToInt32(maxWeightTakeTextBox.Text);
            Refrigerator refrigeratorobj = new Refrigerator(maxweight);

        }

        private void EnterButton_Click(object sender, EventArgs e)
        {
            int item = Convert.ToInt32(itemTextBox.Text);
            int itemweight = Convert.ToInt32(weightTextBox.Text);
            Refrigerator refrigerator = new Refrigerator();
            int current=refrigerator.Currentweight(item, itemweight);
            currentWeightTextBox.Text = current.ToString();
        }
    }
}
