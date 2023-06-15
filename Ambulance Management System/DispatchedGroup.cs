using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ambulance_Management_System
{
    partial class DispatchedGroup : Form
    {
        
        public DispatchedGroup()
        {
            InitializeComponent();
        }

        private void DispatchedGroup_Load(object sender, EventArgs e)
        {
            var col1 = new DataGridViewTextBoxColumn();
            var col2 = new DataGridViewTextBoxColumn();
            var col3 = new DataGridViewTextBoxColumn();
            var col4 = new DataGridViewTextBoxColumn();
            var col5 = new DataGridViewCheckBoxColumn();


            col1.HeaderText = "Group ID";
            col1.Name = "column1";
            col2.HeaderText = "Driver ID";
            col2.Name = "column2";
            col3.HeaderText = "Compoder ID";
            col3.Name = "column3";
            col4.HeaderText = "Bus Number";
            col4.Name = "Column4";
            col5.HeaderText = "Returned";
            col5.Name = "column5";

            dataGridViewOfGroup.Columns.AddRange(new DataGridViewColumn[] { col1, col2, col3, col4, col5 });


            DispatchedNode dn = mainPage.dispatchedLinkedList.head;

            while(dn!=null)
            {
                dataGridViewOfGroup.Rows.Add(dn.rescueGroup.id, dn.rescueGroup.driver.employeeObject.employeeID, dn.rescueGroup.helper.employeeObject.employeeID, dn.rescueGroup.ambulance.busObject.busNumberPlate, false);
                dn = dn.next;
            }
            
        }

        private void submit_Click(object sender, EventArgs e)
        {
            var data =new List<DispatchedNode>();
            DispatchedNode dn1 = mainPage.dispatchedLinkedList.head;
            while(dn1!=null)
            {
                data.Add(dn1);
                dn1 = dn1.next;
            }
            DispatchedNode dn2 = mainPage.dispatchedLinkedList.head;
            foreach (DataGridViewRow row in dataGridViewOfGroup.Rows)
            {
                DataGridViewCheckBoxCell chk = row.Cells[4] as DataGridViewCheckBoxCell;
                DataGridViewTextBoxCell chk2 = row.Cells[0] as DataGridViewTextBoxCell;
                if (Convert.ToBoolean(chk.Value) == true)
                {
                    attendenceSheetEmployee.queue.Enqueue(dn2.rescueGroup);
                    data.Remove(dn2);
                }
                dn2 = dn2.next;
                if(dn2==null)
                {
                    break;
                }
            }
            mainPage.dispatchedLinkedList.head = null;
            var array = data.ToArray();
            for(int x=0;x<array.Length;x++)
            {
                mainPage.dispatchedLinkedList.insert(array[x]);
            }
            MessageBox.Show("Selected groups are ready to Rescue the patient");
            this.Close();
        }
    }
}
