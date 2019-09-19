using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace CoffeeShop2
{
    public partial class CoffeeShopCustomerOrder : Form
    {
        List<OrderDetails> customersOrders = new List<OrderDetails>();
        OrderDetails order = new OrderDetails();

        public CoffeeShopCustomerOrder()
        {
            InitializeComponent();
            Reset();
        }

        private void Reset()
        {
            order.name = "";
            order.contact = "";
            order.menuItem = "";
            order.itemPrice = 0;
            order.itemPrice = 0;
            order.totalPrice = 0;

            nameTextBox.Text = "";
            contactTextBox.Text = "";
            orderComboBox.Text = "";
            quantityTextBox.Text = "";
        }

        private void InputName(object sender, EventArgs e)
        {
            order.name = nameTextBox.Text;
        }

        private void InputContact(object sender, EventArgs e)
        {
            order.contact = contactTextBox.Text;
        }

        private void InputOrderType(object sender, EventArgs e)
        {
            order.menuItem = orderComboBox.Text;
            order.itemPrice = MenuItemPriceList.SetItemPrice(order.menuItem);
            CalculateTotalPrice();
        }

        private void InputOrderQuantity(object sender, EventArgs e)
        {
            string textBoxValue = "";
            if (CustomLibrary.CheckTextisNumber(quantityTextBox.Text)) textBoxValue = quantityTextBox.Text;
            else quantityTextBox.Text = textBoxValue;

            order.itemQuantity = (textBoxValue == "") ? 0 : int.Parse(textBoxValue);
            CalculateTotalPrice();
        }

        private void CalculateTotalPrice()
        {
            order.totalPrice = order.itemQuantity * order.itemPrice;
        }

        private void AddCustomerData(object sender, EventArgs e)
        {
            outputRichTextBox.Text = "";
            string message = "";

            try
            {
                if (order.name == "") message = "Please input name.";
                if (order.contact == "") message = "Please input contact.";
                if (order.menuItem == "") message = "Please select an item.";
                if (order.itemQuantity == 0) message = "Please input order quantity.";
                if (CustomLibrary.HasDuplicateContacts(customersOrders, order.contact)) message = "Contact already exists. Please provide a different contact.";


                if (message != "")
                {
                    MessageBox.Show(message);
                    return;
                }
                else
                {
                    OrderDetails newOrder = new OrderDetails(order.name, order.contact, order.menuItem, order.itemPrice, order.itemQuantity, order.totalPrice);
                    customersOrders.Add(newOrder);
                    outputRichTextBox.Text = newOrder.ShowOrderDetails();
                    Reset();
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
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
                foreach (OrderDetails order in customersOrders)
                {
                    output += "Order : " + (customersOrders.IndexOf(order) + 1) + "\n"
                                + "Customer : " + order.name + "\n"
                                + "Contact : " + order.contact + "\n"
                                + "Order : " + order.menuItem + "\n"
                                + "Price : " + order.itemPrice + "\n"
                                + "Quantity : " + order.itemQuantity + "\n"
                                + "Total Price : " + order.totalPrice + "\n\n";
                }

                outputRichTextBox.Text = output;
                Reset();
            }
        }
                             
    }

    class OrderDetails
    {
        public string name { get; set; }
        public string contact { get; set; }
        public string menuItem { get; set; }
        public int itemPrice { get; set; }
        public int itemQuantity { get; set; }
        public int totalPrice { get; set; }

        public OrderDetails(string name, string contact, string menuItem, int itemPrice, int itemQuantity, int totalPrice)
        {
            this.name = name;
            this.contact = contact;
            this.menuItem = menuItem;
            this.itemPrice = itemPrice;
            this.itemQuantity = itemQuantity;
            this.totalPrice = totalPrice;
        }

        public OrderDetails()
        {
        }

        public string ShowOrderDetails()
        {
            string output = "Customer Order \n\n";

            output += "Customer : " + this.name + "\n"
                        + "Contact : " + this.contact + "\n"
                        + "Order : " + this.menuItem + "\n"
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
                if (orderItem == item.Key) price = item.Value;
            }

            return price;
        }
    }


}
