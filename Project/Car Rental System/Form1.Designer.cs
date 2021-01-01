namespace Car_Rental_System
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
            this.Renter = new System.Windows.Forms.Button();
            this.Lender = new System.Windows.Forms.Button();
            this.Employee = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Renter
            // 
            this.Renter.Location = new System.Drawing.Point(153, 159);
            this.Renter.Name = "Renter";
            this.Renter.Size = new System.Drawing.Size(75, 23);
            this.Renter.TabIndex = 0;
            this.Renter.Text = "Rental";
            this.Renter.UseVisualStyleBackColor = true;
            this.Renter.Click += new System.EventHandler(this.Renter_Click);
            // 
            // Lender
            // 
            this.Lender.Location = new System.Drawing.Point(153, 310);
            this.Lender.Name = "Lender";
            this.Lender.Size = new System.Drawing.Size(75, 23);
            this.Lender.TabIndex = 1;
            this.Lender.Text = "Renter";
            this.Lender.UseVisualStyleBackColor = true;
            this.Lender.Click += new System.EventHandler(this.Lender_Click);
            // 
            // Employee
            // 
            this.Employee.Location = new System.Drawing.Point(153, 231);
            this.Employee.Name = "Employee";
            this.Employee.Size = new System.Drawing.Size(75, 23);
            this.Employee.TabIndex = 2;
            this.Employee.Text = "Employee";
            this.Employee.UseVisualStyleBackColor = true;
            this.Employee.Click += new System.EventHandler(this.Employee_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(62, 99);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(269, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Please Choose One To Continue";
            this.label1.Click += new System.EventHandler(this.Label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("MV Boli", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(127, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(128, 34);
            this.label2.TabIndex = 4;
            this.label2.Text = "Welcome";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(400, 418);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Employee);
            this.Controls.Add(this.Lender);
            this.Controls.Add(this.Renter);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Renter;
        private System.Windows.Forms.Button Lender;
        private System.Windows.Forms.Button Employee;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

