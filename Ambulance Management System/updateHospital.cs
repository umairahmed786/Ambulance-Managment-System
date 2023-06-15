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
     partial class updateHospital : Form
    {
        public updateHospital()
        {
            InitializeComponent();
        }

        private void hospitalAvailibleBed_ValueChanged(object sender, EventArgs e)
        {

        }

        private void updateHospital_Load(object sender, EventArgs e)
        {
            
        }

        public   void receivingHospitalNode(HospitalNode hn)
        {
            name.Text = hn.hospitalObject.hospitalName;
            address.Text = hn.hospitalObject.hospitalAddress;
            totalBed.Value = hn.hospitalObject.totalBeds;
            availibleBed.Value = hn.hospitalObject.availableBeds;
            hospitalId.Text = hn.hospitalObject.hospitalID;
            hospitalPassword.Text = hn.hospitalObject.hospitalPassword;
        }

        private void update_Click(object sender, EventArgs e)
        {
            hospitalLogin.updatingHospitalNode(name.Text, address.Text, Int32.Parse(totalBed.Value.ToString()), Int32.Parse(availibleBed.Value.ToString()), hospitalId.Text, hospitalPassword.Text);
            MessageBox.Show("data is successfully updated");
            this.Close();


        }
    }
}
