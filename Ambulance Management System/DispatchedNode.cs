using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ambulance_Management_System
{
    class DispatchedNode
    {
        public RescueGroup rescueGroup;
        public DispatchedNode next;
        public DispatchedNode(RescueGroup rescue)
        {
            this.rescueGroup = rescue;
            this.next = null;
        }
    }
}
