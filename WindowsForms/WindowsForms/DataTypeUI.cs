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
    public partial class DataTypeUI : Form
    {
        public DataTypeUI()
        {
            InitializeComponent();
        }

        private void DataTypeUI_Load(object sender, EventArgs e)
        {

        }

        private void showItems_Click(object sender, EventArgs e)
        {
            var selectedItem = itemList.Text;

            if (selectedItem == "")
            {
                MessageBox.Show("Please select an item");
            }
            else if(selectedItem == "none")
            {
                MessageBox.Show("No item selected");
            }
            else
            {
                MessageBox.Show("Selected item: " + selectedItem);
            }
        }
    }
}
