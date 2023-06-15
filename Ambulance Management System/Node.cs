using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ambulance_Management_System
{
    class Node
    {
        public Employee employeeObject;
        public Node leftNode;
        public Node rightNode;
        public Node parent;
        public string color;
        public Node(Employee employeeObject, Node leftNode, Node rightNode, Node parent)
        {
            this.employeeObject = employeeObject;
            this.leftNode = leftNode;
            this.rightNode = rightNode;
            this.parent = parent;
            this.color = "";
        }
    }
       
}
