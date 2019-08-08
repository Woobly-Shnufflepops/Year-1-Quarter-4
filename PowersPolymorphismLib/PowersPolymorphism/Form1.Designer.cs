namespace PowersPolymorphism
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
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.btnAddEmployee = new System.Windows.Forms.Button();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtIDNumber = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtDateHired = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtWage = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtHours = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtEmployeeType = new System.Windows.Forms.TextBox();
            this.btnDisplayEmployees = new System.Windows.Forms.Button();
            this.txtYearsWorked = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.btnSenority = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(13, 13);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(509, 200);
            this.richTextBox1.TabIndex = 0;
            this.richTextBox1.Text = "";
            // 
            // btnAddEmployee
            // 
            this.btnAddEmployee.Location = new System.Drawing.Point(15, 401);
            this.btnAddEmployee.Name = "btnAddEmployee";
            this.btnAddEmployee.Size = new System.Drawing.Size(203, 34);
            this.btnAddEmployee.TabIndex = 1;
            this.btnAddEmployee.Text = "Add Employee";
            this.btnAddEmployee.UseVisualStyleBackColor = true;
            this.btnAddEmployee.Click += new System.EventHandler(this.btnAddEmployee_Click);
            // 
            // txtFirstName
            // 
            this.txtFirstName.Location = new System.Drawing.Point(118, 245);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(100, 20);
            this.txtFirstName.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 248);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "First Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 274);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Last Name";
            // 
            // txtLastName
            // 
            this.txtLastName.Location = new System.Drawing.Point(118, 271);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(100, 20);
            this.txtLastName.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 300);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "ID Number";
            // 
            // txtIDNumber
            // 
            this.txtIDNumber.Location = new System.Drawing.Point(118, 297);
            this.txtIDNumber.Name = "txtIDNumber";
            this.txtIDNumber.Size = new System.Drawing.Size(100, 20);
            this.txtIDNumber.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 326);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Date Hired";
            // 
            // txtDateHired
            // 
            this.txtDateHired.Location = new System.Drawing.Point(118, 323);
            this.txtDateHired.Name = "txtDateHired";
            this.txtDateHired.Size = new System.Drawing.Size(100, 20);
            this.txtDateHired.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 352);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(36, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Wage";
            // 
            // txtWage
            // 
            this.txtWage.Location = new System.Drawing.Point(118, 349);
            this.txtWage.Name = "txtWage";
            this.txtWage.Size = new System.Drawing.Size(100, 20);
            this.txtWage.TabIndex = 10;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 378);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(100, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "Hours (if applicable)";
            // 
            // txtHours
            // 
            this.txtHours.Location = new System.Drawing.Point(118, 375);
            this.txtHours.Name = "txtHours";
            this.txtHours.Size = new System.Drawing.Size(100, 20);
            this.txtHours.TabIndex = 12;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 222);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(92, 13);
            this.label7.TabIndex = 15;
            this.label7.Text = "Type of Employee";
            // 
            // txtEmployeeType
            // 
            this.txtEmployeeType.Location = new System.Drawing.Point(118, 219);
            this.txtEmployeeType.Name = "txtEmployeeType";
            this.txtEmployeeType.Size = new System.Drawing.Size(100, 20);
            this.txtEmployeeType.TabIndex = 14;
            // 
            // btnDisplayEmployees
            // 
            this.btnDisplayEmployees.Location = new System.Drawing.Point(225, 220);
            this.btnDisplayEmployees.Name = "btnDisplayEmployees";
            this.btnDisplayEmployees.Size = new System.Drawing.Size(162, 45);
            this.btnDisplayEmployees.TabIndex = 16;
            this.btnDisplayEmployees.Text = "Display Employees";
            this.btnDisplayEmployees.UseVisualStyleBackColor = true;
            this.btnDisplayEmployees.Click += new System.EventHandler(this.btnDisplayEmployees_Click);
            // 
            // txtYearsWorked
            // 
            this.txtYearsWorked.Location = new System.Drawing.Point(303, 364);
            this.txtYearsWorked.Name = "txtYearsWorked";
            this.txtYearsWorked.Size = new System.Drawing.Size(85, 20);
            this.txtYearsWorked.TabIndex = 17;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(225, 367);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(72, 13);
            this.label8.TabIndex = 18;
            this.label8.Text = "Years worked";
            // 
            // btnSenority
            // 
            this.btnSenority.Location = new System.Drawing.Point(225, 390);
            this.btnSenority.Name = "btnSenority";
            this.btnSenority.Size = new System.Drawing.Size(162, 45);
            this.btnSenority.TabIndex = 19;
            this.btnSenority.Text = "Senority List";
            this.btnSenority.UseVisualStyleBackColor = true;
            this.btnSenority.Click += new System.EventHandler(this.btnSenority_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(535, 445);
            this.Controls.Add(this.btnSenority);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtYearsWorked);
            this.Controls.Add(this.btnDisplayEmployees);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtEmployeeType);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtHours);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtWage);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtDateHired);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtIDNumber);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtLastName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtFirstName);
            this.Controls.Add(this.btnAddEmployee);
            this.Controls.Add(this.richTextBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button btnAddEmployee;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtIDNumber;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtDateHired;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtWage;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtHours;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtEmployeeType;
        private System.Windows.Forms.Button btnDisplayEmployees;
        private System.Windows.Forms.TextBox txtYearsWorked;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnSenority;
    }
}

