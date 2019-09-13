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
    public partial class CoffeeOrderForm : Form
    {
        private string customerName;
        private string contact;
        private string address;
        private string orderName;
        private int orderValue;
        private int orderQuantity;
        private int totalValue;

        public CoffeeOrderForm()
        {
            InitializeComponent();
        }

        private void InputCustomerName(object sender, EventArgs e)
        {
            customerName = customerNameTextbox.Text;
        }
               

        private void InputContact(object sender, EventArgs e)
        {
            contact = contactTextbox.Text;
        }

        private void StoreContact(object sender, KeyEventArgs e)
        {

        }
               
        private void InputAddress(object sender, EventArgs e)
        {
            address = addressTextbox.Text;
        }
          
    
        private void OrderCombo_SelectedIndexChanged(object sender, EventArgs e)
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


        private void InputQuantity(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && (e.KeyChar != '.');   
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            CalculateTotalPrice();
            DisplayOrderDetails();
        }

        private void CalculateTotalPrice()
        {
            if (orderCombo.Text == "")
            {
                MessageBox.Show("Please selecft coffee type");
                return;
            }

            string quantityTextBoxValue = quantityTextBox.Text;

            if (quantityTextBoxValue == "") orderQuantity = 0;
            else orderQuantity = int.Parse(quantityTextBoxValue);

            if (orderQuantity == 0)
            {
                MessageBox.Show("Please enter order quantity");
                return;
            }

            totalValue = orderQuantity * orderValue;
        }

        private void DisplayOrderDetails()
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
