namespace Lab02
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
            this.label01 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtfirstname = new System.Windows.Forms.TextBox();
            this.txtmiddleinitial = new System.Windows.Forms.TextBox();
            this.txtlastname = new System.Windows.Forms.TextBox();
            this.txtusername = new System.Windows.Forms.TextBox();
            this.txtareacode = new System.Windows.Forms.TextBox();
            this.txtphoneno = new System.Windows.Forms.TextBox();
            this.txtoutput = new System.Windows.Forms.TextBox();
            this.btnfullname = new System.Windows.Forms.Button();
            this.btnemail = new System.Windows.Forms.Button();
            this.btndisplayall = new System.Windows.Forms.Button();
            this.btnclear = new System.Windows.Forms.Button();
            this.btnclose = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label01
            // 
            this.label01.AutoSize = true;
            this.label01.Location = new System.Drawing.Point(34, 69);
            this.label01.Name = "label01";
            this.label01.Size = new System.Drawing.Size(58, 12);
            this.label01.TabIndex = 0;
            this.label01.Text = "First Name:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(34, 117);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 12);
            this.label1.TabIndex = 1;
            this.label1.Text = "Middle Initial:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(37, 168);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 12);
            this.label2.TabIndex = 2;
            this.label2.Text = "Last Name:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(41, 219);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 12);
            this.label3.TabIndex = 3;
            this.label3.Text = "User Name:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(42, 268);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 12);
            this.label4.TabIndex = 4;
            this.label4.Text = "Area Code:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(42, 307);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 12);
            this.label5.TabIndex = 5;
            this.label5.Text = "Phone No:";
            // 
            // txtfirstname
            // 
            this.txtfirstname.Location = new System.Drawing.Point(118, 66);
            this.txtfirstname.Name = "txtfirstname";
            this.txtfirstname.Size = new System.Drawing.Size(156, 22);
            this.txtfirstname.TabIndex = 6;
            // 
            // txtmiddleinitial
            // 
            this.txtmiddleinitial.Location = new System.Drawing.Point(118, 117);
            this.txtmiddleinitial.Name = "txtmiddleinitial";
            this.txtmiddleinitial.Size = new System.Drawing.Size(156, 22);
            this.txtmiddleinitial.TabIndex = 7;
            // 
            // txtlastname
            // 
            this.txtlastname.Location = new System.Drawing.Point(118, 165);
            this.txtlastname.Name = "txtlastname";
            this.txtlastname.Size = new System.Drawing.Size(157, 22);
            this.txtlastname.TabIndex = 8;
            // 
            // txtusername
            // 
            this.txtusername.Location = new System.Drawing.Point(116, 219);
            this.txtusername.Name = "txtusername";
            this.txtusername.Size = new System.Drawing.Size(158, 22);
            this.txtusername.TabIndex = 9;
            // 
            // txtareacode
            // 
            this.txtareacode.Location = new System.Drawing.Point(113, 265);
            this.txtareacode.Name = "txtareacode";
            this.txtareacode.Size = new System.Drawing.Size(161, 22);
            this.txtareacode.TabIndex = 10;
            // 
            // txtphoneno
            // 
            this.txtphoneno.Location = new System.Drawing.Point(113, 307);
            this.txtphoneno.Name = "txtphoneno";
            this.txtphoneno.Size = new System.Drawing.Size(161, 22);
            this.txtphoneno.TabIndex = 11;
            // 
            // txtoutput
            // 
            this.txtoutput.Location = new System.Drawing.Point(42, 348);
            this.txtoutput.Multiline = true;
            this.txtoutput.Name = "txtoutput";
            this.txtoutput.ReadOnly = true;
            this.txtoutput.Size = new System.Drawing.Size(241, 149);
            this.txtoutput.TabIndex = 12;
            // 
            // btnfullname
            // 
            this.btnfullname.Location = new System.Drawing.Point(296, 68);
            this.btnfullname.Name = "btnfullname";
            this.btnfullname.Size = new System.Drawing.Size(93, 31);
            this.btnfullname.TabIndex = 13;
            this.btnfullname.Text = "Full &Name";
            this.btnfullname.UseVisualStyleBackColor = true;
            this.btnfullname.Click += new System.EventHandler(this.btnfullname_Click);
            // 
            // btnemail
            // 
            this.btnemail.AutoEllipsis = true;
            this.btnemail.Location = new System.Drawing.Point(295, 120);
            this.btnemail.Name = "btnemail";
            this.btnemail.Size = new System.Drawing.Size(95, 28);
            this.btnemail.TabIndex = 14;
            this.btnemail.Text = "&Email";
            this.btnemail.UseVisualStyleBackColor = true;
            this.btnemail.Click += new System.EventHandler(this.btnemail_Click);
            // 
            // btndisplayall
            // 
            this.btndisplayall.Location = new System.Drawing.Point(296, 168);
            this.btndisplayall.Name = "btndisplayall";
            this.btndisplayall.Size = new System.Drawing.Size(93, 27);
            this.btndisplayall.TabIndex = 15;
            this.btndisplayall.Text = "&Display All";
            this.btndisplayall.UseVisualStyleBackColor = true;
            this.btndisplayall.Click += new System.EventHandler(this.btndisplayall_Click);
            // 
            // btnclear
            // 
            this.btnclear.Location = new System.Drawing.Point(296, 219);
            this.btnclear.Name = "btnclear";
            this.btnclear.Size = new System.Drawing.Size(93, 27);
            this.btnclear.TabIndex = 16;
            this.btnclear.Text = "C&lear";
            this.btnclear.UseVisualStyleBackColor = true;
            this.btnclear.Click += new System.EventHandler(this.btnclear_Click);
            // 
            // btnclose
            // 
            this.btnclose.Location = new System.Drawing.Point(295, 265);
            this.btnclose.Name = "btnclose";
            this.btnclose.Size = new System.Drawing.Size(92, 29);
            this.btnclose.TabIndex = 17;
            this.btnclose.Text = "&Close";
            this.btnclose.UseVisualStyleBackColor = true;
            this.btnclose.Click += new System.EventHandler(this.btnclose_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("PMingLiU", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label6.Location = new System.Drawing.Point(137, 26);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(196, 21);
            this.label6.TabIndex = 18;
            this.label6.Text = "PURDUE STUDENT";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(477, 592);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnclose);
            this.Controls.Add(this.btnclear);
            this.Controls.Add(this.btndisplayall);
            this.Controls.Add(this.btnemail);
            this.Controls.Add(this.btnfullname);
            this.Controls.Add(this.txtoutput);
            this.Controls.Add(this.txtphoneno);
            this.Controls.Add(this.txtareacode);
            this.Controls.Add(this.txtusername);
            this.Controls.Add(this.txtlastname);
            this.Controls.Add(this.txtmiddleinitial);
            this.Controls.Add(this.txtfirstname);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label01);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label01;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtfirstname;
        private System.Windows.Forms.TextBox txtmiddleinitial;
        private System.Windows.Forms.TextBox txtlastname;
        private System.Windows.Forms.TextBox txtusername;
        private System.Windows.Forms.TextBox txtareacode;
        private System.Windows.Forms.TextBox txtphoneno;
        private System.Windows.Forms.TextBox txtoutput;
        private System.Windows.Forms.Button btnfullname;
        private System.Windows.Forms.Button btnemail;
        private System.Windows.Forms.Button btndisplayall;
        private System.Windows.Forms.Button btnclear;
        private System.Windows.Forms.Button btnclose;
        private System.Windows.Forms.Label label6;
    }
}

