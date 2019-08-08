namespace PowersFinal
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
            this.btnAccounts = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.btnSecondLargest = new System.Windows.Forms.Button();
            this.btnStrQueue = new System.Windows.Forms.Button();
            this.btnSort = new System.Windows.Forms.Button();
            this.btnDisplayStudents = new System.Windows.Forms.Button();
            this.txtKey = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnRemove = new System.Windows.Forms.Button();
            this.txtKey2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnSearch = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnAccounts
            // 
            this.btnAccounts.Location = new System.Drawing.Point(12, 198);
            this.btnAccounts.Name = "btnAccounts";
            this.btnAccounts.Size = new System.Drawing.Size(162, 54);
            this.btnAccounts.TabIndex = 0;
            this.btnAccounts.Text = "Accounts";
            this.btnAccounts.UseVisualStyleBackColor = true;
            this.btnAccounts.Click += new System.EventHandler(this.btnAccounts_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(12, 12);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(495, 180);
            this.richTextBox1.TabIndex = 1;
            this.richTextBox1.Text = "";
            // 
            // btnSecondLargest
            // 
            this.btnSecondLargest.Location = new System.Drawing.Point(326, 199);
            this.btnSecondLargest.Name = "btnSecondLargest";
            this.btnSecondLargest.Size = new System.Drawing.Size(181, 53);
            this.btnSecondLargest.TabIndex = 2;
            this.btnSecondLargest.Text = "Second Largest Num";
            this.btnSecondLargest.UseVisualStyleBackColor = true;
            this.btnSecondLargest.Click += new System.EventHandler(this.btnSecondLargest_Click);
            // 
            // btnStrQueue
            // 
            this.btnStrQueue.Location = new System.Drawing.Point(326, 258);
            this.btnStrQueue.Name = "btnStrQueue";
            this.btnStrQueue.Size = new System.Drawing.Size(181, 53);
            this.btnStrQueue.TabIndex = 3;
            this.btnStrQueue.Text = "String Queue";
            this.btnStrQueue.UseVisualStyleBackColor = true;
            this.btnStrQueue.Click += new System.EventHandler(this.btnStrQueue_Click);
            // 
            // btnSort
            // 
            this.btnSort.Location = new System.Drawing.Point(326, 317);
            this.btnSort.Name = "btnSort";
            this.btnSort.Size = new System.Drawing.Size(181, 53);
            this.btnSort.TabIndex = 4;
            this.btnSort.Text = "Sort Alg";
            this.btnSort.UseVisualStyleBackColor = true;
            this.btnSort.Click += new System.EventHandler(this.btnSort_Click);
            // 
            // btnDisplayStudents
            // 
            this.btnDisplayStudents.Location = new System.Drawing.Point(12, 258);
            this.btnDisplayStudents.Name = "btnDisplayStudents";
            this.btnDisplayStudents.Size = new System.Drawing.Size(162, 53);
            this.btnDisplayStudents.TabIndex = 5;
            this.btnDisplayStudents.Text = "Display Students";
            this.btnDisplayStudents.UseVisualStyleBackColor = true;
            this.btnDisplayStudents.Click += new System.EventHandler(this.btnDisplayStudents_Click);
            // 
            // txtKey
            // 
            this.txtKey.Location = new System.Drawing.Point(103, 317);
            this.txtKey.Name = "txtKey";
            this.txtKey.Size = new System.Drawing.Size(71, 20);
            this.txtKey.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 320);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Remove by ID #";
            // 
            // btnRemove
            // 
            this.btnRemove.Location = new System.Drawing.Point(12, 343);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(162, 53);
            this.btnRemove.TabIndex = 8;
            this.btnRemove.Text = "Remove at Key";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // txtKey2
            // 
            this.txtKey2.Location = new System.Drawing.Point(103, 402);
            this.txtKey2.Name = "txtKey2";
            this.txtKey2.Size = new System.Drawing.Size(71, 20);
            this.txtKey2.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 405);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Search by Key #";
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(12, 428);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(162, 53);
            this.btnSearch.TabIndex = 11;
            this.btnSearch.Text = "Search by key";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(519, 503);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtKey2);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtKey);
            this.Controls.Add(this.btnDisplayStudents);
            this.Controls.Add(this.btnSort);
            this.Controls.Add(this.btnStrQueue);
            this.Controls.Add(this.btnSecondLargest);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.btnAccounts);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAccounts;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button btnSecondLargest;
        private System.Windows.Forms.Button btnStrQueue;
        private System.Windows.Forms.Button btnSort;
        private System.Windows.Forms.Button btnDisplayStudents;
        private System.Windows.Forms.TextBox txtKey;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.TextBox txtKey2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnSearch;
    }
}

