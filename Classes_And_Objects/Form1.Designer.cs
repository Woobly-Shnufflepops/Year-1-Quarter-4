namespace Classes_And_Objects
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
            this.btnDisplayList = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblFN = new System.Windows.Forms.Label();
            this.lblLN = new System.Windows.Forms.Label();
            this.lblID = new System.Windows.Forms.Label();
            this.lblPR = new System.Windows.Forms.Label();
            this.txtFN = new System.Windows.Forms.TextBox();
            this.txtLN = new System.Windows.Forms.TextBox();
            this.txtID = new System.Windows.Forms.TextBox();
            this.txtPR = new System.Windows.Forms.TextBox();
            this.btnAddNewStudent = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblIndex = new System.Windows.Forms.Label();
            this.txtIndex = new System.Windows.Forms.TextBox();
            this.txtCourseName = new System.Windows.Forms.TextBox();
            this.lblCourseName = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.btnRemoveCourse = new System.Windows.Forms.Button();
            this.txtCourseRemove = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtIndexRemove = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnTwoOrLess = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(12, 12);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(260, 154);
            this.richTextBox1.TabIndex = 0;
            this.richTextBox1.Text = "";
            // 
            // btnDisplayList
            // 
            this.btnDisplayList.Location = new System.Drawing.Point(13, 173);
            this.btnDisplayList.Name = "btnDisplayList";
            this.btnDisplayList.Size = new System.Drawing.Size(259, 76);
            this.btnDisplayList.TabIndex = 1;
            this.btnDisplayList.Text = "Display Student List";
            this.btnDisplayList.UseVisualStyleBackColor = true;
            this.btnDisplayList.Click += new System.EventHandler(this.btnDisplayList_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnAddNewStudent);
            this.panel1.Controls.Add(this.txtPR);
            this.panel1.Controls.Add(this.txtID);
            this.panel1.Controls.Add(this.txtLN);
            this.panel1.Controls.Add(this.txtFN);
            this.panel1.Controls.Add(this.lblPR);
            this.panel1.Controls.Add(this.lblID);
            this.panel1.Controls.Add(this.lblLN);
            this.panel1.Controls.Add(this.lblFN);
            this.panel1.Location = new System.Drawing.Point(279, 13);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(192, 153);
            this.panel1.TabIndex = 2;
            // 
            // lblFN
            // 
            this.lblFN.AutoSize = true;
            this.lblFN.Location = new System.Drawing.Point(3, 6);
            this.lblFN.Name = "lblFN";
            this.lblFN.Size = new System.Drawing.Size(57, 13);
            this.lblFN.TabIndex = 0;
            this.lblFN.Text = "First Name";
            // 
            // lblLN
            // 
            this.lblLN.AutoSize = true;
            this.lblLN.Location = new System.Drawing.Point(3, 32);
            this.lblLN.Name = "lblLN";
            this.lblLN.Size = new System.Drawing.Size(58, 13);
            this.lblLN.TabIndex = 1;
            this.lblLN.Text = "Last Name";
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Location = new System.Drawing.Point(3, 58);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(18, 13);
            this.lblID.TabIndex = 2;
            this.lblID.Text = "ID";
            // 
            // lblPR
            // 
            this.lblPR.AutoSize = true;
            this.lblPR.Location = new System.Drawing.Point(3, 84);
            this.lblPR.Name = "lblPR";
            this.lblPR.Size = new System.Drawing.Size(46, 13);
            this.lblPR.TabIndex = 3;
            this.lblPR.Text = "Program";
            // 
            // txtFN
            // 
            this.txtFN.Location = new System.Drawing.Point(66, 3);
            this.txtFN.Name = "txtFN";
            this.txtFN.Size = new System.Drawing.Size(100, 20);
            this.txtFN.TabIndex = 4;
            // 
            // txtLN
            // 
            this.txtLN.Location = new System.Drawing.Point(66, 29);
            this.txtLN.Name = "txtLN";
            this.txtLN.Size = new System.Drawing.Size(100, 20);
            this.txtLN.TabIndex = 5;
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(66, 55);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(100, 20);
            this.txtID.TabIndex = 6;
            // 
            // txtPR
            // 
            this.txtPR.Location = new System.Drawing.Point(66, 81);
            this.txtPR.Name = "txtPR";
            this.txtPR.Size = new System.Drawing.Size(100, 20);
            this.txtPR.TabIndex = 7;
            // 
            // btnAddNewStudent
            // 
            this.btnAddNewStudent.Location = new System.Drawing.Point(6, 106);
            this.btnAddNewStudent.Name = "btnAddNewStudent";
            this.btnAddNewStudent.Size = new System.Drawing.Size(183, 44);
            this.btnAddNewStudent.TabIndex = 8;
            this.btnAddNewStudent.Text = "Add New Student";
            this.btnAddNewStudent.UseVisualStyleBackColor = true;
            this.btnAddNewStudent.Click += new System.EventHandler(this.btnAddNewStudent_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.button1);
            this.panel2.Controls.Add(this.txtCourseName);
            this.panel2.Controls.Add(this.lblCourseName);
            this.panel2.Controls.Add(this.txtIndex);
            this.panel2.Controls.Add(this.lblIndex);
            this.panel2.Location = new System.Drawing.Point(478, 13);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(196, 113);
            this.panel2.TabIndex = 3;
            // 
            // lblIndex
            // 
            this.lblIndex.AutoSize = true;
            this.lblIndex.Location = new System.Drawing.Point(5, 9);
            this.lblIndex.Name = "lblIndex";
            this.lblIndex.Size = new System.Drawing.Size(73, 13);
            this.lblIndex.TabIndex = 0;
            this.lblIndex.Text = "Student Index";
            // 
            // txtIndex
            // 
            this.txtIndex.Location = new System.Drawing.Point(84, 3);
            this.txtIndex.Name = "txtIndex";
            this.txtIndex.Size = new System.Drawing.Size(100, 20);
            this.txtIndex.TabIndex = 1;
            // 
            // txtCourseName
            // 
            this.txtCourseName.Location = new System.Drawing.Point(84, 32);
            this.txtCourseName.Name = "txtCourseName";
            this.txtCourseName.Size = new System.Drawing.Size(100, 20);
            this.txtCourseName.TabIndex = 3;
            // 
            // lblCourseName
            // 
            this.lblCourseName.AutoSize = true;
            this.lblCourseName.Location = new System.Drawing.Point(5, 35);
            this.lblCourseName.Name = "lblCourseName";
            this.lblCourseName.Size = new System.Drawing.Size(71, 13);
            this.lblCourseName.TabIndex = 2;
            this.lblCourseName.Text = "Course Name";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(8, 63);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(176, 39);
            this.button1.TabIndex = 4;
            this.button1.Text = "Add a course";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.btnRemoveCourse);
            this.panel3.Controls.Add(this.txtCourseRemove);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.txtIndexRemove);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Location = new System.Drawing.Point(478, 133);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(200, 107);
            this.panel3.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "label1";
            // 
            // btnRemoveCourse
            // 
            this.btnRemoveCourse.Location = new System.Drawing.Point(14, 61);
            this.btnRemoveCourse.Name = "btnRemoveCourse";
            this.btnRemoveCourse.Size = new System.Drawing.Size(176, 39);
            this.btnRemoveCourse.TabIndex = 9;
            this.btnRemoveCourse.Text = "Remove a course";
            this.btnRemoveCourse.UseVisualStyleBackColor = true;
            this.btnRemoveCourse.Click += new System.EventHandler(this.btnRemoveCourse_Click);
            // 
            // txtCourseRemove
            // 
            this.txtCourseRemove.Location = new System.Drawing.Point(90, 30);
            this.txtCourseRemove.Name = "txtCourseRemove";
            this.txtCourseRemove.Size = new System.Drawing.Size(100, 20);
            this.txtCourseRemove.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Course Name";
            // 
            // txtIndexRemove
            // 
            this.txtIndexRemove.Location = new System.Drawing.Point(90, 1);
            this.txtIndexRemove.Name = "txtIndexRemove";
            this.txtIndexRemove.Size = new System.Drawing.Size(100, 20);
            this.txtIndexRemove.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(11, 7);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Student Index";
            // 
            // btnTwoOrLess
            // 
            this.btnTwoOrLess.Location = new System.Drawing.Point(279, 173);
            this.btnTwoOrLess.Name = "btnTwoOrLess";
            this.btnTwoOrLess.Size = new System.Drawing.Size(189, 76);
            this.btnTwoOrLess.TabIndex = 5;
            this.btnTwoOrLess.Text = "Students with 2 or less courses";
            this.btnTwoOrLess.UseVisualStyleBackColor = true;
            this.btnTwoOrLess.Click += new System.EventHandler(this.btnTwoOrLess_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(721, 261);
            this.Controls.Add(this.btnTwoOrLess);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnDisplayList);
            this.Controls.Add(this.richTextBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button btnDisplayList;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnAddNewStudent;
        private System.Windows.Forms.TextBox txtPR;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.TextBox txtLN;
        private System.Windows.Forms.TextBox txtFN;
        private System.Windows.Forms.Label lblPR;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.Label lblLN;
        private System.Windows.Forms.Label lblFN;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtCourseName;
        private System.Windows.Forms.Label lblCourseName;
        private System.Windows.Forms.TextBox txtIndex;
        private System.Windows.Forms.Label lblIndex;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnRemoveCourse;
        private System.Windows.Forms.TextBox txtCourseRemove;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtIndexRemove;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnTwoOrLess;
    }
}

