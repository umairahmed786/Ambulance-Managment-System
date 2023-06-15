using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ambulance_Management_System
{
    class DoublyLinklist
    {
        public HospitalNode head;
        public DoublyLinklist(HospitalNode head)
        {
            this.head = null;
        }
        public void hospitalAddition(HospitalNode hn)
        {
            if (this.head == null)
            {
                this.head = hn;
            }
            else
            {
                HospitalNode n = this.head;
                while(n.next!=null)
                {
                    n = n.next;
                }
                n.next = hn;
            }
        }

        public HospitalNode searchHospitalNode(string name , string id , string password)
        {


            HospitalNode tempHospitalNode = addHospital.dll.head;
            while (tempHospitalNode != null)
            {

                if (tempHospitalNode.hospitalObject.hospitalName == name && tempHospitalNode.hospitalObject.hospitalID == id && tempHospitalNode.hospitalObject.hospitalPassword == password)
                {
                    updateHospital uh = new updateHospital();
                    uh.Show();
                    uh.receivingHospitalNode(tempHospitalNode);
                    break;
                }


                tempHospitalNode = tempHospitalNode.next;
            }

            return tempHospitalNode;
            

        }
    }
}
