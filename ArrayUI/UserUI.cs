using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ArrayUI
{
    public partial class UserUI : Form
    {

        List<string> UserNames = new List<string>();
        List<int> Age = new List<int>();


        public UserUI()
        {
            InitializeComponent();
        }

        

        private void InputName(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(char.IsLetter(e.KeyChar) || e.KeyChar == (char)Keys.Back || e.KeyChar == (char)Keys.Space);
        }

        private void Add(object sender, EventArgs e)
        {
            try
            {
                if (!String.IsNullOrEmpty(ageTextBox.Text)) Age.Add(Convert.ToInt32(ageTextBox.Text));
                else return;
            }
            catch(Exception exception)
            {
                MessageBox.Show(exception.Message);
                return;
            }

            UserNames.Add(nameTextBox.Text);
            DisplayOutput();
        }


        

        private void DisplayOutput()
        {
            string message = "User List: \n\n";
            foreach(string name in UserNames)
            {
                message += "Name : " + name + " Age : " + Age[UserNames.IndexOf(name)] + "\n";
            }

            richTextBox.Text = message;
        }


        private void ShowNames(object sender, EventArgs e)
        {
            DisplayOutput();
        }

        private void nameTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void UserUI_Load(object sender, EventArgs e)
        {
        
        }

        
    }
}
