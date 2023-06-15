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
    public partial class updateEmployee : Form
    {
        Node tempNode;
        public updateEmployee()
        {
            InitializeComponent();
        }

        private void searchEmployeeTextBox_TextChanged(object sender, EventArgs e)
        {

        }
        string search;
        // static Tree tree = new Tree(null);
        private void searchEmployeeUpdate_Click(object sender, EventArgs e)
        {
             search = searchEmployeeTextBox.Text;
            tempNode =  addEmployee.tree.employeeSearch( addEmployee.tree.head , Int32.Parse(search) );

            if(tempNode != null)
            {
                employeeNameTextBox.Text = tempNode.employeeObject.employeeName;
                employeeIDTextbox.Text = tempNode.employeeObject.employeeID;
                textBox3employeeAddressTextBox.Text = tempNode.employeeObject.employeeAddess;
                employeeNumberTextBox.Text = tempNode.employeeObject.employeePhoneNumber;
                employeeEmailTextBox.Text = tempNode.employeeObject.employeeEmail;
                employeeCNICTextBox.Text = tempNode.employeeObject.employeeCNIC;
                employeeDateOfBirthTextBox.Text = tempNode.employeeObject.employeeDateOfBirth;
                employeeJobTypeComboBox.Text = tempNode.employeeObject.employeeJobType;
                employeeShiftComboBox.Text = tempNode.employeeObject.employeeShift;
                employeeMaritalStatusTextbox.Text = tempNode.employeeObject.employeeMaritalStatus;

            }
            if (tempNode.employeeObject.employeeGender == "male" )
            {
                maleRadioButton.Checked = true;
                femaleRadioButton.Checked = false;
            }
            if (tempNode.employeeObject.employeeGender == "female")
            {
                maleRadioButton.Checked = false;
                femaleRadioButton.Checked = true;
            }

        }

        private void updateEmployee_Load(object sender, EventArgs e)
        {
            













        }

        private void updateEmployeeButton_Click(object sender, EventArgs e)
        {
            //Node tempNode = addEmployee.tree.employeeSearch(addEmployee.tree.head, Int32.Parse(search));
            tempNode.employeeObject.employeeName = employeeNameTextBox.Text;
            tempNode.employeeObject.employeeID = employeeIDTextbox.Text;
            tempNode.employeeObject.employeeAddess = textBox3employeeAddressTextBox.Text;
            tempNode.employeeObject.employeePhoneNumber = employeeNumberTextBox.Text;
            tempNode.employeeObject.employeeEmail = employeeEmailTextBox.Text;
            tempNode.employeeObject.employeeCNIC = employeeCNICTextBox.Text;
            tempNode.employeeObject.employeeDateOfBirth = employeeDateOfBirthTextBox.Text;
            tempNode.employeeObject.employeeJobType = employeeJobTypeComboBox.Text;
            tempNode.employeeObject.employeeShift = employeeShiftComboBox.Text;
            tempNode.employeeObject.employeeMaritalStatus = employeeMaritalStatusTextbox.Text;
            MessageBox.Show("Employee is updated successfully");
            this.Close();

        }
    }
}
