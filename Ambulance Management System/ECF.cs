using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Ambulance_Management_System
{
     partial class ECF : Form
    {
        public  int index;
        public static Tree2 tree2=new Tree2(null);
        public string driverId;
        public string compoderId;
        public string busNumber;
        public ECF(string destination,string driver,string compoder,string bus)
        {
            this.driverId = driver;
            this.compoderId = compoder;
            this.busNumber = bus;
            InitializeComponent();
            this.time.Text= DateTime.Now.ToShortDateString();
            this.driver.Text = driver;
            this.compoder.Text = compoder;
            this.bus.Text = bus;
            this.destinationAddress.Text = destination;
            loadingECFid();

        }
        void loadingECFid()
        {
            StreamReader sr = new StreamReader("D:/Github/dsa2021g46/Ambulance Management System/ecfid.txt");
            this.index = Int32.Parse(sr.ReadLine());
            this.index = this.index + 1;
            ecfId.Text = this.index.ToString();
            sr.Close();

        }

        private void ECF_Load(object sender, EventArgs e)
        {

        }

        private void submit_Click(object sender, EventArgs e)
        {



            if (this.patientName.Text=="" || this.patientFatherName.Text=="" || this.contactNumber.Text==""||this.cnicNumber.Text==""||this.pickUpAddress.Text=="")
            {
                MessageBox.Show("Please fill the above input fields");
            }
            else
            {
                
                Program.graph.Dijkstra(this.pickUpAddress.Text);
                string date = this.date.Text;
                string update = date.Replace(',', '-');
                ECF_class ecf = new ECF_class(this.ecfId.Text,this.patientName.Text, this.patientFatherName.Text, this.contactNumber.Text, update, this.time.Text, this.cnicNumber.Text, this.pickUpAddress.Text, this.destinationAddress.Text, driverId, compoderId, busNumber);
                ECFNode ecfNode = new ECFNode(ecf, null, null, null);
                tree2.insert(ecfNode);
                MessageBox.Show("Group is Dispatched");
                this.Close();
            }
            StreamWriter sw = new StreamWriter("D:/Github/dsa2021g46/Ambulance Management System/ecfid.txt");
            sw.WriteLine(index);
            sw.Close();
        }

        private void date_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
