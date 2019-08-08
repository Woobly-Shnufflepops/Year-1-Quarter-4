namespace Bitwise_Operations
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.txtBase10 = new System.Windows.Forms.TextBox();
            this.txtBase2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnIntToBinary = new System.Windows.Forms.Button();
            this.btnBinaryToInt = new System.Windows.Forms.Button();
            this.txtBase16 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtResult = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnConvertBinaryToInt = new System.Windows.Forms.Button();
            this.btnAndBitwiseOperation = new System.Windows.Forms.Button();
            this.txtBinary2 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtBinary1 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txtBase16);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.btnBinaryToInt);
            this.panel1.Controls.Add(this.btnIntToBinary);
            this.panel1.Controls.Add(this.txtBase2);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.txtBase10);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(13, 13);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(185, 162);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(4, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Base 10 int";
            // 
            // txtBase10
            // 
            this.txtBase10.Location = new System.Drawing.Point(70, 4);
            this.txtBase10.Name = "txtBase10";
            this.txtBase10.Size = new System.Drawing.Size(100, 20);
            this.txtBase10.TabIndex = 1;
            // 
            // txtBase2
            // 
            this.txtBase2.Location = new System.Drawing.Point(70, 27);
            this.txtBase2.Name = "txtBase2";
            this.txtBase2.Size = new System.Drawing.Size(100, 20);
            this.txtBase2.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(4, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Base 2";
            // 
            // btnIntToBinary
            // 
            this.btnIntToBinary.Location = new System.Drawing.Point(7, 101);
            this.btnIntToBinary.Name = "btnIntToBinary";
            this.btnIntToBinary.Size = new System.Drawing.Size(163, 23);
            this.btnIntToBinary.TabIndex = 4;
            this.btnIntToBinary.Text = "Convert into to binary";
            this.btnIntToBinary.UseVisualStyleBackColor = true;
            this.btnIntToBinary.Click += new System.EventHandler(this.btnIntToBinary_Click);
            // 
            // btnBinaryToInt
            // 
            this.btnBinaryToInt.Location = new System.Drawing.Point(7, 130);
            this.btnBinaryToInt.Name = "btnBinaryToInt";
            this.btnBinaryToInt.Size = new System.Drawing.Size(163, 23);
            this.btnBinaryToInt.TabIndex = 5;
            this.btnBinaryToInt.Text = "Convert Binary to Int";
            this.btnBinaryToInt.UseVisualStyleBackColor = true;
            this.btnBinaryToInt.Click += new System.EventHandler(this.btnBinaryToInt_Click);
            // 
            // txtBase16
            // 
            this.txtBase16.Location = new System.Drawing.Point(70, 53);
            this.txtBase16.Name = "txtBase16";
            this.txtBase16.Size = new System.Drawing.Size(100, 20);
            this.txtBase16.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(4, 56);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Base 16";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.txtResult);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.btnConvertBinaryToInt);
            this.panel2.Controls.Add(this.btnAndBitwiseOperation);
            this.panel2.Controls.Add(this.txtBinary2);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.txtBinary1);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Location = new System.Drawing.Point(204, 13);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(185, 162);
            this.panel2.TabIndex = 8;
            // 
            // txtResult
            // 
            this.txtResult.Location = new System.Drawing.Point(70, 53);
            this.txtResult.Name = "txtResult";
            this.txtResult.Size = new System.Drawing.Size(100, 20);
            this.txtResult.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(4, 56);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Result";
            // 
            // btnConvertBinaryToInt
            // 
            this.btnConvertBinaryToInt.Location = new System.Drawing.Point(7, 130);
            this.btnConvertBinaryToInt.Name = "btnConvertBinaryToInt";
            this.btnConvertBinaryToInt.Size = new System.Drawing.Size(163, 23);
            this.btnConvertBinaryToInt.TabIndex = 5;
            this.btnConvertBinaryToInt.Text = "Convert binary to int";
            this.btnConvertBinaryToInt.UseVisualStyleBackColor = true;
            // 
            // btnAndBitwiseOperation
            // 
            this.btnAndBitwiseOperation.Location = new System.Drawing.Point(7, 101);
            this.btnAndBitwiseOperation.Name = "btnAndBitwiseOperation";
            this.btnAndBitwiseOperation.Size = new System.Drawing.Size(163, 23);
            this.btnAndBitwiseOperation.TabIndex = 4;
            this.btnAndBitwiseOperation.Text = "And Bitwise Operation";
            this.btnAndBitwiseOperation.UseVisualStyleBackColor = true;
            this.btnAndBitwiseOperation.Click += new System.EventHandler(this.btnAndBitwiseOperation_Click);
            // 
            // txtBinary2
            // 
            this.txtBinary2.Location = new System.Drawing.Point(70, 27);
            this.txtBinary2.Name = "txtBinary2";
            this.txtBinary2.Size = new System.Drawing.Size(100, 20);
            this.txtBinary2.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(4, 30);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 13);
            this.label5.TabIndex = 2;
            this.label5.Text = "binary2";
            // 
            // txtBinary1
            // 
            this.txtBinary1.Location = new System.Drawing.Point(70, 4);
            this.txtBinary1.Name = "txtBinary1";
            this.txtBinary1.Size = new System.Drawing.Size(100, 20);
            this.txtBinary1.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(4, 7);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(45, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "Binary 1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(588, 525);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnBinaryToInt;
        private System.Windows.Forms.Button btnIntToBinary;
        private System.Windows.Forms.TextBox txtBase2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtBase10;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtBase16;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txtResult;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnConvertBinaryToInt;
        private System.Windows.Forms.Button btnAndBitwiseOperation;
        private System.Windows.Forms.TextBox txtBinary2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtBinary1;
        private System.Windows.Forms.Label label6;
    }
}

