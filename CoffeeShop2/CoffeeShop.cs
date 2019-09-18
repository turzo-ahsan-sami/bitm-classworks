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
            customerOrder = orderComboBox.Text;
            customerOrderPrice = MenuItemPriceList.SetItemPrice(customerOrder);
            CalculateTotalPrice();
        }

        private void InputOrderQuantity(object sender, EventArgs e)
        {
            string textBoxValue = "";

            if (CustomLibrary.CheckTextisNumber(quantityTextBox.Text)) textBoxValue = quantityTextBox.Text;
            else quantityTextBox.Text = textBoxValue;

            customerOrderQuantity = (textBoxValue == "") ? 0 : int.Parse(textBoxValue);
           
            CalculateTotalPrice();
        }

        private void CalculateTotalPrice()
        {
            customerTotalPrice = customerOrderQuantity * customerOrderPrice;
        }

        private void AddCustomerData(object sender, EventArgs e)
        {
            outputRichTextBox.Text = "";
            string message = "";

            if (customerName == "") message = "Please input name.";
            if (customerContact == "") message = "Please input contact.";
            if (customerOrderPrice == 0) message = "Please select an item.";
            if (customerOrderQuantity == 0) message = "Please input order quantity.";
            if (HasDuplicateContacts(customerContact)) message = "Contact already exists. Please provide a different contact.";               
            
            
            if (message != "")
            {
                MessageBox.Show(message);
                return;
            }
            else
            {
                // List                
                OrderDetails NewCustomer = new OrderDetails(customerName, customerContact, customerOrder, customerOrderPrice, customerOrderQuantity, customerTotalPrice);
                customersOrders.Add(NewCustomer);
                outputRichTextBox.Text = NewCustomer.ShowOrderDetails();
                Reset();

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

                // DisplayOutput();

            }

            

        }

        private void DisplayOutput(object sender, EventArgs e)
        {
            outputRichTextBox.Text = "";
            string output = "Coffee Order Details \n\n";

            if (customersOrders.Count == 0)
            {
                MessageBox.Show("Please add order.");
                return; 
            }
            else
            {
                // List
                foreach (OrderDetails item in customersOrders)
                {
                    output += "Order : " + (customersOrders.IndexOf(item) + 1) + "\n"
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
        }



        private bool HasDuplicateContacts(string contact)
        {
            if (customersOrders.Count == 0 || contact == "") return false;

            foreach(OrderDetails item in customersOrders)
            {
                if(item.contact == contact)
                {
                    return true;
                }
            }

            return false;
           
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

        public string ShowOrderDetails()
        {
            string output = "Customer Order \n\n";
            
            output += "Customer : " + this.name + "\n"
                        + "Contact : " + this.contact + "\n"
                        + "Order : " + this.orderType + "\n"
                        + "Price : " + this.itemPrice + "\n"
                        + "Quantity : " + this.itemQuantity + "\n"
                        + "Total Price : " + this.totalPrice + "\n\n";

            return output;
        }
    }


    class MenuItemPriceList
    {

        public static Dictionary<string, int> MenuItems = new Dictionary<string, int>()
                                            {
                                                { "RegularCoffee", 80 },
                                                { "HotCoffee", 90 },
                                                { "ColdCoffee", 100 },
                                                { "BlackCoffee", 120 }
                                            };

       
        public static int SetItemPrice(string orderItem)
        {
            int price = 0;
            if (orderItem == "") return price;

            foreach (KeyValuePair<string, int> item in MenuItems)
            {
                if(orderItem == item.Key) price = item.Value;
            }

            return price;
        }
    }


}
