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
    public partial class deleteEmployee : Form
    {
        Node tempNode;
        string search;
        public deleteEmployee()
        {
            InitializeComponent();
        }

        private void searchEmployeeDelete_Click(object sender, EventArgs e)
        {
            search = searchEmployeeTextBox.Text;
            tempNode = addEmployee.tree.employeeSearch(addEmployee.tree.head, Int32.Parse(search));

            if (tempNode != null)
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
            if (tempNode.employeeObject.employeeGender == "male")
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

        private void deleteEmployee_Load(object sender, EventArgs e)
        {

        }

        private void deleteEmployeeButton_Click(object sender, EventArgs e)
        {
            
            addEmployee.tree.Delete(addEmployee.tree.head, Int32.Parse(tempNode.employeeObject.employeeID));
            MessageBox.Show("Employee is deleted successfully");
            this.Close();
        }
    }
}
