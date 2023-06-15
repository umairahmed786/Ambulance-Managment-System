using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ambulance_Management_System
{
    class Stack
    {
        public StackNode head;

        public void push(StackNode key)
        {
            if (this.head == null)
            {
                this.head = key;
                this.head.next = null;
            }
            else
            {
                StackNode temp = this.head;
                this.head = key;
                this.head.next = temp;
            }
        }
        public void pop()
        {
            if (this.head != null)
            {
                this.head = this.head.next;
            }

        }

        public StackNode top()
        {
            return this.head;
        }



    }
}
