using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CoffeeShop2
{
    public partial class CoffeeShop : Form
    {
        const int arraySize = 10;
        int index = 0;

        string[] customerName = new string[arraySize];
        string[] customerContact = new string[arraySize];
        string[] customerOrder = new string[arraySize];
        int[] customerOrderPrice = new int[arraySize];
        int[] customerOrderQuantity = new int[arraySize];
        int[] customerTotalPrice = new int[arraySize];

        public CoffeeShop()
        {
            InitializeComponent();
        }

        private void AddCustomerData(object sender, EventArgs e)
        {
            if(index < arraySize)
            {

                index++;
            }
            else
            {
                MessageBox.Show("Array is full.");
            }
        }
    }
}
