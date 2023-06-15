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
    
     partial class hospitalLogin : Form
    {
        static public HospitalNode tempHospitalNode;
        static public updateHospital uh = new updateHospital();
        static public attendenceSheetEmployee Attendence = new attendenceSheetEmployee();


        public hospitalLogin()
        {
            InitializeComponent();
            hospitalInvalid.Hide();
            
        }

         private void button1_Click(object sender, EventArgs e)
        {
            tempHospitalNode = addHospital.dll.searchHospitalNode( hospitalName.Text,   hospitalId.Text   ,   hospitalPassword.Text);
            if(tempHospitalNode==null)
            {
                MessageBox.Show("No data found");
            }
            
            else
            {

                uh.receivingHospitalNode(tempHospitalNode);
                this.Close();
            }



        }

        public static void updatingHospitalNode(string name1, string address1, int totalBeds1, int availableBeds1, string id1, string password1)
        {
            tempHospitalNode.hospitalObject.hospitalName = name1;
            tempHospitalNode.hospitalObject.hospitalAddress = address1;
            tempHospitalNode.hospitalObject.totalBeds = totalBeds1;
            tempHospitalNode.hospitalObject.availableBeds = availableBeds1;
            tempHospitalNode.hospitalObject.hospitalID = id1;
            tempHospitalNode.hospitalObject.hospitalPassword = password1;
            attendenceSheetEmployee.pushingHospitalInStack();

        }

        private void hospitalLogin_Load(object sender, EventArgs e)
        {

        }
    }
}
