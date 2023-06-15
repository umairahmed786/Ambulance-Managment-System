using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ambulance_Management_System
{
    class HospitalNode
    {
        public Hospital hospitalObject;
        public HospitalNode next;
        public HospitalNode previous;
        public HospitalNode(Hospital hospitalObject,HospitalNode next,HospitalNode previous)
        {
            this.hospitalObject = hospitalObject;
            this.next = null;
            this.previous = null;
        }
    }
}
