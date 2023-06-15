using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ambulance_Management_System
{
    class LinkedList
    {
        public BusNode head;
        public LinkedList()
        {
            this.head = null;
        }
        public void insert(BusNode obj)
        {
            if(head==null)
            {
                head = obj;
            }
            else
            {
                obj.next = head;
                head = obj;
            }
        }
        public BusNode search(string numberPlate)
        {
            BusNode n=this.head;
            while(n!=null)
            {
                if(n.busObject.busNumberPlate==numberPlate)
                {
                    return n;
                }
                n = n.next;
            }
            return null;
        }
        public BusNode delete(string numberPlate)
        {
            BusNode n = head;
            if(n==null)
            {
                return null;
            }
            while(n.next!=null)
            {
                if(n.next.busObject.busNumberPlate==numberPlate)
                {
                    n.next = n.next.next;
                    return n.next;
                }
                n = n.next;
            }
            return null;
        }
    }
}
