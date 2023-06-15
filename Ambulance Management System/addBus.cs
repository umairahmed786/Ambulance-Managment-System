using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ambulance_Management_System
{
    partial class addBus : Form
    {
        public static LinkedList BusData = new LinkedList();
        public addBus()
        {
            InitializeComponent();
            incompleteInput.Hide();
        }

        private void addingBus_Click(object sender, EventArgs e)
        {
            if(busNameTextBox.Text==""||busColourTextBox.Text==""||modelNumberTextBox.Text==""||numberPlateTextBox.Text=="")
            {
                incompleteInput.Show();
            }
            else
            {
                Bus b = new Bus(busNameTextBox.Text, busColourTextBox.Text, modelNumberTextBox.Text, numberPlateTextBox.Text);
                BusData.insert(new BusNode(b));
                MessageBox.Show("Bus is added successfully");
                this.Close();
            }
        }

        private void addBus_Load(object sender, EventArgs e)
        {

        }
    }
}
