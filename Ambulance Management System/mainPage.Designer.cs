
namespace Ambulance_Management_System
{
    partial class mainPage
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(mainPage));
            this.panel1 = new System.Windows.Forms.Panel();
            this.time = new System.Windows.Forms.Label();
            this.date = new System.Windows.Forms.Label();
            this.logo = new System.Windows.Forms.PictureBox();
            this.ambulanceManagementSystem = new System.Windows.Forms.Label();
            this.receiveCall = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.theme = new System.Windows.Forms.PictureBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.employeeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addEmployeeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.updateEmployeeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteEmployeeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hospitalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addHospitalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.updateHospitalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteHospitalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hospitalLoginToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.busToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addBusToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.updateBusToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteBusToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.attendanceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.shift1ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.shift2ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.shift3ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dispatchedGroupToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logo)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.theme)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel1.Controls.Add(this.time);
            this.panel1.Controls.Add(this.date);
            this.panel1.Controls.Add(this.logo);
            this.panel1.Controls.Add(this.ambulanceManagementSystem);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1346, 135);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // time
            // 
            this.time.AutoSize = true;
            this.time.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.time.Location = new System.Drawing.Point(941, 85);
            this.time.Name = "time";
            this.time.Size = new System.Drawing.Size(56, 25);
            this.time.TabIndex = 3;
            this.time.Text = "Time";
            // 
            // date
            // 
            this.date.AutoSize = true;
            this.date.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.date.Location = new System.Drawing.Point(249, 85);
            this.date.Name = "date";
            this.date.Size = new System.Drawing.Size(53, 25);
            this.date.TabIndex = 2;
            this.date.Text = "Date";
            this.date.Click += new System.EventHandler(this.date_Click);
            // 
            // logo
            // 
            this.logo.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.logo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("logo.BackgroundImage")));
            this.logo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.logo.Location = new System.Drawing.Point(13, 16);
            this.logo.Name = "logo";
            this.logo.Size = new System.Drawing.Size(187, 106);
            this.logo.TabIndex = 1;
            this.logo.TabStop = false;
            // 
            // ambulanceManagementSystem
            // 
            this.ambulanceManagementSystem.AutoSize = true;
            this.ambulanceManagementSystem.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ambulanceManagementSystem.ForeColor = System.Drawing.Color.Red;
            this.ambulanceManagementSystem.Location = new System.Drawing.Point(260, 16);
            this.ambulanceManagementSystem.Name = "ambulanceManagementSystem";
            this.ambulanceManagementSystem.Size = new System.Drawing.Size(763, 58);
            this.ambulanceManagementSystem.TabIndex = 0;
            this.ambulanceManagementSystem.Text = "Ambulance Management System";
            this.ambulanceManagementSystem.Click += new System.EventHandler(this.ambulanceManagementSystem_Click);
            // 
            // receiveCall
            // 
            this.receiveCall.ForeColor = System.Drawing.Color.LimeGreen;
            this.receiveCall.Location = new System.Drawing.Point(951, 39);
            this.receiveCall.Name = "receiveCall";
            this.receiveCall.Size = new System.Drawing.Size(175, 33);
            this.receiveCall.TabIndex = 3;
            this.receiveCall.Text = "Receive Call";
            this.receiveCall.UseVisualStyleBackColor = true;
            this.receiveCall.Click += new System.EventHandler(this.receiveCall_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.receiveCall);
            this.panel3.Controls.Add(this.theme);
            this.panel3.Controls.Add(this.menuStrip1);
            this.panel3.Location = new System.Drawing.Point(12, 153);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1126, 425);
            this.panel3.TabIndex = 2;
            // 
            // theme
            // 
            this.theme.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("theme.BackgroundImage")));
            this.theme.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.theme.Location = new System.Drawing.Point(-1, 39);
            this.theme.Name = "theme";
            this.theme.Size = new System.Drawing.Size(1128, 418);
            this.theme.TabIndex = 0;
            this.theme.TabStop = false;
            this.theme.Click += new System.EventHandler(this.theme_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.employeeToolStripMenuItem,
            this.hospitalToolStripMenuItem,
            this.busToolStripMenuItem,
            this.attendanceToolStripMenuItem,
            this.dispatchedGroupToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1126, 28);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // employeeToolStripMenuItem
            // 
            this.employeeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addEmployeeToolStripMenuItem,
            this.updateEmployeeToolStripMenuItem,
            this.deleteEmployeeToolStripMenuItem});
            this.employeeToolStripMenuItem.Name = "employeeToolStripMenuItem";
            this.employeeToolStripMenuItem.Size = new System.Drawing.Size(89, 24);
            this.employeeToolStripMenuItem.Text = "Employee";
            // 
            // addEmployeeToolStripMenuItem
            // 
            this.addEmployeeToolStripMenuItem.Name = "addEmployeeToolStripMenuItem";
            this.addEmployeeToolStripMenuItem.Size = new System.Drawing.Size(211, 26);
            this.addEmployeeToolStripMenuItem.Text = "Add Employee";
            this.addEmployeeToolStripMenuItem.Click += new System.EventHandler(this.addEmployeeToolStripMenuItem_Click);
            // 
            // updateEmployeeToolStripMenuItem
            // 
            this.updateEmployeeToolStripMenuItem.Name = "updateEmployeeToolStripMenuItem";
            this.updateEmployeeToolStripMenuItem.Size = new System.Drawing.Size(211, 26);
            this.updateEmployeeToolStripMenuItem.Text = "Update Employee";
            this.updateEmployeeToolStripMenuItem.Click += new System.EventHandler(this.updateEmployeeToolStripMenuItem_Click);
            // 
            // deleteEmployeeToolStripMenuItem
            // 
            this.deleteEmployeeToolStripMenuItem.Name = "deleteEmployeeToolStripMenuItem";
            this.deleteEmployeeToolStripMenuItem.Size = new System.Drawing.Size(211, 26);
            this.deleteEmployeeToolStripMenuItem.Text = "Delete Employee";
            this.deleteEmployeeToolStripMenuItem.Click += new System.EventHandler(this.deleteEmployeeToolStripMenuItem_Click);
            // 
            // hospitalToolStripMenuItem
            // 
            this.hospitalToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addHospitalToolStripMenuItem,
            this.updateHospitalToolStripMenuItem,
            this.deleteHospitalToolStripMenuItem,
            this.hospitalLoginToolStripMenuItem});
            this.hospitalToolStripMenuItem.Name = "hospitalToolStripMenuItem";
            this.hospitalToolStripMenuItem.Size = new System.Drawing.Size(79, 24);
            this.hospitalToolStripMenuItem.Text = "Hospital";
            this.hospitalToolStripMenuItem.Click += new System.EventHandler(this.hospitalToolStripMenuItem_Click);
            // 
            // addHospitalToolStripMenuItem
            // 
            this.addHospitalToolStripMenuItem.Name = "addHospitalToolStripMenuItem";
            this.addHospitalToolStripMenuItem.Size = new System.Drawing.Size(201, 26);
            this.addHospitalToolStripMenuItem.Text = "Add Hospital";
            this.addHospitalToolStripMenuItem.Click += new System.EventHandler(this.addHospitalToolStripMenuItem_Click);
            // 
            // updateHospitalToolStripMenuItem
            // 
            this.updateHospitalToolStripMenuItem.Name = "updateHospitalToolStripMenuItem";
            this.updateHospitalToolStripMenuItem.Size = new System.Drawing.Size(201, 26);
            this.updateHospitalToolStripMenuItem.Text = "Update Hospital";
            this.updateHospitalToolStripMenuItem.Click += new System.EventHandler(this.updateHospitalToolStripMenuItem_Click);
            // 
            // deleteHospitalToolStripMenuItem
            // 
            this.deleteHospitalToolStripMenuItem.Name = "deleteHospitalToolStripMenuItem";
            this.deleteHospitalToolStripMenuItem.Size = new System.Drawing.Size(201, 26);
            this.deleteHospitalToolStripMenuItem.Text = "Delete Hospital";
            this.deleteHospitalToolStripMenuItem.Click += new System.EventHandler(this.deleteHospitalToolStripMenuItem_Click);
            // 
            // hospitalLoginToolStripMenuItem
            // 
            this.hospitalLoginToolStripMenuItem.Name = "hospitalLoginToolStripMenuItem";
            this.hospitalLoginToolStripMenuItem.Size = new System.Drawing.Size(201, 26);
            this.hospitalLoginToolStripMenuItem.Text = "Hospital Login";
            this.hospitalLoginToolStripMenuItem.Click += new System.EventHandler(this.hospitalLoginToolStripMenuItem_Click);
            // 
            // busToolStripMenuItem
            // 
            this.busToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addBusToolStripMenuItem,
            this.updateBusToolStripMenuItem,
            this.deleteBusToolStripMenuItem});
            this.busToolStripMenuItem.Name = "busToolStripMenuItem";
            this.busToolStripMenuItem.Size = new System.Drawing.Size(46, 24);
            this.busToolStripMenuItem.Text = "Bus";
            // 
            // addBusToolStripMenuItem
            // 
            this.addBusToolStripMenuItem.Name = "addBusToolStripMenuItem";
            this.addBusToolStripMenuItem.Size = new System.Drawing.Size(168, 26);
            this.addBusToolStripMenuItem.Text = "Add Bus";
            this.addBusToolStripMenuItem.Click += new System.EventHandler(this.addBusToolStripMenuItem_Click);
            // 
            // updateBusToolStripMenuItem
            // 
            this.updateBusToolStripMenuItem.Name = "updateBusToolStripMenuItem";
            this.updateBusToolStripMenuItem.Size = new System.Drawing.Size(168, 26);
            this.updateBusToolStripMenuItem.Text = "Update Bus";
            this.updateBusToolStripMenuItem.Click += new System.EventHandler(this.updateBusToolStripMenuItem_Click);
            // 
            // deleteBusToolStripMenuItem
            // 
            this.deleteBusToolStripMenuItem.Name = "deleteBusToolStripMenuItem";
            this.deleteBusToolStripMenuItem.Size = new System.Drawing.Size(168, 26);
            this.deleteBusToolStripMenuItem.Text = "Delete Bus";
            this.deleteBusToolStripMenuItem.Click += new System.EventHandler(this.deleteBusToolStripMenuItem_Click);
            // 
            // attendanceToolStripMenuItem
            // 
            this.attendanceToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.shift1ToolStripMenuItem,
            this.shift2ToolStripMenuItem,
            this.shift3ToolStripMenuItem});
            this.attendanceToolStripMenuItem.Name = "attendanceToolStripMenuItem";
            this.attendanceToolStripMenuItem.Size = new System.Drawing.Size(103, 24);
            this.attendanceToolStripMenuItem.Text = "Attendance ";
            // 
            // shift1ToolStripMenuItem
            // 
            this.shift1ToolStripMenuItem.Name = "shift1ToolStripMenuItem";
            this.shift1ToolStripMenuItem.Size = new System.Drawing.Size(136, 26);
            this.shift1ToolStripMenuItem.Text = "Shift A";
            this.shift1ToolStripMenuItem.Click += new System.EventHandler(this.shift1ToolStripMenuItem_Click);
            // 
            // shift2ToolStripMenuItem
            // 
            this.shift2ToolStripMenuItem.Name = "shift2ToolStripMenuItem";
            this.shift2ToolStripMenuItem.Size = new System.Drawing.Size(136, 26);
            this.shift2ToolStripMenuItem.Text = "Shift B";
            this.shift2ToolStripMenuItem.Click += new System.EventHandler(this.shift2ToolStripMenuItem_Click);
            // 
            // shift3ToolStripMenuItem
            // 
            this.shift3ToolStripMenuItem.Name = "shift3ToolStripMenuItem";
            this.shift3ToolStripMenuItem.Size = new System.Drawing.Size(136, 26);
            this.shift3ToolStripMenuItem.Text = "Shift C";
            this.shift3ToolStripMenuItem.Click += new System.EventHandler(this.shift3ToolStripMenuItem_Click);
            // 
            // dispatchedGroupToolStripMenuItem
            // 
            this.dispatchedGroupToolStripMenuItem.Name = "dispatchedGroupToolStripMenuItem";
            this.dispatchedGroupToolStripMenuItem.Size = new System.Drawing.Size(143, 24);
            this.dispatchedGroupToolStripMenuItem.Text = "Dispatched Group";
            this.dispatchedGroupToolStripMenuItem.Click += new System.EventHandler(this.dispatchedGroupToolStripMenuItem_Click);
            // 
            // mainPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1140, 590);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "mainPage";
            this.Text = "Main_Page";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.mainPage_FormClosing);
            this.Load += new System.EventHandler(this.mainPage_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logo)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.theme)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox logo;
        private System.Windows.Forms.Label ambulanceManagementSystem;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.PictureBox theme;
        private System.Windows.Forms.Button receiveCall;
        private System.Windows.Forms.Label time;
        private System.Windows.Forms.Label date;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem employeeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addEmployeeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem updateEmployeeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteEmployeeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hospitalToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addHospitalToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem updateHospitalToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteHospitalToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem busToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addBusToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem updateBusToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteBusToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem attendanceToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem shift1ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem shift2ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem shift3ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hospitalLoginToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dispatchedGroupToolStripMenuItem;
    }
}