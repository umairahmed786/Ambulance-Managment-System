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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            ctwoInvalid.Hide();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string name = ctwoUserName.Text;
            string password = ctwoPassword.Text;
            if(name=="" || password=="" )
            {
                ctwoInvalid.Text = "Please fill the text fields";
                ctwoInvalid.Show();
            }
            else
            {
                if(name=="Admin" || password=="123")
                {
                    mainPage page = new mainPage();
                    page.Show();
                }
                else
                {
                    ctwoInvalid.Text = "Incorrect username or password";
                    ctwoInvalid.Show();
                }
            }

        }
    }
}
