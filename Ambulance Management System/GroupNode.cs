using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ambulance_Management_System
{
    class GroupNode
    {
        public RescueCase rescueGroup;
        public GroupNode next;
        public GroupNode(RescueCase rescueGroup )
        {
            this.rescueGroup = rescueGroup;
            this.next = null;
        }
    }
}
