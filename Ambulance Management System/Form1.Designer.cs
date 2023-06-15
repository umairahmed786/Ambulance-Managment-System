
namespace Ambulance_Management_System
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.ctwoUserName = new System.Windows.Forms.TextBox();
            this.ctwoPassword = new System.Windows.Forms.TextBox();
            this.ctwoInvalid = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(114, 289);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(163, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "USER NAME";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(114, 362);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(159, 29);
            this.label2.TabIndex = 1;
            this.label2.Text = "PASSWORD";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Black;
            this.button1.Location = new System.Drawing.Point(228, 494);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(107, 40);
            this.button1.TabIndex = 2;
            this.button1.Text = "LOGIN";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // ctwoUserName
            // 
            this.ctwoUserName.Location = new System.Drawing.Point(289, 289);
            this.ctwoUserName.Name = "ctwoUserName";
            this.ctwoUserName.Size = new System.Drawing.Size(219, 22);
            this.ctwoUserName.TabIndex = 3;
            // 
            // ctwoPassword
            // 
            this.ctwoPassword.Location = new System.Drawing.Point(289, 369);
            this.ctwoPassword.Name = "ctwoPassword";
            this.ctwoPassword.Size = new System.Drawing.Size(219, 22);
            this.ctwoPassword.TabIndex = 4;
            // 
            // ctwoInvalid
            // 
            this.ctwoInvalid.AutoSize = true;
            this.ctwoInvalid.ForeColor = System.Drawing.Color.Red;
            this.ctwoInvalid.Location = new System.Drawing.Point(225, 440);
            this.ctwoInvalid.Name = "ctwoInvalid";
            this.ctwoInvalid.Size = new System.Drawing.Size(196, 17);
            this.ctwoInvalid.TabIndex = 6;
            this.ctwoInvalid.Text = "Invalid username or password";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Ambulance_Management_System.Properties.Resources.download__1__removebg_preview;
            this.pictureBox1.Location = new System.Drawing.Point(228, 22);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(208, 155);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 38;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(638, 602);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.ctwoInvalid);
            this.Controls.Add(this.ctwoPassword);
            this.Controls.Add(this.ctwoUserName);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "CTWO WINDOW";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox ctwoUserName;
        private System.Windows.Forms.TextBox ctwoPassword;
        private System.Windows.Forms.Label ctwoInvalid;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

