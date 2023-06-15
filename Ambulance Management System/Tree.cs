using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ambulance_Management_System
{
    class Tree
    {

        public Node head = null;
        public Tree(Node head)
        {
            this.head = head;
        }
        void LeftRotate(Node x)
        {
            Node y = x.rightNode;
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
        void RightRotate(Node x)
        {
            Node y = x.leftNode;
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
        void InsertFixup(Node k)
        {
            while (k.parent.color == "Red")
            {
                if (k.parent == k.parent.parent.rightNode)
                {
                    Node u = k.parent.parent.leftNode;
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
                    Node u = k.parent.parent.rightNode;
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
        public void Delete(Node node,int key)
        {
            Node x;
            Node z=null;
            while(node!=null)
            {
                if(Int32.Parse(node.employeeObject.employeeID)==key)
                {
                    z=node;
                }
                if(Int32.Parse(node.employeeObject.employeeID) <= key)
                {
                    node = node.rightNode;
                }
                else
                {
                    node = node.leftNode;
                }
            }
            if(z==null)
            {
                return;
            }
            Node y = z;
            if(z.leftNode==null)
            {
                x = z.rightNode;
                this.Transplant(z, z.rightNode);
            }
            else
            {
                if (z.rightNode == null)
                {
                    x = z.leftNode;
                    this.Transplant(z, z.leftNode);
                }
                else
                {
                    y = this.Minimum(z.rightNode);
                    x = y.rightNode;
                    if(y.parent==z)
                    {
                        x.parent = y;
                    }
                    else
                    {
                        this.Transplant(y, y.rightNode);
                        y.rightNode = z.rightNode;
                        y.rightNode.parent = y;
                    }
                    this.Transplant(z, y);
                    y.leftNode = z.leftNode;
                    y.leftNode.parent = y;
                    y.color = z.color;
                }
            }
            if(y.color=="Black")
            {
                this.DeleteFix(x);
            }
        }

        public void Transplant(Node u,Node v)
        {
            if(u.parent==null)
            {
                this.head = v;
            }
            else if(u==u.parent.leftNode)
            {
                u.parent.leftNode = v;
            }
            else
            {
                u.parent.rightNode = v;
            }
                v.parent = u.parent;
        }

        public Node Minimum(Node u)
        {
            while(u.leftNode!=null)
            {
                u = u.leftNode;
            }
            return u;
        }

        public void DeleteFix(Node x)
        {
            Node s;
            while(x!=this.head && x.color=="Black")
            {
                if(x==x.parent.leftNode)
                {
                    s = x.parent.rightNode;
                    if(s.color=="Red")
                    {
                        s.color = "Black";
                        x.parent.color = "Red";
                        this.LeftRotate(x.parent);
                        s = x.parent.rightNode;
                    }
                    if (s.leftNode.color == "Black" && s.rightNode.color == "Black")
                    {
                        s.color = "Red";
                        x = x.parent;
                    }
                    else
                    {
                        if (s.rightNode.color == "Black")
                        {
                            s.leftNode.color = "Black";
                            s.color = "Red";
                            this.RightRotate(s);
                            s = x.parent.rightNode;
                        }
                        s.color = x.parent.color;
                        x.parent.color = "Black";
                        s.rightNode.color = "Black";
                        this.LeftRotate(x.parent);
                        x = this.head;
                    }
                }
                else
                {
                    s = x.parent.leftNode;
                    if(s.color=="Red")
                    {
                        s.color = "Black";
                        x.parent.color = "Red";
                        this.RightRotate(x.parent);
                        s = x.parent.leftNode;
                    }
                    if(s.rightNode.color=="Black" && s.rightNode.color=="Black")
                    {
                        s.color = "Red";
                        x = x.parent;
                    }
                    else
                    {
                        if(s.leftNode.color=="Black")
                        {
                            s.rightNode.color = "Black";
                            s.color = "Red";
                            this.LeftRotate(s);
                            s = x.parent.leftNode;
                        }
                        s.color = x.parent.color;
                        x.parent.color = "Black";
                        s.leftNode.color = "Black";
                        this.RightRotate(x.parent);
                        x = this.head;

                    }
                }
            }
            x.color = "Black";
        }



        public void employeeAddition(Node z)
        {
            Node y = null;
            Node x = this.head;
            while (x != null)
            {
                y = x;
                if (Int32.Parse(z.employeeObject.employeeID) < Int32.Parse(x.employeeObject.employeeID))
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
            else if (Int32.Parse(z.employeeObject.employeeID) < Int32.Parse(y.employeeObject.employeeID))
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
        public Node employeeSearch(Node head, int value)
        {
            while (Int32.Parse(head.employeeObject.employeeID) != value)
            {
                if (value < Int32.Parse(head.employeeObject.employeeID))
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

