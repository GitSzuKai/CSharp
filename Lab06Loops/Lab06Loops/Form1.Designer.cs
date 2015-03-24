namespace Lab06Loops
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
            this.btncompute = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radSpecial = new System.Windows.Forms.RadioButton();
            this.radSumoddcubes = new System.Windows.Forms.RadioButton();
            this.radPennies = new System.Windows.Forms.RadioButton();
            this.radInverse = new System.Windows.Forms.RadioButton();
            this.radFactorial = new System.Windows.Forms.RadioButton();
            this.radSumofsquares = new System.Windows.Forms.RadioButton();
            this.btncount = new System.Windows.Forms.Button();
            this.btnsort = new System.Windows.Forms.Button();
            this.btnclear = new System.Windows.Forms.Button();
            this.btnexit = new System.Windows.Forms.Button();
            this.txtfullname = new System.Windows.Forms.TextBox();
            this.txtdays = new System.Windows.Forms.TextBox();
            this.txtpay = new System.Windows.Forms.TextBox();
            this.lstoutput = new System.Windows.Forms.ListBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btncompute
            // 
            this.btncompute.Location = new System.Drawing.Point(71, 152);
            this.btncompute.Name = "btncompute";
            this.btncompute.Size = new System.Drawing.Size(75, 23);
            this.btncompute.TabIndex = 3;
            this.btncompute.Text = "Compute";
            this.btncompute.UseVisualStyleBackColor = true;
            this.btncompute.Click += new System.EventHandler(this.btncompute_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 12);
            this.label1.TabIndex = 1;
            this.label1.Text = "Full Name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(39, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 12);
            this.label2.TabIndex = 2;
            this.label2.Text = "Days:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(39, 94);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(25, 12);
            this.label3.TabIndex = 3;
            this.label3.Text = "Pay:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radSpecial);
            this.groupBox1.Controls.Add(this.radSumoddcubes);
            this.groupBox1.Controls.Add(this.radPennies);
            this.groupBox1.Controls.Add(this.radInverse);
            this.groupBox1.Controls.Add(this.radFactorial);
            this.groupBox1.Controls.Add(this.radSumofsquares);
            this.groupBox1.Location = new System.Drawing.Point(12, 196);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(315, 100);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Pay options";
            // 
            // radSpecial
            // 
            this.radSpecial.AutoSize = true;
            this.radSpecial.Location = new System.Drawing.Point(10, 62);
            this.radSpecial.Name = "radSpecial";
            this.radSpecial.Size = new System.Drawing.Size(80, 16);
            this.radSpecial.TabIndex = 7;
            this.radSpecial.TabStop = true;
            this.radSpecial.Text = "Special Sum";
            this.radSpecial.UseVisualStyleBackColor = true;
            // 
            // radSumoddcubes
            // 
            this.radSumoddcubes.AutoSize = true;
            this.radSumoddcubes.Location = new System.Drawing.Point(211, 21);
            this.radSumoddcubes.Name = "radSumoddcubes";
            this.radSumoddcubes.Size = new System.Drawing.Size(97, 16);
            this.radSumoddcubes.TabIndex = 6;
            this.radSumoddcubes.TabStop = true;
            this.radSumoddcubes.Text = "Sum odd Cubes";
            this.radSumoddcubes.UseVisualStyleBackColor = true;
            // 
            // radPennies
            // 
            this.radPennies.AutoSize = true;
            this.radPennies.Location = new System.Drawing.Point(211, 62);
            this.radPennies.Name = "radPennies";
            this.radPennies.Size = new System.Drawing.Size(58, 16);
            this.radPennies.TabIndex = 5;
            this.radPennies.TabStop = true;
            this.radPennies.Text = "Pennies";
            this.radPennies.UseVisualStyleBackColor = true;
            // 
            // radInverse
            // 
            this.radInverse.AutoSize = true;
            this.radInverse.Location = new System.Drawing.Point(117, 62);
            this.radInverse.Name = "radInverse";
            this.radInverse.Size = new System.Drawing.Size(85, 16);
            this.radInverse.TabIndex = 4;
            this.radInverse.TabStop = true;
            this.radInverse.Text = "Sum Inverses";
            this.radInverse.UseVisualStyleBackColor = true;
            // 
            // radFactorial
            // 
            this.radFactorial.AutoSize = true;
            this.radFactorial.Location = new System.Drawing.Point(117, 21);
            this.radFactorial.Name = "radFactorial";
            this.radFactorial.Size = new System.Drawing.Size(63, 16);
            this.radFactorial.TabIndex = 1;
            this.radFactorial.TabStop = true;
            this.radFactorial.Text = "Factorial";
            this.radFactorial.UseVisualStyleBackColor = true;
            // 
            // radSumofsquares
            // 
            this.radSumofsquares.AutoSize = true;
            this.radSumofsquares.Location = new System.Drawing.Point(10, 21);
            this.radSumofsquares.Name = "radSumofsquares";
            this.radSumofsquares.Size = new System.Drawing.Size(94, 16);
            this.radSumofsquares.TabIndex = 0;
            this.radSumofsquares.TabStop = true;
            this.radSumofsquares.Text = "Sum of squares";
            this.radSumofsquares.UseVisualStyleBackColor = true;
            // 
            // btncount
            // 
            this.btncount.Location = new System.Drawing.Point(22, 303);
            this.btncount.Name = "btncount";
            this.btncount.Size = new System.Drawing.Size(75, 23);
            this.btncount.TabIndex = 5;
            this.btncount.Text = "Count";
            this.btncount.UseVisualStyleBackColor = true;
            this.btncount.Click += new System.EventHandler(this.btncount_Click);
            // 
            // btnsort
            // 
            this.btnsort.Location = new System.Drawing.Point(117, 303);
            this.btnsort.Name = "btnsort";
            this.btnsort.Size = new System.Drawing.Size(75, 23);
            this.btnsort.TabIndex = 6;
            this.btnsort.Text = "Sort Names";
            this.btnsort.UseVisualStyleBackColor = true;
            this.btnsort.Click += new System.EventHandler(this.btnsort_Click);
            // 
            // btnclear
            // 
            this.btnclear.Location = new System.Drawing.Point(206, 303);
            this.btnclear.Name = "btnclear";
            this.btnclear.Size = new System.Drawing.Size(75, 23);
            this.btnclear.TabIndex = 7;
            this.btnclear.Text = "C&lear";
            this.btnclear.UseVisualStyleBackColor = true;
            this.btnclear.Click += new System.EventHandler(this.btnclear_Click);
            // 
            // btnexit
            // 
            this.btnexit.Location = new System.Drawing.Point(291, 303);
            this.btnexit.Name = "btnexit";
            this.btnexit.Size = new System.Drawing.Size(75, 23);
            this.btnexit.TabIndex = 8;
            this.btnexit.Text = "E&xit";
            this.btnexit.UseVisualStyleBackColor = true;
            this.btnexit.Click += new System.EventHandler(this.btnexit_Click);
            // 
            // txtfullname
            // 
            this.txtfullname.Location = new System.Drawing.Point(92, 28);
            this.txtfullname.Name = "txtfullname";
            this.txtfullname.Size = new System.Drawing.Size(100, 22);
            this.txtfullname.TabIndex = 0;
            // 
            // txtdays
            // 
            this.txtdays.Location = new System.Drawing.Point(92, 57);
            this.txtdays.Name = "txtdays";
            this.txtdays.Size = new System.Drawing.Size(100, 22);
            this.txtdays.TabIndex = 1;
            // 
            // txtpay
            // 
            this.txtpay.Location = new System.Drawing.Point(92, 91);
            this.txtpay.Name = "txtpay";
            this.txtpay.ReadOnly = true;
            this.txtpay.Size = new System.Drawing.Size(100, 22);
            this.txtpay.TabIndex = 11;
            // 
            // lstoutput
            // 
            this.lstoutput.FormattingEnabled = true;
            this.lstoutput.ItemHeight = 12;
            this.lstoutput.Location = new System.Drawing.Point(223, 28);
            this.lstoutput.Name = "lstoutput";
            this.lstoutput.Size = new System.Drawing.Size(131, 160);
            this.lstoutput.TabIndex = 12;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(391, 347);
            this.Controls.Add(this.lstoutput);
            this.Controls.Add(this.txtpay);
            this.Controls.Add(this.txtdays);
            this.Controls.Add(this.txtfullname);
            this.Controls.Add(this.btnexit);
            this.Controls.Add(this.btnclear);
            this.Controls.Add(this.btnsort);
            this.Controls.Add(this.btncount);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btncompute);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btncompute;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radPennies;
        private System.Windows.Forms.RadioButton radInverse;
        private System.Windows.Forms.RadioButton radFactorial;
        private System.Windows.Forms.RadioButton radSumofsquares;
        private System.Windows.Forms.Button btncount;
        private System.Windows.Forms.Button btnsort;
        private System.Windows.Forms.Button btnclear;
        private System.Windows.Forms.Button btnexit;
        private System.Windows.Forms.TextBox txtfullname;
        private System.Windows.Forms.TextBox txtdays;
        private System.Windows.Forms.TextBox txtpay;
        private System.Windows.Forms.ListBox lstoutput;
        private System.Windows.Forms.RadioButton radSpecial;
        private System.Windows.Forms.RadioButton radSumoddcubes;
    }
}

