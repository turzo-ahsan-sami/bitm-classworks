using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PersonInformationAppWalkthrough2
{
    public partial class PersonInformationUi : Form
    {
        Person aPerson;

        public PersonInformationUi()
        {
            InitializeComponent();
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            string firstName = firstNameTextBox.Text.ToUpper().Trim();
            string middleName = middleNameTextBox.Text.ToUpper().Trim();
            string lastName = lastNameTextBox.Text.ToUpper().Trim();

            aPerson = new Person(firstName, middleName, lastName);

            firstNameTextBox.Clear();
            middleNameTextBox.Clear();
            lastNameTextBox.Clear();
        }

        private void ShowButton_Click(object sender, EventArgs e)
        {
            firstNameTextBox.Text = aPerson.FirstName;
            middleNameTextBox.Text = aPerson.MiddleName;
            lastNameTextBox.Text = aPerson.LastName;
                        
            fullNameTextBox.Text = aPerson.GetFullName();
            reverseNameTextBox.Text = aPerson.GetReverseName();
        }
    }
}
