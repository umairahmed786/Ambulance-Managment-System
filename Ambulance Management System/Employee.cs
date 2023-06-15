using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ambulance_Management_System
{
    public class Employee
    {
        public string employeeName;
        public string employeeID;
        public string employeeAddess;
        public string employeePhoneNumber;
        public string employeeEmail;
        public string employeeCNIC;
        public string employeeDateOfBirth;
        public string employeeShift;
        public string employeeMaritalStatus;
        public string employeeGender;
        public string employeeJobType;


        public Employee(string employeeName, string employeeID, string employeeAddess, string employeePhoneNumber, string employeeEmail, string employeeCNIC, string employeeDateOfBirth, string employeeShift, string employeeMaritalStatus, string employeeGender , string employeeJobType)
        {
            this.employeeName = employeeName;
            this.employeeID = employeeID;
            this.employeeAddess = employeeAddess;
            this.employeePhoneNumber = employeePhoneNumber;
            this.employeeEmail = employeeEmail;
            this.employeeCNIC = employeeCNIC;
            this.employeeDateOfBirth = employeeDateOfBirth;
            this.employeeShift = employeeShift;
            this.employeeMaritalStatus = employeeMaritalStatus;
            this.employeeGender = employeeGender;
            this.employeeJobType = employeeJobType;

        }

    }
}
