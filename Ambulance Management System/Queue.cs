using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ambulance_Management_System
{
    class Queue
    {
        public RescueGroup head;
        public RescueGroup tail;
        public Queue()
        {
            this.head=this.tail = null;
        }

        public void Enqueue(RescueGroup x)
        {
            if(this.tail!=null)
            {
                tail.next = x;
                tail = tail.next;
            }
            else
            {
                this.tail = x;
                this.head = x;
            }
        }
        public RescueGroup Dequeue()
        {
            if (this.head != null)
            {
                RescueGroup point = this.head;
                head = point.next;
                if(head==null)
                {
                    head = tail = null;
                }
                return point;
            }
            return null;
        }
    }
}
