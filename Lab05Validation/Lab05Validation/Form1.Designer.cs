namespace Lab05Validation
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtname = new System.Windows.Forms.TextBox();
            this.txtid = new System.Windows.Forms.TextBox();
            this.txtdepartment = new System.Windows.Forms.TextBox();
            this.txtgpa = new System.Windows.Forms.TextBox();
            this.txtoutput = new System.Windows.Forms.TextBox();
            this.btnevaluate = new System.Windows.Forms.Button();
            this.btnclear = new System.Windows.Forms.Button();
            this.btnexit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(72, 23);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(195, 22);
            this.textBox1.TabIndex = 0;
            this.textBox1.TabStop = false;
            this.textBox1.Text = "Hanks Scholarhip Program";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 12);
            this.label1.TabIndex = 1;
            this.label1.Text = "Enter Name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 118);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 12);
            this.label2.TabIndex = 2;
            this.label2.Text = "Student ID:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 171);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 12);
            this.label3.TabIndex = 3;
            this.label3.Text = "Department :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 224);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(30, 12);
            this.label4.TabIndex = 4;
            this.label4.Text = "GPA:";
            // 
            // txtname
            // 
            this.txtname.Location = new System.Drawing.Point(81, 61);
            this.txtname.Name = "txtname";
            this.txtname.Size = new System.Drawing.Size(194, 22);
            this.txtname.TabIndex = 5;
            // 
            // txtid
            // 
            this.txtid.Location = new System.Drawing.Point(81, 115);
            this.txtid.Name = "txtid";
            this.txtid.Size = new System.Drawing.Size(194, 22);
            this.txtid.TabIndex = 6;
            // 
            // txtdepartment
            // 
            this.txtdepartment.Location = new System.Drawing.Point(81, 168);
            this.txtdepartment.Name = "txtdepartment";
            this.txtdepartment.Size = new System.Drawing.Size(194, 22);
            this.txtdepartment.TabIndex = 7;
            // 
            // txtgpa
            // 
            this.txtgpa.Location = new System.Drawing.Point(81, 221);
            this.txtgpa.Name = "txtgpa";
            this.txtgpa.Size = new System.Drawing.Size(194, 22);
            this.txtgpa.TabIndex = 8;
            // 
            // txtoutput
            // 
            this.txtoutput.Location = new System.Drawing.Point(18, 272);
            this.txtoutput.Multiline = true;
            this.txtoutput.Name = "txtoutput";
            this.txtoutput.ReadOnly = true;
            this.txtoutput.Size = new System.Drawing.Size(320, 82);
            this.txtoutput.TabIndex = 9;
            // 
            // btnevaluate
            // 
            this.btnevaluate.Location = new System.Drawing.Point(16, 395);
            this.btnevaluate.Name = "btnevaluate";
            this.btnevaluate.Size = new System.Drawing.Size(122, 39);
            this.btnevaluate.TabIndex = 10;
            this.btnevaluate.Text = "&Evaluate";
            this.btnevaluate.UseVisualStyleBackColor = true;
            this.btnevaluate.Click += new System.EventHandler(this.btnevaluate_Click);
            // 
            // btnclear
            // 
            this.btnclear.Location = new System.Drawing.Point(144, 395);
            this.btnclear.Name = "btnclear";
            this.btnclear.Size = new System.Drawing.Size(110, 38);
            this.btnclear.TabIndex = 11;
            this.btnclear.Text = "&Clear";
            this.btnclear.UseVisualStyleBackColor = true;
            this.btnclear.Click += new System.EventHandler(this.btnclear_Click);
            // 
            // btnexit
            // 
            this.btnexit.Location = new System.Drawing.Point(271, 397);
            this.btnexit.Name = "btnexit";
            this.btnexit.Size = new System.Drawing.Size(101, 35);
            this.btnexit.TabIndex = 12;
            this.btnexit.Text = "E&xit";
            this.btnexit.UseVisualStyleBackColor = true;
            this.btnexit.Click += new System.EventHandler(this.btnexit_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(391, 479);
            this.Controls.Add(this.btnexit);
            this.Controls.Add(this.btnclear);
            this.Controls.Add(this.btnevaluate);
            this.Controls.Add(this.txtoutput);
            this.Controls.Add(this.txtgpa);
            this.Controls.Add(this.txtdepartment);
            this.Controls.Add(this.txtid);
            this.Controls.Add(this.txtname);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtname;
        private System.Windows.Forms.TextBox txtid;
        private System.Windows.Forms.TextBox txtdepartment;
        private System.Windows.Forms.TextBox txtgpa;
        private System.Windows.Forms.TextBox txtoutput;
        private System.Windows.Forms.Button btnevaluate;
        private System.Windows.Forms.Button btnclear;
        private System.Windows.Forms.Button btnexit;
    }
}

