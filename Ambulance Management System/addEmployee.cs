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

     partial class addEmployee : Form
    {
         static public Tree tree = new Tree(null);
         int index;
        public addEmployee()
        {
            InitializeComponent();

            
            invalidInputs.Hide();
            StreamReader sr = new StreamReader("D:/Github/dsa2021g46/Ambulance Management System/Employeeid.txt");
            index = Int32.Parse(sr.ReadLine());
            index = index + 1;
            employeeId.Text = index.ToString();
            sr.Close();
            
        }

        private void addEmployee_Load(object sender, EventArgs e)
        {

        }

        private void addEmployeeButton_Click(object sender, EventArgs e)
        {
            StreamWriter sw = new StreamWriter("D:/Github/dsa2021g46/Ambulance Management System/Employeeid.txt");
            sw.Write(index);
            sw.Close();

            string gender="";
            bool isChecked = maleRadioButton.Checked;
            if(isChecked)
            {
                gender = maleRadioButton.Text;
            }
            else
            {
                isChecked = femaleRadioButton.Checked;
                if (isChecked)
                {
                    gender = femaleRadioButton.Text;
                }
            }
            if (gender==""||employeeNameTextBox.Text == "" || employeeId.Text == "" || textBox3employeeAddressTextBox.Text == "" || employeeNumberTextBox.Text == "" || employeeEmailTextBox.Text == "" || employeeCNICTextBox.Text == "" || employeeDateOfBirthTextBox.Text == "" || employeeShift.Text == "" || employeeMaritalStatusTextbox.Text == "" || employeeJobTypeComboBox.Text == "")
            {
                invalidInputs.Show();
            }
            else
            {
                Employee employee = new Employee(employeeNameTextBox.Text, employeeId.Text, textBox3employeeAddressTextBox.Text, employeeNumberTextBox.Text, employeeEmailTextBox.Text, employeeCNICTextBox.Text, employeeDateOfBirthTextBox.Text, employeeShiftComboBox.Text, employeeMaritalStatusTextbox.Text, gender, employeeJobTypeComboBox.Text);
                Node node = new Node(employee, null, null, null);
                tree.employeeAddition( node);


                //FileStream fs = new FileStream("C:/Users/Online computer/Documents/GitHub/dsa2021g46/Ambulance Management System/employeeData.txt", FileMode.Append, FileAccess.Write);
                //StreamWriter sw1 = new StreamWriter(fs);
                //Console.WriteLine();
                //string str = Console.ReadLine();
                //sw1.WriteLine(employee.employeeName + "," + employee.employeeID + "," + employee.employeeAddess + "," + employee.employeePhoneNumber + "," + employee.employeeEmail + "," + employee.employeeCNIC + "," +  employee.employeeDateOfBirth + "," + employee.employeeMaritalStatus + "," +    employee.employeeJobType + "," + employee.employeeShift + "," +  employee.employeeGender                 );
                //sw1.Flush();
                //sw1.Close();
                //fs.Close();


                MessageBox.Show("Employee is added successfully");
                this.Close();
            }

        }
    }
}
