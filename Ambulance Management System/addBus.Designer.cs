
namespace Ambulance_Management_System
{
    partial class addBus
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
            this.busName = new System.Windows.Forms.Label();
            this.busColour = new System.Windows.Forms.Label();
            this.modelNumber = new System.Windows.Forms.Label();
            this.numberPlate = new System.Windows.Forms.Label();
            this.busNameTextBox = new System.Windows.Forms.TextBox();
            this.busColourTextBox = new System.Windows.Forms.TextBox();
            this.modelNumberTextBox = new System.Windows.Forms.TextBox();
            this.numberPlateTextBox = new System.Windows.Forms.TextBox();
            this.addingBus = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.incompleteInput = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // busName
            // 
            this.busName.AutoSize = true;
            this.busName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.busName.Location = new System.Drawing.Point(143, 294);
            this.busName.Name = "busName";
            this.busName.Size = new System.Drawing.Size(103, 25);
            this.busName.TabIndex = 1;
            this.busName.Text = "Bus Name";
            // 
            // busColour
            // 
            this.busColour.AutoSize = true;
            this.busColour.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.busColour.Location = new System.Drawing.Point(143, 348);
            this.busColour.Name = "busColour";
            this.busColour.Size = new System.Drawing.Size(109, 25);
            this.busColour.TabIndex = 2;
            this.busColour.Text = "Bus Colour";
            // 
            // modelNumber
            // 
            this.modelNumber.AutoSize = true;
            this.modelNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.modelNumber.Location = new System.Drawing.Point(143, 407);
            this.modelNumber.Name = "modelNumber";
            this.modelNumber.Size = new System.Drawing.Size(140, 25);
            this.modelNumber.TabIndex = 3;
            this.modelNumber.Text = "Model Number";
            // 
            // numberPlate
            // 
            this.numberPlate.AutoSize = true;
            this.numberPlate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numberPlate.Location = new System.Drawing.Point(143, 460);
            this.numberPlate.Name = "numberPlate";
            this.numberPlate.Size = new System.Drawing.Size(130, 25);
            this.numberPlate.TabIndex = 4;
            this.numberPlate.Text = "Number Plate";
            // 
            // busNameTextBox
            // 
            this.busNameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.busNameTextBox.Location = new System.Drawing.Point(329, 294);
            this.busNameTextBox.Name = "busNameTextBox";
            this.busNameTextBox.Size = new System.Drawing.Size(223, 22);
            this.busNameTextBox.TabIndex = 5;
            // 
            // busColourTextBox
            // 
            this.busColourTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.busColourTextBox.Location = new System.Drawing.Point(329, 348);
            this.busColourTextBox.Name = "busColourTextBox";
            this.busColourTextBox.Size = new System.Drawing.Size(223, 22);
            this.busColourTextBox.TabIndex = 6;
            // 
            // modelNumberTextBox
            // 
            this.modelNumberTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.modelNumberTextBox.Location = new System.Drawing.Point(329, 407);
            this.modelNumberTextBox.Name = "modelNumberTextBox";
            this.modelNumberTextBox.Size = new System.Drawing.Size(223, 22);
            this.modelNumberTextBox.TabIndex = 7;
            // 
            // numberPlateTextBox
            // 
            this.numberPlateTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numberPlateTextBox.Location = new System.Drawing.Point(329, 460);
            this.numberPlateTextBox.Name = "numberPlateTextBox";
            this.numberPlateTextBox.Size = new System.Drawing.Size(223, 22);
            this.numberPlateTextBox.TabIndex = 8;
            // 
            // addingBus
            // 
            this.addingBus.Location = new System.Drawing.Point(332, 521);
            this.addingBus.Name = "addingBus";
            this.addingBus.Size = new System.Drawing.Size(114, 33);
            this.addingBus.TabIndex = 9;
            this.addingBus.Text = "Add Bus";
            this.addingBus.UseVisualStyleBackColor = true;
            this.addingBus.Click += new System.EventHandler(this.addingBus_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(325, 204);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(153, 39);
            this.label1.TabIndex = 10;
            this.label1.Text = "Add Bus";
            // 
            // incompleteInput
            // 
            this.incompleteInput.AutoSize = true;
            this.incompleteInput.ForeColor = System.Drawing.Color.Red;
            this.incompleteInput.Location = new System.Drawing.Point(329, 489);
            this.incompleteInput.Name = "incompleteInput";
            this.incompleteInput.Size = new System.Drawing.Size(172, 17);
            this.incompleteInput.TabIndex = 11;
            this.incompleteInput.Text = "Please fill the above fields";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Ambulance_Management_System.Properties.Resources.download__1__removebg_preview;
            this.pictureBox1.Location = new System.Drawing.Point(329, 23);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(208, 155);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 39;
            this.pictureBox1.TabStop = false;
            // 
            // addBus
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(800, 595);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.incompleteInput);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.addingBus);
            this.Controls.Add(this.numberPlateTextBox);
            this.Controls.Add(this.modelNumberTextBox);
            this.Controls.Add(this.busColourTextBox);
            this.Controls.Add(this.busNameTextBox);
            this.Controls.Add(this.numberPlate);
            this.Controls.Add(this.modelNumber);
            this.Controls.Add(this.busColour);
            this.Controls.Add(this.busName);
            this.Name = "addBus";
            this.Text = "addBus";
            this.Load += new System.EventHandler(this.addBus_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label busName;
        private System.Windows.Forms.Label busColour;
        private System.Windows.Forms.Label modelNumber;
        private System.Windows.Forms.Label numberPlate;
        private System.Windows.Forms.TextBox busNameTextBox;
        private System.Windows.Forms.TextBox busColourTextBox;
        private System.Windows.Forms.TextBox modelNumberTextBox;
        private System.Windows.Forms.TextBox numberPlateTextBox;
        private System.Windows.Forms.Button addingBus;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label incompleteInput;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}