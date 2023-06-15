using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ambulance_Management_System
{
    class BusNode
    {
        public Bus busObject;
        public BusNode next;
        public BusNode(Bus busObject)
        {
            this.busObject = busObject;
            this.next = null;
        }
    }
}
