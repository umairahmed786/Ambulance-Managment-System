
namespace Ambulance_Management_System
{
    partial class DispatchedGroup
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.dataGridViewOfGroup = new System.Windows.Forms.DataGridView();
            this.label9 = new System.Windows.Forms.Label();
            this.submit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOfGroup)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Ambulance_Management_System.Properties.Resources.download__1__removebg_preview;
            this.pictureBox1.Location = new System.Drawing.Point(360, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(208, 155);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 38;
            this.pictureBox1.TabStop = false;
            // 
            // dataGridViewOfGroup
            // 
            this.dataGridViewOfGroup.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewOfGroup.Location = new System.Drawing.Point(100, 238);
            this.dataGridViewOfGroup.Name = "dataGridViewOfGroup";
            this.dataGridViewOfGroup.RowHeadersWidth = 51;
            this.dataGridViewOfGroup.RowTemplate.Height = 24;
            this.dataGridViewOfGroup.Size = new System.Drawing.Size(702, 393);
            this.dataGridViewOfGroup.TabIndex = 39;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Red;
            this.label9.Location = new System.Drawing.Point(307, 186);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(297, 38);
            this.label9.TabIndex = 40;
            this.label9.Text = "Dispatched Group";
            // 
            // submit
            // 
            this.submit.BackColor = System.Drawing.Color.Transparent;
            this.submit.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.submit.ForeColor = System.Drawing.Color.YellowGreen;
            this.submit.Location = new System.Drawing.Point(360, 664);
            this.submit.Name = "submit";
            this.submit.Size = new System.Drawing.Size(162, 40);
            this.submit.TabIndex = 54;
            this.submit.Text = "Return";
            this.submit.UseVisualStyleBackColor = false;
            this.submit.Click += new System.EventHandler(this.submit_Click);
            // 
            // DispatchedGroup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(985, 747);
            this.Controls.Add(this.submit);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.dataGridViewOfGroup);
            this.Controls.Add(this.pictureBox1);
            this.Name = "DispatchedGroup";
            this.Text = "DispatchedGroup";
            this.Load += new System.EventHandler(this.DispatchedGroup_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOfGroup)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridView dataGridViewOfGroup;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button submit;
    }
}