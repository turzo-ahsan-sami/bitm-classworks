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
        // using list
        List<OrderDetails> customersOrders = new List<OrderDetails>();

        // using array of objects
        //const int arraySize = 10;
        //int index = 0;
        //OrderDetails[] ordersArray = new OrderDetails[arraySize];

        string customerName;
        string customerContact;
        string customerOrder;
        int customerOrderPrice;
        int customerOrderQuantity;
        int customerTotalPrice;

        public CoffeeShop()
        {
            InitializeComponent();
            Reset();
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
            if (customerOrder == "") customerOrderPrice = 0;
            else if (customerOrder == "black") customerOrderPrice = 80;
            else if (customerOrder == "hot") customerOrderPrice = 90;
            else if (customerOrder == "regular") customerOrderPrice = 100;
            else if (customerOrder == "cold") customerOrderPrice = 120;
            CalculateTotalPrice();
        }

        private void InputOrderQuantity(object sender, EventArgs e)
        {
            string textBoxValue = "";

            if (CustomLibrary.CheckTextisNumber(quantityTextBox.Text)) textBoxValue = quantityTextBox.Text;
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

            string message = "";
            if (customerName == "") message = "Please input name.";
            if (customerContact == "") message = "Please input contact.";
            if (customerOrderPrice == 0) message = "Please select an item.";
            if (customerOrderQuantity == 0) message = "Please input order quantity.";

            if (message != "") MessageBox.Show(message);

            else
            {


                // List                
                customersOrders.Add(new OrderDetails(customerName, customerContact, customerOrder, customerOrderPrice, customerOrderQuantity, customerTotalPrice));
                
                // Array
                //if (index < arraySize)
                //{
                //    ordersArray[index] = new OrderDetails(customerName, customerContact, customerOrder, customerOrderPrice, customerOrderQuantity, customerTotalPrice);
                //    index++;
                //}
                //else
                //{
                //    MessageBox.Show("Array is full");
                //}

                DisplayOutput();
            }
        }

        private void DisplayOutput()
        {
            string output = "Coffee Order Details \n\n";           

            // List
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
            

            // Array
            //for (int i = 0; i < index; i++)
            //{
            //    output += "Order : " + (i+1) + "\n"
            //                + "Customer : " + ordersArray[i].name + "\n"
            //                + "Contact : " + ordersArray[i].contact + "\n"
            //                + "Order : " + ordersArray[i].orderType + "\n"
            //                + "Price : " + ordersArray[i].itemPrice + "\n"
            //                + "Quantity : " + ordersArray[i].itemQuantity + "\n"
            //                + "Total Price : " + ordersArray[i].totalPrice + "\n\n";
            //}

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

        public OrderDetails(string name, string contact, string orderType, int itemPrice, int itemQuantity, int totalPrice)
        {
            this.name = name;
            this.contact = contact;
            this.orderType = orderType;
            this.itemPrice = itemPrice;
            this.itemQuantity = itemQuantity;
            this.totalPrice = totalPrice;
        }
    }

    
}
