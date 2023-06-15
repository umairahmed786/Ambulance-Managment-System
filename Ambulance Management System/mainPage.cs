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
    partial class mainPage : Form
    {
        public static DispatchedLinkedList dispatchedLinkedList = new DispatchedLinkedList();
        
        public mainPage()
        {
            InitializeComponent();
            date.Text =DateTime.Now.ToLongDateString();
            time.Text = DateTime.Now.ToLongTimeString();
        }

        private void employeeCombobox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void date_Click(object sender, EventArgs e)
        {

        }

        private void addEmployeeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            addEmployee employee = new addEmployee();
            employee.Show();
        }

        private void updateEmployeeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            updateEmployee updateEmployee = new updateEmployee();
            updateEmployee.Show();
        }

        private void deleteEmployeeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            deleteEmployee deleteEmployee = new deleteEmployee();
            deleteEmployee.Show();
        }

        private void addHospitalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            addHospital hospital = new addHospital();
            hospital.Show();
        }

        private void updateHospitalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            updateHospital updateHospital = new updateHospital();
            updateHospital.Show();
        }

        private void deleteHospitalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DeleteHospital deleteHospital = new DeleteHospital();
            deleteHospital.Show();
        }

        private void addBusToolStripMenuItem_Click(object sender, EventArgs e)
        {
            addBus bus = new addBus();
            bus.Show();
        }

        private void updateBusToolStripMenuItem_Click(object sender, EventArgs e)
        {
            updateBus updateBus = new updateBus();
            updateBus.Show();
        }

        private void deleteBusToolStripMenuItem_Click(object sender, EventArgs e)
        {
            deleteBus deleteBus = new deleteBus();
            deleteBus.Show();
        }

        private void mainPage_Load(object sender, EventArgs e)
        {

        }

        private void theme_Click(object sender, EventArgs e)
        {
            
        }
        private void AddBusDataToFile(StreamWriter s)
        {
            BusNode b = addBus.BusData.head;
            while(b!=null)
            {
                string data = b.busObject.busName + "," + b.busObject.busColour + "," + b.busObject.busModelNumber + "," + b.busObject.busNumberPlate;
                s.WriteLine(data);
                b = b.next;
            }
        }
        private void SaveBusData()
        {
            StreamWriter sw4 = new StreamWriter("D:/Github/dsa2021g46/Ambulance Management System/busData.txt");
            AddBusDataToFile(sw4);
            sw4.Close();
            
        }

        private void AddHospitalDataToFile(StreamWriter s)
        {
            HospitalNode hn = addHospital.dll.head;
            while (hn != null)
            {
                s.WriteLine(hn.hospitalObject.hospitalName + "," + hn.hospitalObject.hospitalAddress + "," + hn.hospitalObject.totalBeds + "," + hn.hospitalObject.availableBeds + "," + hn.hospitalObject.hospitalID + "," + hn.hospitalObject.hospitalPassword);
                hn = hn.next;
            }

        }

        private void AddEmployeeDataToFile(StreamWriter s)
        {
            void inTraversal(Node head , StreamWriter s1)
            {
                if (head != null)
                {
                    inTraversal(head.leftNode,  s1);

                    s.WriteLine(head.employeeObject.employeeName + "," + head.employeeObject.employeeID + "," + head.employeeObject.employeeAddess + "," + head.employeeObject.employeePhoneNumber + "," + head.employeeObject.employeeEmail + "," + head.employeeObject.employeeCNIC + "," + head.employeeObject.employeeDateOfBirth + "," + head.employeeObject.employeeMaritalStatus + "," + head.employeeObject.employeeJobType + "," + head.employeeObject.employeeShift + "," + head.employeeObject.employeeGender);
               
                    inTraversal(head.rightNode,  s1);

                }
            }
            inTraversal(addEmployee.tree.head , s );

            
        }

        private void AddEcfDataToFile(StreamWriter s)
        {
            void inTraversal(ECFNode head1, StreamWriter s1)
            {
                if (head1 != null)
                {
                    inTraversal(head1.leftNode, s1);

                    s.WriteLine(head1.ecf.id + "," + head1.ecf.name + "," + head1.ecf.fatherName + "," + head1.ecf.contactNumber + "," + head1.ecf.date + "," + head1.ecf.time + "," + head1.ecf.CNIC + "," + head1.ecf.pickupAddress + "," + head1.ecf.destinationAddress + "," + head1.ecf.driver + "," + head1.ecf.compoder + "," + head1.ecf.bus);

                    inTraversal(head1.rightNode, s1);

                }
            }
            inTraversal(ECF.tree2.head, s);


        }

        private void saveEcfData()
        {
            StreamWriter sw5 = new StreamWriter("D:/Github/dsa2021g46/Ambulance Management System/ecfData.txt");
            AddEcfDataToFile(sw5);
            sw5.Close();
        }

        private void saveEmployeeData()
        {
            StreamWriter sw4 = new StreamWriter("D:/Github/dsa2021g46/Ambulance Management System/employeeData.txt");
            AddEmployeeDataToFile(sw4);
            sw4.Close();
        }

        private void saveHospitalData()
        {
            StreamWriter sw4 = new StreamWriter("D:/Github/dsa2021g46/Ambulance Management System/hospitalData.txt");
            AddHospitalDataToFile(sw4);
            sw4.Close();


        }


        private void mainPage_FormClosing(object sender, FormClosingEventArgs e)
        {


            saveEcfData();
            SaveBusData();
            saveHospitalData();
            saveEmployeeData();



         }

       

        private void hospitalToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void hospitalLoginToolStripMenuItem_Click(object sender, EventArgs e)
        {
            hospitalLogin hl = new hospitalLogin();
            hl.Show();

        }

        public void shift1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            attendenceSheetEmployee attendence = new attendenceSheetEmployee();

            attendence.Show();
            attendence.loadDataOfAttendence(shift1ToolStripMenuItem.Text);
            
        }

        private void shift2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            attendenceSheetEmployee attendence = new attendenceSheetEmployee();
            attendence.Show();
            attendence.loadDataOfAttendence(shift2ToolStripMenuItem.Text);
           
        }

        private void shift3ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            attendenceSheetEmployee attendence = new attendenceSheetEmployee();
            attendence.Show();
            attendence.loadDataOfAttendence(shift3ToolStripMenuItem.Text);
            
        }

        private void receiveCall_Click(object sender, EventArgs e)
        {
            RescueGroup rg = attendenceSheetEmployee.queue.Dequeue();
            StackNode sn = attendenceSheetEmployee.stack.top();
            HospitalNode hos=null;
            if (sn!=null && rg!=null)
            {
                hos = sn.hospitalNode;
                hos.hospitalObject.availableBeds = hos.hospitalObject.availableBeds - 1;
                if (hos.hospitalObject.availableBeds == 0)
                {
                    attendenceSheetEmployee.stack.pop();
                }
            }
            
            if (rg==null|| hos==null)
            {
                MessageBox.Show("Can't rescue due to limitation of sources");
            }
            else
            {
                DispatchedNode dn = new DispatchedNode(rg);
                dispatchedLinkedList.insert(dn);
                ECF ecf = new ECF(hos.hospitalObject.hospitalAddress,rg.driver.employeeObject.employeeID, rg.helper.employeeObject.employeeID,rg.ambulance.busObject.busNumberPlate);
                ecf.Show();
                
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void ambulanceManagementSystem_Click(object sender, EventArgs e)
        {

        }

        private void dispatchedGroupToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DispatchedGroup dg = new DispatchedGroup();
            dg.Show();
        }
    }
}
