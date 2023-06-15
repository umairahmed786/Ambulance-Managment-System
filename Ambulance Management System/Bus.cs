using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ambulance_Management_System
{
    class Bus
    {
        public string busName;
        public string busColour;
        public string busModelNumber;
        public string busNumberPlate;

        public Bus(string busName, string busColour, string busModelNumber, string busNumberPlate)
        {
            this.busName = busName;
            this.busColour = busColour;
            this.busModelNumber = busModelNumber;
            this.busNumberPlate = busNumberPlate;
        }
    }
}
