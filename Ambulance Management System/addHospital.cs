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
     partial class addHospital : Form
    {
        static public DoublyLinklist dll = new DoublyLinklist(null);
        public addHospital()
        {
            InitializeComponent();
        }

        private void addHospital_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Hospital hospital = new Hospital(hospitalName.Text , hospitalAddress.Text, Int32.Parse(hospitalTotalBed.Value.ToString()) , Int32.Parse(hospitalAvailibleBed.Value.ToString()) , hospitalId.Text  , hospitalPassword.Text);
            HospitalNode hn = new HospitalNode(hospital , null , null);
            dll.hospitalAddition(hn);

            //stack.push(hn );



            MessageBox.Show("Hospital is added successfully");
            this.Close();

        }
    }
}
