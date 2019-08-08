namespace Recursive_Methods
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
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.btnNormalMethod = new System.Windows.Forms.Button();
            this.btnRecursiveMethod = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnFactorialNormal = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnStars = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.btnStarRecursive = new System.Windows.Forms.Button();
            this.btnStarReverse = new System.Windows.Forms.Button();
            this.btnReverseStarsRecursion = new System.Windows.Forms.Button();
            this.btnPalindrome = new System.Windows.Forms.Button();
            this.btnRecursivePalindrome = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(13, 13);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(481, 160);
            this.listBox1.TabIndex = 0;
            // 
            // btnNormalMethod
            // 
            this.btnNormalMethod.Location = new System.Drawing.Point(13, 180);
            this.btnNormalMethod.Name = "btnNormalMethod";
            this.btnNormalMethod.Size = new System.Drawing.Size(186, 45);
            this.btnNormalMethod.TabIndex = 1;
            this.btnNormalMethod.Text = "Normal Method";
            this.btnNormalMethod.UseVisualStyleBackColor = true;
            this.btnNormalMethod.Click += new System.EventHandler(this.btnNormalMethod_Click);
            // 
            // btnRecursiveMethod
            // 
            this.btnRecursiveMethod.Location = new System.Drawing.Point(302, 179);
            this.btnRecursiveMethod.Name = "btnRecursiveMethod";
            this.btnRecursiveMethod.Size = new System.Drawing.Size(192, 46);
            this.btnRecursiveMethod.TabIndex = 2;
            this.btnRecursiveMethod.Text = "Recursive Method";
            this.btnRecursiveMethod.UseVisualStyleBackColor = true;
            this.btnRecursiveMethod.Click += new System.EventHandler(this.btnRecursiveMethod_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(205, 180);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(91, 46);
            this.btnClear.TabIndex = 3;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnFactorialNormal
            // 
            this.btnFactorialNormal.Location = new System.Drawing.Point(13, 231);
            this.btnFactorialNormal.Name = "btnFactorialNormal";
            this.btnFactorialNormal.Size = new System.Drawing.Size(186, 45);
            this.btnFactorialNormal.TabIndex = 4;
            this.btnFactorialNormal.Text = "Facotrial Normal";
            this.btnFactorialNormal.UseVisualStyleBackColor = true;
            this.btnFactorialNormal.Click += new System.EventHandler(this.btnFactorialNormal_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(99, 283);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 286);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Number of Stars";
            // 
            // btnStars
            // 
            this.btnStars.Location = new System.Drawing.Point(12, 309);
            this.btnStars.Name = "btnStars";
            this.btnStars.Size = new System.Drawing.Size(186, 24);
            this.btnStars.TabIndex = 7;
            this.btnStars.Text = "Display Stars";
            this.btnStars.UseVisualStyleBackColor = true;
            this.btnStars.Click += new System.EventHandler(this.btnStars_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(206, 231);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(289, 298);
            this.richTextBox1.TabIndex = 8;
            this.richTextBox1.Text = "";
            // 
            // btnStarRecursive
            // 
            this.btnStarRecursive.Location = new System.Drawing.Point(13, 339);
            this.btnStarRecursive.Name = "btnStarRecursive";
            this.btnStarRecursive.Size = new System.Drawing.Size(186, 24);
            this.btnStarRecursive.TabIndex = 9;
            this.btnStarRecursive.Text = "Display Stars Recursive";
            this.btnStarRecursive.UseVisualStyleBackColor = true;
            this.btnStarRecursive.Click += new System.EventHandler(this.btnStarRecursive_Click);
            // 
            // btnStarReverse
            // 
            this.btnStarReverse.Location = new System.Drawing.Point(12, 369);
            this.btnStarReverse.Name = "btnStarReverse";
            this.btnStarReverse.Size = new System.Drawing.Size(186, 24);
            this.btnStarReverse.TabIndex = 10;
            this.btnStarReverse.Text = "Reverse Stars";
            this.btnStarReverse.UseVisualStyleBackColor = true;
            this.btnStarReverse.Click += new System.EventHandler(this.btnStarReverse_Click);
            // 
            // btnReverseStarsRecursion
            // 
            this.btnReverseStarsRecursion.Location = new System.Drawing.Point(12, 399);
            this.btnReverseStarsRecursion.Name = "btnReverseStarsRecursion";
            this.btnReverseStarsRecursion.Size = new System.Drawing.Size(186, 24);
            this.btnReverseStarsRecursion.TabIndex = 11;
            this.btnReverseStarsRecursion.Text = "Reverse Stars Recursion";
            this.btnReverseStarsRecursion.UseVisualStyleBackColor = true;
            this.btnReverseStarsRecursion.Click += new System.EventHandler(this.btnReverseStarsRecursion_Click);
            // 
            // btnPalindrome
            // 
            this.btnPalindrome.Location = new System.Drawing.Point(13, 429);
            this.btnPalindrome.Name = "btnPalindrome";
            this.btnPalindrome.Size = new System.Drawing.Size(91, 24);
            this.btnPalindrome.TabIndex = 12;
            this.btnPalindrome.Text = "Palindrome?";
            this.btnPalindrome.UseVisualStyleBackColor = true;
            this.btnPalindrome.Click += new System.EventHandler(this.btnPalindrome_Click);
            // 
            // btnRecursivePalindrome
            // 
            this.btnRecursivePalindrome.Location = new System.Drawing.Point(110, 429);
            this.btnRecursivePalindrome.Name = "btnRecursivePalindrome";
            this.btnRecursivePalindrome.Size = new System.Drawing.Size(88, 24);
            this.btnRecursivePalindrome.TabIndex = 13;
            this.btnRecursivePalindrome.Text = "REPalindrome?";
            this.btnRecursivePalindrome.UseVisualStyleBackColor = true;
            this.btnRecursivePalindrome.Click += new System.EventHandler(this.btnRecursivePalindrome_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(507, 541);
            this.Controls.Add(this.btnRecursivePalindrome);
            this.Controls.Add(this.btnPalindrome);
            this.Controls.Add(this.btnReverseStarsRecursion);
            this.Controls.Add(this.btnStarReverse);
            this.Controls.Add(this.btnStarRecursive);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.btnStars);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btnFactorialNormal);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnRecursiveMethod);
            this.Controls.Add(this.btnNormalMethod);
            this.Controls.Add(this.listBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button btnNormalMethod;
        private System.Windows.Forms.Button btnRecursiveMethod;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnFactorialNormal;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnStars;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button btnStarRecursive;
        private System.Windows.Forms.Button btnStarReverse;
        private System.Windows.Forms.Button btnReverseStarsRecursion;
        private System.Windows.Forms.Button btnPalindrome;
        private System.Windows.Forms.Button btnRecursivePalindrome;
    }
}

