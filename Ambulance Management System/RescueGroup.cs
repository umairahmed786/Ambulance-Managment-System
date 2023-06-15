using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ambulance_Management_System
{
    class RescueGroup
    {
        public int id;
        public Node driver;
        public Node helper;
        public BusNode ambulance;
        public RescueGroup next;

        public RescueGroup( Node driver, Node helper, BusNode ambulance, int id)
        {
            this.id = id;
            this.driver = driver;
            this.helper = helper;
            this.ambulance = ambulance;
        }
    }
}
