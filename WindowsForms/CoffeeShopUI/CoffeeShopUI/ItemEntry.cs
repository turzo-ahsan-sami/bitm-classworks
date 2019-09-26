using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Data.SqlClient;

namespace CoffeeShopUI
{
    public partial class ItemEntry : Form
    {
        public ItemEntry()
        {
            InitializeComponent();
            showAll();
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            string connectionString = @"Server=PC-301-29\SQLEXPRESS; DataBase=CoffeeShop; Integrated Security=True";

            SqlConnection sqlConnection = new SqlConnection(connectionString);
           
            string commandString = @"INSERT INTO Items (Name, Price) VALUES ('"
                                   + nameTextBox.Text 
                                   +"',"
                                   + priceTextBox.Text
                                   +")";

            SqlCommand sqlCommand = new SqlCommand(commandString, sqlConnection);

            sqlConnection.Open();

            sqlCommand.ExecuteNonQuery();

            sqlConnection.Close();

            MessageBox.Show("Successfully Added");
            nameTextBox.Text = "";
            priceTextBox.Text = "";

            showAll();
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            string connectionString = @"Server=PC-301-29\SQLEXPRESS; DataBase=CoffeeShop; Integrated Security=True";

            SqlConnection sqlConnection = new SqlConnection(connectionString);

            string commandString = @"DELETE FROM Items WHERE NAME = '"
                                   + nameTextBox.Text
                                   + "'";

            SqlCommand sqlCommand = new SqlCommand(commandString, sqlConnection);

            sqlConnection.Open();

            sqlCommand.ExecuteNonQuery();

            sqlConnection.Close();

            MessageBox.Show("Successfully Deleted");
            nameTextBox.Text = "";
            priceTextBox.Text = "";

            showAll();
        }

        private void showAllButton_Click(object sender, EventArgs e)
        {
            showAll();
        }

        private void showAll()
        {
            string connectionString = @"Server=PC-301-29\SQLEXPRESS; DataBase=CoffeeShop; Integrated Security=True";

            SqlConnection sqlConnection = new SqlConnection(connectionString);

            string commandString = @"SELECT * FROM Items";

            SqlCommand sqlCommand = new SqlCommand(commandString, sqlConnection);

            sqlConnection.Open();

            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);

            DataTable dataTable = new DataTable();
            sqlDataAdapter.Fill(dataTable);

            showAllDataGridView.DataSource = dataTable;

            sqlConnection.Close();
        }

        private void updateButton_Click(object sender, EventArgs e)
        {
            string connectionString = @"Server=PC-301-29\SQLEXPRESS; DataBase=CoffeeShop; Integrated Security=True";

            SqlConnection sqlConnection = new SqlConnection(connectionString);

            string commandString = @"UPDATE Items SET Price = "
                                   + priceTextBox.Text
                                   + " WHERE Name = '"
                                   + nameTextBox.Text
                                   + "'";

            SqlCommand sqlCommand = new SqlCommand(commandString, sqlConnection);

            sqlConnection.Open();

            sqlCommand.ExecuteNonQuery();

            sqlConnection.Close();

            MessageBox.Show("Successfully Updated");
            nameTextBox.Text = "";
            priceTextBox.Text = "";

            showAll();
        }
    }
}
