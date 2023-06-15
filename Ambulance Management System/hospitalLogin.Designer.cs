
namespace Ambulance_Management_System
{
    partial class hospitalLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(hospitalLogin));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.hospitalName = new System.Windows.Forms.TextBox();
            this.hospitalId = new System.Windows.Forms.TextBox();
            this.hospitalPassword = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.hospitalInvalid = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(261, 23);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(165, 161);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(136, 302);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(141, 29);
            this.label1.TabIndex = 1;
            this.label1.Text = "Hospital ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(136, 234);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(185, 29);
            this.label2.TabIndex = 2;
            this.label2.Text = "Hospital Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(136, 372);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(128, 29);
            this.label3.TabIndex = 3;
            this.label3.Text = "Password";
            // 
            // hospitalName
            // 
            this.hospitalName.Location = new System.Drawing.Point(328, 240);
            this.hospitalName.Name = "hospitalName";
            this.hospitalName.Size = new System.Drawing.Size(226, 22);
            this.hospitalName.TabIndex = 4;
            // 
            // hospitalId
            // 
            this.hospitalId.Location = new System.Drawing.Point(328, 309);
            this.hospitalId.Name = "hospitalId";
            this.hospitalId.Size = new System.Drawing.Size(226, 22);
            this.hospitalId.TabIndex = 5;
            // 
            // hospitalPassword
            // 
            this.hospitalPassword.Location = new System.Drawing.Point(328, 372);
            this.hospitalPassword.Name = "hospitalPassword";
            this.hospitalPassword.Size = new System.Drawing.Size(226, 22);
            this.hospitalPassword.TabIndex = 6;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(328, 456);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(108, 43);
            this.button1.TabIndex = 7;
            this.button1.Text = "LOGIN";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // hospitalInvalid
            // 
            this.hospitalInvalid.AutoSize = true;
            this.hospitalInvalid.ForeColor = System.Drawing.Color.Red;
            this.hospitalInvalid.Location = new System.Drawing.Point(261, 412);
            this.hospitalInvalid.Name = "hospitalInvalid";
            this.hospitalInvalid.Size = new System.Drawing.Size(188, 17);
            this.hospitalInvalid.TabIndex = 8;
            this.hospitalInvalid.Text = "Invalid Name,ID or Password";
            // 
            // hospitalLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(709, 532);
            this.Controls.Add(this.hospitalInvalid);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.hospitalPassword);
            this.Controls.Add(this.hospitalId);
            this.Controls.Add(this.hospitalName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "hospitalLogin";
            this.Text = "HospitalLogin";
            this.Load += new System.EventHandler(this.hospitalLogin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox hospitalName;
        private System.Windows.Forms.TextBox hospitalId;
        private System.Windows.Forms.TextBox hospitalPassword;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label hospitalInvalid;
    }
}