
namespace Ambulance_Management_System
{
    partial class ECF
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
            this.label9 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.patientName = new System.Windows.Forms.TextBox();
            this.patientFatherName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.contactNumber = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.date = new System.Windows.Forms.DateTimePicker();
            this.time = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cnicNumber = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.pickUpAddress = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.destinationAddress = new System.Windows.Forms.TextBox();
            this.submit = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.ecfId = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.driver = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.bus = new System.Windows.Forms.TextBox();
            this.compoder = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Red;
            this.label9.Location = new System.Drawing.Point(496, 43);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(197, 38);
            this.label9.TabIndex = 36;
            this.label9.Text = "ECF FORM";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Ambulance_Management_System.Properties.Resources.download__1__removebg_preview;
            this.pictureBox1.Location = new System.Drawing.Point(-41, -3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(208, 155);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 37;
            this.pictureBox1.TabStop = false;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(175, 142);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(82, 29);
            this.label10.TabIndex = 38;
            this.label10.Text = "Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(634, 142);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(164, 29);
            this.label1.TabIndex = 39;
            this.label1.Text = "Father Name";
            // 
            // patientName
            // 
            this.patientName.Location = new System.Drawing.Point(263, 142);
            this.patientName.Name = "patientName";
            this.patientName.Size = new System.Drawing.Size(283, 22);
            this.patientName.TabIndex = 40;
            // 
            // patientFatherName
            // 
            this.patientFatherName.Location = new System.Drawing.Point(804, 149);
            this.patientFatherName.Name = "patientFatherName";
            this.patientFatherName.Size = new System.Drawing.Size(283, 22);
            this.patientFatherName.TabIndex = 41;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(175, 187);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(201, 29);
            this.label2.TabIndex = 42;
            this.label2.Text = "Contact Number";
            // 
            // contactNumber
            // 
            this.contactNumber.Location = new System.Drawing.Point(382, 194);
            this.contactNumber.Name = "contactNumber";
            this.contactNumber.Size = new System.Drawing.Size(283, 22);
            this.contactNumber.TabIndex = 43;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(175, 262);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(317, 29);
            this.label3.TabIndex = 44;
            this.label3.Text = "Date and Time of Request";
            // 
            // date
            // 
            this.date.Location = new System.Drawing.Point(588, 267);
            this.date.Name = "date";
            this.date.Size = new System.Drawing.Size(200, 22);
            this.date.TabIndex = 45;
            this.date.ValueChanged += new System.EventHandler(this.date_ValueChanged);
            // 
            // time
            // 
            this.time.AutoSize = true;
            this.time.Location = new System.Drawing.Point(817, 274);
            this.time.Name = "time";
            this.time.Size = new System.Drawing.Size(64, 17);
            this.time.TabIndex = 46;
            this.time.Text = "00:00:00";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(175, 332);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(75, 29);
            this.label5.TabIndex = 47;
            this.label5.Text = "CNIC";
            // 
            // cnicNumber
            // 
            this.cnicNumber.Location = new System.Drawing.Point(263, 332);
            this.cnicNumber.Name = "cnicNumber";
            this.cnicNumber.Size = new System.Drawing.Size(283, 22);
            this.cnicNumber.TabIndex = 48;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(175, 415);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(206, 29);
            this.label6.TabIndex = 49;
            this.label6.Text = "Pick Up Address";
            // 
            // pickUpAddress
            // 
            this.pickUpAddress.Location = new System.Drawing.Point(179, 447);
            this.pickUpAddress.Multiline = true;
            this.pickUpAddress.Name = "pickUpAddress";
            this.pickUpAddress.Size = new System.Drawing.Size(908, 22);
            this.pickUpAddress.TabIndex = 50;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(174, 493);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(247, 29);
            this.label7.TabIndex = 51;
            this.label7.Text = "Destination Address";
            // 
            // destinationAddress
            // 
            this.destinationAddress.Location = new System.Drawing.Point(179, 525);
            this.destinationAddress.Multiline = true;
            this.destinationAddress.Name = "destinationAddress";
            this.destinationAddress.Size = new System.Drawing.Size(908, 22);
            this.destinationAddress.TabIndex = 52;
            // 
            // submit
            // 
            this.submit.BackColor = System.Drawing.Color.Transparent;
            this.submit.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.submit.ForeColor = System.Drawing.Color.YellowGreen;
            this.submit.Location = new System.Drawing.Point(503, 681);
            this.submit.Name = "submit";
            this.submit.Size = new System.Drawing.Size(162, 40);
            this.submit.TabIndex = 53;
            this.submit.Text = "SUBMIT";
            this.submit.UseVisualStyleBackColor = false;
            this.submit.Click += new System.EventHandler(this.submit_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(498, 110);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 29);
            this.label4.TabIndex = 54;
            this.label4.Text = "ID:";
            // 
            // ecfId
            // 
            this.ecfId.AutoSize = true;
            this.ecfId.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ecfId.Location = new System.Drawing.Point(549, 110);
            this.ecfId.Name = "ecfId";
            this.ecfId.Size = new System.Drawing.Size(76, 26);
            this.ecfId.TabIndex = 55;
            this.ecfId.Text = "label8";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(167, 579);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(83, 29);
            this.label8.TabIndex = 56;
            this.label8.Text = "Driver";
            // 
            // driver
            // 
            this.driver.Location = new System.Drawing.Point(256, 586);
            this.driver.Name = "driver";
            this.driver.Size = new System.Drawing.Size(197, 22);
            this.driver.TabIndex = 57;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(870, 579);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(57, 29);
            this.label11.TabIndex = 58;
            this.label11.Text = "Bus";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(467, 579);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(136, 29);
            this.label12.TabIndex = 59;
            this.label12.Text = "Compoder";
            // 
            // bus
            // 
            this.bus.Location = new System.Drawing.Point(933, 586);
            this.bus.Name = "bus";
            this.bus.Size = new System.Drawing.Size(197, 22);
            this.bus.TabIndex = 60;
            // 
            // compoder
            // 
            this.compoder.Location = new System.Drawing.Point(601, 586);
            this.compoder.Name = "compoder";
            this.compoder.Size = new System.Drawing.Size(197, 22);
            this.compoder.TabIndex = 61;
            // 
            // ECF
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(1187, 733);
            this.Controls.Add(this.compoder);
            this.Controls.Add(this.bus);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.driver);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.ecfId);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.submit);
            this.Controls.Add(this.destinationAddress);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.pickUpAddress);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cnicNumber);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.time);
            this.Controls.Add(this.date);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.contactNumber);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.patientFatherName);
            this.Controls.Add(this.patientName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label9);
            this.Name = "ECF";
            this.Text = "ECF";
            this.Load += new System.EventHandler(this.ECF_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox patientName;
        private System.Windows.Forms.TextBox patientFatherName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox contactNumber;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker date;
        private System.Windows.Forms.Label time;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox cnicNumber;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox pickUpAddress;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox destinationAddress;
        private System.Windows.Forms.Button submit;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label ecfId;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox driver;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox bus;
        private System.Windows.Forms.TextBox compoder;
    }
}