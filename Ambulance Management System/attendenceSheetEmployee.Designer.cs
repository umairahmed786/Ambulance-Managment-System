
namespace Ambulance_Management_System
{
    partial class attendenceSheetEmployee
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(attendenceSheetEmployee));
            this.panel1 = new System.Windows.Forms.Panel();
            this.attendenceOfEmployees = new System.Windows.Forms.Label();
            this.dataGridViewOfEmployees = new System.Windows.Forms.DataGridView();
            this.submit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOfEmployees)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Location = new System.Drawing.Point(527, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(267, 145);
            this.panel1.TabIndex = 0;
            // 
            // attendenceOfEmployees
            // 
            this.attendenceOfEmployees.AutoSize = true;
            this.attendenceOfEmployees.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.attendenceOfEmployees.Location = new System.Drawing.Point(409, 170);
            this.attendenceOfEmployees.Name = "attendenceOfEmployees";
            this.attendenceOfEmployees.Size = new System.Drawing.Size(502, 39);
            this.attendenceOfEmployees.TabIndex = 1;
            this.attendenceOfEmployees.Text = "Attendence Sheet of Employees";
            // 
            // dataGridViewOfEmployees
            // 
            this.dataGridViewOfEmployees.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewOfEmployees.Location = new System.Drawing.Point(335, 229);
            this.dataGridViewOfEmployees.Name = "dataGridViewOfEmployees";
            this.dataGridViewOfEmployees.RowHeadersWidth = 51;
            this.dataGridViewOfEmployees.RowTemplate.Height = 24;
            this.dataGridViewOfEmployees.Size = new System.Drawing.Size(702, 393);
            this.dataGridViewOfEmployees.TabIndex = 2;
            this.dataGridViewOfEmployees.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewOfEmployees_CellContentClick_1);
            // 
            // submit
            // 
            this.submit.Location = new System.Drawing.Point(527, 652);
            this.submit.Name = "submit";
            this.submit.Size = new System.Drawing.Size(75, 23);
            this.submit.TabIndex = 3;
            this.submit.Text = "Submit";
            this.submit.UseVisualStyleBackColor = true;
            this.submit.Click += new System.EventHandler(this.submit_Click);
            // 
            // attendenceSheetEmployee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1344, 739);
            this.Controls.Add(this.submit);
            this.Controls.Add(this.dataGridViewOfEmployees);
            this.Controls.Add(this.attendenceOfEmployees);
            this.Controls.Add(this.panel1);
            this.Name = "attendenceSheetEmployee";
            this.Text = "attendenceSheet";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.attendenceSheetEmployee_FormClosing);
            this.Load += new System.EventHandler(this.attendenceSheetEmployee_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOfEmployees)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label attendenceOfEmployees;
        private System.Windows.Forms.DataGridView dataGridViewOfEmployees;
        private System.Windows.Forms.Button submit;
    }
}