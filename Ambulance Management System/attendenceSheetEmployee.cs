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
    
    partial class attendenceSheetEmployee : Form
    {
        public string shiftType;
        public int index;
        static public Stack stack = new Stack();
        static public Queue queue = new Queue();

        public static mainPage mp = new mainPage();
         static public void pushingHospitalInStack()
        {
            HospitalNode hn = addHospital.dll.head;
            stack.head = null;
            while (hn != null)
            {
                if (hn.hospitalObject.availableBeds > 0)
                {
                    stack.push(new StackNode(hn));
                }
                hn = hn.next;
            }
        }


        public attendenceSheetEmployee()
        {
            InitializeComponent();
            //loadDataOfAttendence();






        }

        public  void loadDataOfAttendence(string shiftType)
        {
            this.shiftType = shiftType;

            var col1 = new DataGridViewTextBoxColumn();
            var col2 = new DataGridViewTextBoxColumn();

            var col3 = new DataGridViewCheckBoxColumn();
            var col4 = new DataGridViewTextBoxColumn();
            var col5 = new DataGridViewCheckBoxColumn();


            col3.HeaderText = "Employee Attendance";
            col3.Name = "column3";
            col2.HeaderText = "Employee ID";
            col2.Name = "column2";
            col1.HeaderText = "Employee Name";
            col1.Name = "column1";
            col4.HeaderText = "Bus Number";
            col4.Name = "Column4";
            col5.HeaderText = "Bus Attendance";
            col5.Name = "column5";

            dataGridViewOfEmployees.Columns.AddRange(new DataGridViewColumn[] { col1, col2, col3, col4, col5 });
            //dataGridViewOfEmployees.Rows.Add("ALI","56", true,"ds",false);


            var employeeArray = new List<Node>();
            var busArray = new List<BusNode>();

            Node root = addEmployee.tree.head;
            BusNode head = addBus.BusData.head;


            void inTraversal(Node temp)
            {
                if (temp != null)
                {
                    inTraversal(temp.leftNode);
                    if (temp.employeeObject.employeeShift == shiftType)
                    {
                        employeeArray.Add(temp);
                    }
                    inTraversal(temp.rightNode);

                }
            }


            inTraversal(root);


            void search(BusNode temp)
            {

                BusNode n = temp;
                while (n != null)
                {
                    busArray.Add(n);
                    n = n.next;
                }
            }
            search(head);

            var updatedEmployeeArray = employeeArray.ToArray();
            var updatedBusArray = busArray.ToArray();
            int len;
            int arrayLength = 0;
            if (updatedEmployeeArray.Length > updatedBusArray.Length)
            {
                len = updatedEmployeeArray.Length - updatedBusArray.Length;
                for (int i = 0; i < len; i++)
                {
                    busArray.Add(new BusNode(null));
                }
                updatedBusArray = busArray.ToArray();
            }

            if (updatedEmployeeArray.Length < updatedBusArray.Length)
            {
                len = updatedBusArray.Length - updatedEmployeeArray.Length;
                for (int i = 0; i < len; i++)
                {
                    employeeArray.Add(new Node(null, null, null, null));
                }
                updatedEmployeeArray = employeeArray.ToArray();


            }

            if (updatedEmployeeArray.Length >= updatedBusArray.Length)
            {
                arrayLength = updatedEmployeeArray.Length;
            }

            if (updatedEmployeeArray.Length < updatedBusArray.Length)
            {
                arrayLength = updatedBusArray.Length;
            }

            string freeSpace = "null";

            for (int i = 0; i < arrayLength; i++)
            {
                if (updatedEmployeeArray[i].employeeObject == null)
                {
                    
                    dataGridViewOfEmployees.Rows.Add(freeSpace, freeSpace, false, updatedBusArray[i].busObject.busNumberPlate, false);
                }

                if (updatedBusArray[i].busObject == null)
                {
                    
                    dataGridViewOfEmployees.Rows.Add(updatedEmployeeArray[i].employeeObject.employeeName, updatedEmployeeArray[i].employeeObject.employeeID, false, freeSpace, false);

                }

                if (updatedBusArray[i].busObject != null && updatedEmployeeArray[i].employeeObject != null)
                {
                   
                    dataGridViewOfEmployees.Rows.Add(updatedEmployeeArray[i].employeeObject.employeeName, updatedEmployeeArray[i].employeeObject.employeeID, false, updatedBusArray[i].busObject.busNumberPlate, false);

                }


            }

        }



        private void dataGridViewOfEmployees_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void attendenceSheetEmployee_Load(object sender, EventArgs e)
        {

        }

        private void attendenceSheetEmployee_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Hide();
        }

        private void submit_Click(object sender, EventArgs e)
        {
            
            var employeeArray = new List<Node>();
            var busArray = new List<BusNode>();

            var presentDriver = new List<Node>();
            var presentCompoder = new List<Node>();
            var presentbus = new List<BusNode>();


            Node root = addEmployee.tree.head;
            BusNode head = addBus.BusData.head;


            void inTraversal(Node temp)
            {
                if (temp != null)
                {
                    inTraversal(temp.leftNode);
                    if (temp.employeeObject.employeeShift == shiftType)
                    {
                        employeeArray.Add(temp);
                    }
                    inTraversal(temp.rightNode);

                }
            }


            inTraversal(root);


            void search(BusNode temp)
            {

                BusNode n = temp;
                while (n != null)
                {
                    busArray.Add(n);
                    n = n.next;
                }
            }
            search(addBus.BusData.head);
            
            var updatedEmployeeArray = employeeArray.ToArray();
            var updatedBusArray = busArray.ToArray();
            int index = 0;
            foreach (DataGridViewRow row in dataGridViewOfEmployees.Rows)
            {
                DataGridViewCheckBoxCell chk = row.Cells[2] as DataGridViewCheckBoxCell;
                DataGridViewTextBoxCell chk2 = row.Cells[0] as DataGridViewTextBoxCell;
                if (Convert.ToString(chk2.Value) != "null")
                {
                    if (Convert.ToBoolean(chk.Value) == true)
                    {
                        if (updatedEmployeeArray[index].employeeObject.employeeJobType == "Driver")
                        {
                            presentDriver.Add(updatedEmployeeArray[index]);
                        }
                        else
                        {
                            presentCompoder.Add(updatedEmployeeArray[index]);
                        }
                    }
                    index = index + 1;
                }
            }
            index = 0;
            foreach (DataGridViewRow row in dataGridViewOfEmployees.Rows)
            {
                DataGridViewCheckBoxCell chk = row.Cells[4] as DataGridViewCheckBoxCell;
                DataGridViewTextBoxCell chk2 = row.Cells[3] as DataGridViewTextBoxCell;
                if (Convert.ToString(chk2.Value) != "null")
                {
                    if (Convert.ToBoolean(chk.Value) == true)
                    {
                        presentbus.Add(updatedBusArray[index]);
                    }
                    index = index + 1;
                }
            }
            var updatedPresentDriver = presentDriver.ToArray();
            var updatedPresentCompoder = presentCompoder.ToArray();
            var updatedPresentBus = presentbus.ToArray();
            index = 0;
            if(updatedPresentDriver.Length<=updatedPresentCompoder.Length && updatedPresentDriver.Length <= updatedPresentBus.Length)
            {
                index = updatedPresentDriver.Length;
            }
            else if(updatedPresentCompoder.Length <= updatedPresentDriver.Length && updatedPresentCompoder.Length <= updatedPresentBus.Length)
            {
                index = updatedPresentCompoder.Length;
            }
            else
            {
                index = updatedPresentBus.Length;
            }
            StreamReader sr = new StreamReader("D:/Github/dsa2021g46/Ambulance Management System/rescueGroupId.txt");
            this.index = Int32.Parse(sr.ReadLine());
            sr.Close();
            for (int i=0;i<index;i++)
            {
                this.index = this.index + 1;
                RescueGroup rg = new RescueGroup(updatedPresentDriver[i], updatedPresentCompoder[i], updatedPresentBus[i],this.index);
                queue.Enqueue(rg);
            }

            StreamWriter sw = new StreamWriter("D:/Github/dsa2021g46/Ambulance Management System/rescueGroupId.txt");
            sw.WriteLine(this.index);
            sw.Close();


            pushingHospitalInStack();




            MessageBox.Show("Attendance is saved successfully");
            this.Close();
        }

        private void dataGridViewOfEmployees_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
