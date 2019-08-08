namespace PowersCSharpMidTermExam
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
            this.btnDisplay = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnDisplayAnimals = new System.Windows.Forms.Button();
            this.txtAnimalID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAnimalID = new System.Windows.Forms.Button();
            this.btnPictureAnimal = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(12, 12);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(506, 216);
            this.richTextBox1.TabIndex = 0;
            this.richTextBox1.Text = "";
            // 
            // btnDisplay
            // 
            this.btnDisplay.Location = new System.Drawing.Point(12, 234);
            this.btnDisplay.Name = "btnDisplay";
            this.btnDisplay.Size = new System.Drawing.Size(152, 45);
            this.btnDisplay.TabIndex = 1;
            this.btnDisplay.Text = "Display All";
            this.btnDisplay.UseVisualStyleBackColor = true;
            this.btnDisplay.Click += new System.EventHandler(this.btnDisplay_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(306, 235);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(211, 206);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // btnDisplayAnimals
            // 
            this.btnDisplayAnimals.Location = new System.Drawing.Point(12, 285);
            this.btnDisplayAnimals.Name = "btnDisplayAnimals";
            this.btnDisplayAnimals.Size = new System.Drawing.Size(152, 45);
            this.btnDisplayAnimals.TabIndex = 3;
            this.btnDisplayAnimals.Text = "Display All Animals";
            this.btnDisplayAnimals.UseVisualStyleBackColor = true;
            this.btnDisplayAnimals.Click += new System.EventHandler(this.btnDisplayAnimals_Click);
            // 
            // txtAnimalID
            // 
            this.txtAnimalID.Location = new System.Drawing.Point(81, 337);
            this.txtAnimalID.Name = "txtAnimalID";
            this.txtAnimalID.Size = new System.Drawing.Size(83, 20);
            this.txtAnimalID.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 340);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Animal ID #";
            // 
            // btnAnimalID
            // 
            this.btnAnimalID.Location = new System.Drawing.Point(12, 363);
            this.btnAnimalID.Name = "btnAnimalID";
            this.btnAnimalID.Size = new System.Drawing.Size(152, 45);
            this.btnAnimalID.TabIndex = 6;
            this.btnAnimalID.Text = "Find Animal by ID";
            this.btnAnimalID.UseVisualStyleBackColor = true;
            this.btnAnimalID.Click += new System.EventHandler(this.btnAnimalID_Click);
            // 
            // btnPictureAnimal
            // 
            this.btnPictureAnimal.Location = new System.Drawing.Point(171, 235);
            this.btnPictureAnimal.Name = "btnPictureAnimal";
            this.btnPictureAnimal.Size = new System.Drawing.Size(129, 44);
            this.btnPictureAnimal.TabIndex = 7;
            this.btnPictureAnimal.Text = "Display Animal Picture";
            this.btnPictureAnimal.UseVisualStyleBackColor = true;
            this.btnPictureAnimal.Click += new System.EventHandler(this.btnPictureAnimal_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(532, 453);
            this.Controls.Add(this.btnPictureAnimal);
            this.Controls.Add(this.btnAnimalID);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtAnimalID);
            this.Controls.Add(this.btnDisplayAnimals);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnDisplay);
            this.Controls.Add(this.richTextBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button btnDisplay;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnDisplayAnimals;
        private System.Windows.Forms.TextBox txtAnimalID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAnimalID;
        private System.Windows.Forms.Button btnPictureAnimal;
    }
}

