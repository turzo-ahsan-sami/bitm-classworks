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
    public partial class CoffeeShop : Form
    {
        private string customerName;
        private string contact;
        private string address;
        private string orderName;
        private int orderValue;
        private int orderQuantity;
        private int totalValue;

        public CoffeeShop()
        {
            InitializeComponent();
        }

        private void storeCustomerName(object sender, KeyEventArgs e)
        {
            customerName = customerNameTextbox.Text;
        }

        private void storeContact(object sender, KeyEventArgs e)
        {
            contact = contactTextbox.Text;
        }

        private void storeAddress(object sender, KeyEventArgs e)
        {
            address = addressTextbox.Text;
        }

    
        private void orderCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            orderName = orderCombo.Text;
            if (orderName == "black")
            {
                orderValue = 100;
            }
            else if (orderName == "hot")
            {
                orderValue = 150;
            }
            else if (orderName == "cold")
            {
                orderValue = 200;
            }
        }


        private void storeQuantity(object sender, KeyEventArgs e)
        {
            if (quantityTextBox.Text == "")
            {
                quantityTextBox.Text = "0";
            }

            orderQuantity = Convert.ToInt32(quantityTextBox.Text);
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            if (orderQuantity == 0)
            {
                MessageBox.Show("Please enter order quantity");
                return;
            }
            if (orderCombo.Text == "")
            {
                MessageBox.Show("Please selecft coffee type");
                return;
            }
            totalValue = orderQuantity * orderValue;
            displayOutput();
        }

        private void displayOutput()
        {
            orderDetailsRichTextbox.Text =
                "Name: " + customerName + "\n"
                + "Contact: " + contact + "\n"
                + "Address: " + address + "\n"
                + "Quantity: " + orderQuantity + "\n"
                + "Order: " + orderCombo.Text + "\n"
                + "Total Value: " + totalValue + "\n";
        }
    }
}
