using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ambulance_Management_System
{
    class Hospital
    {
        public string hospitalName;
        public string hospitalAddress;
        public int totalBeds;
        public int availableBeds;
        public string hospitalID;
        public string hospitalPassword;

        public Hospital(string hospitalName, string hospitalAddress, int totalBeds, int availableBeds, string hospitalID, string hospitalPassword)
        {
            this.hospitalName = hospitalName;
            this.hospitalAddress = hospitalAddress;
            this.totalBeds = totalBeds;
            this.availableBeds = availableBeds;
            this.hospitalID = hospitalID;
            this.hospitalPassword = hospitalPassword;
        }


    }
}
