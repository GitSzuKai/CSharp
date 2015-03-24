namespace Lab03_VariableArithmetic
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
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtcoupon = new System.Windows.Forms.TextBox();
            this.txtnumdrink = new System.Windows.Forms.TextBox();
            this.txtnumpizza = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txttotaleuro = new System.Windows.Forms.TextBox();
            this.txttaxtotal = new System.Windows.Forms.TextBox();
            this.txtafterdiscount = new System.Windows.Forms.TextBox();
            this.txtdiscount = new System.Windows.Forms.TextBox();
            this.txtsubtotal = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btncompute = new System.Windows.Forms.Button();
            this.btnsurprise = new System.Windows.Forms.Button();
            this.btnclear = new System.Windows.Forms.Button();
            this.btnexit = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(118, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 12);
            this.label1.TabIndex = 0;
            // 
            // textBox1
            // 
            this.textBox1.Enabled = false;
            this.textBox1.Font = new System.Drawing.Font("PMingLiU", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.textBox1.Location = new System.Drawing.Point(96, 23);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(221, 27);
            this.textBox1.TabIndex = 1;
            this.textBox1.Text = "Milano Pizza";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtcoupon);
            this.groupBox1.Controls.Add(this.txtnumdrink);
            this.groupBox1.Controls.Add(this.txtnumpizza);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(25, 75);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(378, 182);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Order:";
            // 
            // txtcoupon
            // 
            this.txtcoupon.Location = new System.Drawing.Point(154, 120);
            this.txtcoupon.Name = "txtcoupon";
            this.txtcoupon.Size = new System.Drawing.Size(100, 22);
            this.txtcoupon.TabIndex = 7;
            // 
            // txtnumdrink
            // 
            this.txtnumdrink.Location = new System.Drawing.Point(154, 69);
            this.txtnumdrink.Name = "txtnumdrink";
            this.txtnumdrink.Size = new System.Drawing.Size(100, 22);
            this.txtnumdrink.TabIndex = 6;
            // 
            // txtnumpizza
            // 
            this.txtnumpizza.Location = new System.Drawing.Point(154, 22);
            this.txtnumpizza.Name = "txtnumpizza";
            this.txtnumpizza.Size = new System.Drawing.Size(100, 22);
            this.txtnumpizza.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(23, 123);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 12);
            this.label4.TabIndex = 2;
            this.label4.Text = "Coupons(%)";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(23, 72);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 12);
            this.label3.TabIndex = 1;
            this.label3.Text = "# of drinks:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 12);
            this.label2.TabIndex = 0;
            this.label2.Text = "# of pizza:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txttotaleuro);
            this.groupBox2.Controls.Add(this.txttaxtotal);
            this.groupBox2.Controls.Add(this.txtafterdiscount);
            this.groupBox2.Controls.Add(this.txtdiscount);
            this.groupBox2.Controls.Add(this.txtsubtotal);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Location = new System.Drawing.Point(25, 275);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(377, 184);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Cost:";
            // 
            // txttotaleuro
            // 
            this.txttotaleuro.Location = new System.Drawing.Point(154, 142);
            this.txttotaleuro.Name = "txttotaleuro";
            this.txttotaleuro.ReadOnly = true;
            this.txttotaleuro.Size = new System.Drawing.Size(100, 22);
            this.txttotaleuro.TabIndex = 9;
            // 
            // txttaxtotal
            // 
            this.txttaxtotal.Location = new System.Drawing.Point(154, 118);
            this.txttaxtotal.Name = "txttaxtotal";
            this.txttaxtotal.ReadOnly = true;
            this.txttaxtotal.Size = new System.Drawing.Size(100, 22);
            this.txttaxtotal.TabIndex = 8;
            // 
            // txtafterdiscount
            // 
            this.txtafterdiscount.Location = new System.Drawing.Point(154, 91);
            this.txtafterdiscount.Name = "txtafterdiscount";
            this.txtafterdiscount.ReadOnly = true;
            this.txtafterdiscount.Size = new System.Drawing.Size(100, 22);
            this.txtafterdiscount.TabIndex = 7;
            // 
            // txtdiscount
            // 
            this.txtdiscount.Location = new System.Drawing.Point(154, 60);
            this.txtdiscount.Name = "txtdiscount";
            this.txtdiscount.ReadOnly = true;
            this.txtdiscount.Size = new System.Drawing.Size(100, 22);
            this.txtdiscount.TabIndex = 6;
            // 
            // txtsubtotal
            // 
            this.txtsubtotal.Location = new System.Drawing.Point(154, 29);
            this.txtsubtotal.Name = "txtsubtotal";
            this.txtsubtotal.ReadOnly = true;
            this.txtsubtotal.Size = new System.Drawing.Size(100, 22);
            this.txtsubtotal.TabIndex = 5;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(23, 145);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(80, 12);
            this.label9.TabIndex = 4;
            this.label9.Text = "Price + tax (€):";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(23, 118);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(74, 12);
            this.label8.TabIndex = 3;
            this.label8.Text = "Price + tax ($):";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(23, 91);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(88, 12);
            this.label7.TabIndex = 2;
            this.label7.Text = "After discount($):";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(23, 60);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(49, 12);
            this.label6.TabIndex = 1;
            this.label6.Text = "Discount:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(23, 29);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 12);
            this.label5.TabIndex = 0;
            this.label5.Text = "Subtotal:";
            // 
            // btncompute
            // 
            this.btncompute.Location = new System.Drawing.Point(25, 477);
            this.btncompute.Name = "btncompute";
            this.btncompute.Size = new System.Drawing.Size(120, 37);
            this.btncompute.TabIndex = 4;
            this.btncompute.Text = "&Compute";
            this.btncompute.UseVisualStyleBackColor = true;
            this.btncompute.Click += new System.EventHandler(this.btncompute_Click);
            // 
            // btnsurprise
            // 
            this.btnsurprise.Location = new System.Drawing.Point(151, 477);
            this.btnsurprise.Name = "btnsurprise";
            this.btnsurprise.Size = new System.Drawing.Size(96, 36);
            this.btnsurprise.TabIndex = 5;
            this.btnsurprise.Text = "&Surprise";
            this.btnsurprise.UseVisualStyleBackColor = true;
            this.btnsurprise.Click += new System.EventHandler(this.btnsurprise_Click);
            // 
            // btnclear
            // 
            this.btnclear.Location = new System.Drawing.Point(253, 477);
            this.btnclear.Name = "btnclear";
            this.btnclear.Size = new System.Drawing.Size(99, 36);
            this.btnclear.TabIndex = 6;
            this.btnclear.Text = "C&lear";
            this.btnclear.UseVisualStyleBackColor = true;
            this.btnclear.Click += new System.EventHandler(this.btnclear_Click);
            // 
            // btnexit
            // 
            this.btnexit.Location = new System.Drawing.Point(361, 477);
            this.btnexit.Name = "btnexit";
            this.btnexit.Size = new System.Drawing.Size(87, 36);
            this.btnexit.TabIndex = 7;
            this.btnexit.Text = "E&xit";
            this.btnexit.UseVisualStyleBackColor = true;
            this.btnexit.Click += new System.EventHandler(this.btnexit_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(460, 579);
            this.Controls.Add(this.btnexit);
            this.Controls.Add(this.btnclear);
            this.Controls.Add(this.btnsurprise);
            this.Controls.Add(this.btncompute);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtcoupon;
        private System.Windows.Forms.TextBox txtnumdrink;
        private System.Windows.Forms.TextBox txtnumpizza;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txttotaleuro;
        private System.Windows.Forms.TextBox txttaxtotal;
        private System.Windows.Forms.TextBox txtafterdiscount;
        private System.Windows.Forms.TextBox txtdiscount;
        private System.Windows.Forms.TextBox txtsubtotal;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btncompute;
        private System.Windows.Forms.Button btnsurprise;
        private System.Windows.Forms.Button btnclear;
        private System.Windows.Forms.Button btnexit;
    }
}

