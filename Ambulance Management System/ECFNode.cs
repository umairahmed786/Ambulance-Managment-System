using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ambulance_Management_System
{
    class ECFNode
    {
        public ECF_class ecf;
        public ECFNode leftNode;
        public ECFNode rightNode;
        public ECFNode parent;
        public string color;
        public ECFNode(ECF_class ecf, ECFNode leftNode, ECFNode rightNode, ECFNode parent)
        {
            this.ecf = ecf;
            this.leftNode = leftNode;
            this.rightNode = rightNode;
            this.parent = parent;
            this.color = "";
        }
    }
}
