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
    public partial class deleteBus : Form
    {
        BusNode b;
        public deleteBus()
        {
            InitializeComponent();
            searchLabel.Hide();
        }

        private void search_Click(object sender, EventArgs e)
        {
            if (searchingBusTextbox.Text != "")
            {
                string numberPlate = searchingBusTextbox.Text;
                b = addBus.BusData.search(numberPlate);
                if (b != null)
                {
                    busColourTextBox.Text = b.busObject.busColour;
                    busNameTextBox.Text = b.busObject.busName;
                    modelNumberTextBox.Text = b.busObject.busModelNumber;
                    numberPlateTextBox.Text = b.busObject.busNumberPlate;
                }
                else
                {
                    searchLabel.Text = "No data found";
                    searchLabel.Show();
                }
            }
            else
            {
                searchLabel.Text = "Please search the bus you want to deleye";
                searchLabel.Show();
            }
        }

        private void deleteBusButton_Click(object sender, EventArgs e)
        {
            if (b != null)
            {
                string numberPlate = numberPlateTextBox.Text;
                addBus.BusData.delete(numberPlate);
                MessageBox.Show("Bus is deleted successfully");
                this.Close();
            }
            else
            {
                searchLabel.Text = "Please search the bus you want to delete";
                searchLabel.Show();
            }
        }
    }
}
