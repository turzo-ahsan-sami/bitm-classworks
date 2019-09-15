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
        List<OrderDetails> customersOrders = new List<OrderDetails>();

        string customerName;
        string customerContact;
        string customerOrder;
        int customerOrderPrice;
        int customerOrderQuantity;
        int customerTotalPrice;

        public CoffeeShop()
        {
            InitializeComponent();
        }

        private void Reset()
        {
            customerName = "";
            customerContact = "";
            customerOrder = "";
            customerOrderPrice = 0;
            customerOrderQuantity = 0;
            customerTotalPrice = 0;

            nameTextBox.Text = "";
            contactTextBox.Text = "";
            orderComboBox.Text = "";
            quantityTextBox.Text = "";
        }

        private void InputName(object sender, EventArgs e)
        {
            customerName = nameTextBox.Text;
        }

        private void InputContact(object sender, EventArgs e)
        {
            customerContact = contactTextBox.Text;
        }

        private void InputOrderType(object sender, EventArgs e)
        {
            customerOrder = orderComboBox.Text.ToLower();
            if (customerOrder == "black") customerOrderPrice = 80;
            else if (customerOrder == "hot") customerOrderPrice = 90;
            else if (customerOrder == "regular") customerOrderPrice = 100;
            else if (customerOrder == "cold") customerOrderPrice = 120;
            CalculateTotalPrice();
        }

        private void InputOrderQuantity(object sender, EventArgs e)
        {
            string textBoxValue = "";

            if (checkTextisNumber(quantityTextBox.Text)) textBoxValue = quantityTextBox.Text;
            else quantityTextBox.Text = textBoxValue;

            if (textBoxValue == "") customerOrderQuantity = 0;
            else customerOrderQuantity = int.Parse(textBoxValue);

            CalculateTotalPrice();
        }

        private void CalculateTotalPrice()
        {
            customerTotalPrice = customerOrderQuantity * customerOrderPrice;
        }

        private void AddCustomerData(object sender, EventArgs e)
        {
            customersOrders.Add(new OrderDetails {
                name = customerName,
                contact = customerContact,
                orderType = customerOrder,
                itemPrice = customerOrderPrice,
                itemQuantity = customerOrderQuantity,
                totalPrice = customerTotalPrice
            });

            DisplayOutput();
        }

        private void DisplayOutput()
        {
            string output = "Coffee Order Details \n\n";           
            int orderCounter = 0;
            foreach (OrderDetails item in customersOrders)
            {
                output += "Order : " + ++orderCounter + "\n"
                            + "Customer : " + item.name + "\n"
                            + "Contact : " + item.contact + "\n"
                            + "Order : " + item.orderType + "\n"
                            + "Price : " + item.itemPrice + "\n"
                            + "Quantity : " + item.itemQuantity + "\n"
                            + "Total Price : " + item.totalPrice + "\n\n";
            }

            outputRichTextBox.Text = output;

            Reset();
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
    }

    class OrderDetails
    {
        public string name { get; set; }
        public string contact { get; set; }
        public string orderType { get; set; }
        public int itemPrice { get; set; }
        public int itemQuantity { get; set; }
        public int totalPrice { get; set; }
    
    }

    
}
