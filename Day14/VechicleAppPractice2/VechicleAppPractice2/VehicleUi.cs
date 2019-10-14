using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VechicleAppPractice2
{
    public partial class VehicleUi : Form
    {
        Vehicle vehicle = new Vehicle();
        public VehicleUi()
        {
            InitializeComponent();
        }

        private void CreateButton_Click(object sender, EventArgs e)
        {
            vehicle.VehicleName = vehicleNameTextBox.Text;
            vehicle.RegistrationNumber = regNoTextBox.Text;

            vehicleNameTextBox.Clear();
            regNoTextBox.Clear();
        }

        private void EnterButton_Click(object sender, EventArgs e)
        {
            string speed = speedTextBox.Text;
            if (string.IsNullOrEmpty(speed)) speed = "0";
            vehicle.SetSpeed(Convert.ToDouble(speed));
            speedTextBox.Clear();
        }

        private void ShowButton_Click(object sender, EventArgs e)
        {
            vehicleNameTextBox.Text = vehicle.VehicleName;
            regNoTextBox.Text = vehicle.RegistrationNumber;

            maxSpeedTextBox.Text = vehicle.GetMaxSpeed().ToString();
            minSpeedTextBox.Text = vehicle.GetMinSpeed().ToString();
            averageSpeedTextBox.Text = vehicle.GetAverageSpeed().ToString();
        }

        
    }
}
