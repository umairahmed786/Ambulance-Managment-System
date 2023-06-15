using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ambulance_Management_System
{
    class DispatchedLinkedList
    {
        public DispatchedNode head;
        public DispatchedLinkedList()
        {
            this.head = null;
        }
        public void insert(DispatchedNode obj)
        {
            if (head == null)
            {
                head = obj;
            }
            else
            {
                obj.next = head;
                head = obj;
            }
        }
        public DispatchedNode search(string id)
        {
            DispatchedNode n = this.head;
            while (n != null)
            {
                if (n.rescueGroup.id.ToString() == id)
                {
                    return n;
                }
                n = n.next;
            }
            return null;
        }
        public DispatchedNode delete(string id)
        {
            DispatchedNode n = head;
            if (n == null)
            {
                return null;
            }
            while (n.next != null)
            {
                if (n.rescueGroup.id.ToString() == id)
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
