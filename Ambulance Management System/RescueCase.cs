using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ambulance_Management_System
{
    class RescueCase
    {
        string patientID;
        ECF_class ecfObject;
        Bus busObject;
        Hospital hospitalObject;

        public RescueCase(string patientID, ECF_class ecfObject, Bus busObject, Hospital hospitalObject)
        {
            this.patientID = patientID;
            this.ecfObject = ecfObject;
            this.busObject = busObject;
            this.hospitalObject = hospitalObject;
        }
    }
}
