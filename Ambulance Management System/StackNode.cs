using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ambulance_Management_System
{
    class StackNode
    {
        public HospitalNode hospitalNode;
        public StackNode next;
        public StackNode(HospitalNode hn)
        {
            this.hospitalNode = hn;
            this.next = null;
        }
    }
}
