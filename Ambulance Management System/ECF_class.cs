using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ambulance_Management_System
{
    class ECF_class
    {
        public string id;
        public string name;
        public string fatherName;
        public string contactNumber;
        public string date;
        public string time;
        public string CNIC;
        public string pickupAddress;
        public string destinationAddress;
        public string driver;
        public string compoder;
        public string bus;
        public ECF_class(string id,string name, string fatherName, string contactNumber, string dateTime,string time, string CNIC, string pickupAddress, string destinationAddress,string driver,string compoder,string bus)
        {
            this.driver = driver;
            this.compoder = compoder;
            this.bus = bus;
            this.id = id;
            this.name = name;
            this.fatherName = fatherName;
            this.contactNumber = contactNumber;
            this.date = dateTime;
            this.time = time;
            this.CNIC = CNIC;
            this.pickupAddress = pickupAddress;
            this.destinationAddress = destinationAddress;
        }
    }
}
