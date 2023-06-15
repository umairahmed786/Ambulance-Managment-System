using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ambulance_Management_System
{
    class Tree2
    {
        public ECFNode head = null;
        public Tree2(ECFNode head)
        {
            this.head = head;
        }
        void LeftRotate(ECFNode x)
        {
            ECFNode y = x.rightNode;
            x.rightNode = y.leftNode;
            if (y.leftNode != null)
            {
                y.leftNode.parent = x;
            }
            y.parent = x.parent;
            if (x.parent == null)
                this.head = y;
            else if (x == x.parent.leftNode)
                x.parent.leftNode = y;
            else
            {
                x.parent.rightNode = y;
            }
            y.leftNode = x;
            x.parent = y;
        }
        void RightRotate(ECFNode x)
        {
            ECFNode y = x.leftNode;
            x.leftNode = y.rightNode;
            if (y.rightNode != null)
            {
                y.rightNode.parent = x;
            }
            y.parent = x.parent;
            if (x.parent == null)
                this.head = y;
            else if (x == x.parent.rightNode)
                x.parent.rightNode = y;
            else
            {
                x.parent.leftNode = y;
            }
            y.rightNode = x;
            x.parent = y;
        }
        void InsertFixup(ECFNode k)
        {
            while (k.parent.color == "Red")
            {
                if (k.parent == k.parent.parent.rightNode)
                {
                    ECFNode u = k.parent.parent.leftNode;
                    if (u.color == "Red")
                    {
                        u.color = "Black";
                        k.parent.color = "Black";
                        k.parent.parent.color = "Red";
                        k = k.parent.parent;
                    }
                    else
                    {
                        if (k == k.parent.leftNode)
                        {
                            k = k.parent;
                            this.RightRotate(k);
                        }
                        k.parent.color = "Black";
                        k.parent.parent.color = "Red";
                        this.LeftRotate(k.parent.parent);
                    }
                }
                else
                {
                    ECFNode u = k.parent.parent.rightNode;
                    if (u.color == "Red")
                    {
                        k.parent.color = "Black";
                        u.color = "Black";
                        k.parent.parent.color = "Red";
                        k = k.parent.parent;
                    }
                    else
                    {
                        if (k == k.parent.rightNode)
                            k = k.parent;
                        this.LeftRotate(k);
                        k.parent.color = "Black";
                        k.parent.parent.color = "Red";
                        this.RightRotate(k.parent.parent);
                    }
                }
                if (k == this.head)
                {
                    break;
                }
            }
            this.head.color = "Black";
        }



        public void insert(ECFNode z)
        {
            ECFNode y = null;
            ECFNode x = this.head;
            while (x != null)
            {
                y = x;
                if (Int32.Parse(z.ecf.id) < Int32.Parse(x.ecf.id))
                {
                    x = x.leftNode;
                }
                else
                {
                    x = x.rightNode;
                }
            }
            z.parent = y;
            if (y == null)
            {
                this.head = z;
            }
            else if (Int32.Parse(z.ecf.id) < Int32.Parse(y.ecf.id))
            {
                y.leftNode = z;
            }
            else
            {
                y.rightNode = z;
            }
            if (z.parent == null)
            {
                z.color = "Black";
                return;
            }
            if (z.parent.parent == null)
            {
                return;
            }
            InsertFixup(z);
        }
        public ECFNode search(ECFNode head, int value)
        {
            while (Int32.Parse(head.ecf.id) != value)
            {
                if (value < Int32.Parse(head.ecf.id))
                {
                    head = head.leftNode;
                }
                else
                {
                    head = head.rightNode;
                }
            }
            return head;
        }

    }
}

