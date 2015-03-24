namespace Lab04Roots_of_Quadratic_Equation
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
            this.txtcoefficienta = new System.Windows.Forms.TextBox();
            this.txtcoefficientb = new System.Windows.Forms.TextBox();
            this.txtcoefficientc = new System.Windows.Forms.TextBox();
            this.txtroot = new System.Windows.Forms.TextBox();
            this.btncompute = new System.Windows.Forms.Button();
            this.btnclear = new System.Windows.Forms.Button();
            this.btnfindmax = new System.Windows.Forms.Button();
            this.btnsurprise = new System.Windows.Forms.Button();
            this.btnexit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("PMingLiU", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.textBox1.Location = new System.Drawing.Point(107, 17);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(224, 27);
            this.textBox1.TabIndex = 0;
            this.textBox1.TabStop = false;
            this.textBox1.Text = "Quadratic Equation Roots";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(35, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 12);
            this.label1.TabIndex = 1;
            this.label1.Text = "Coefficient a:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(36, 98);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 12);
            this.label2.TabIndex = 2;
            this.label2.Text = "Coefficient b:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(35, 149);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 12);
            this.label3.TabIndex = 3;
            this.label3.Text = "Coefficient c:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(36, 194);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 12);
            this.label4.TabIndex = 4;
            this.label4.Text = "Root(s):";
            // 
            // txtcoefficienta
            // 
            this.txtcoefficienta.Location = new System.Drawing.Point(114, 55);
            this.txtcoefficienta.Name = "txtcoefficienta";
            this.txtcoefficienta.Size = new System.Drawing.Size(208, 22);
            this.txtcoefficienta.TabIndex = 0;
            // 
            // txtcoefficientb
            // 
            this.txtcoefficientb.Location = new System.Drawing.Point(114, 95);
            this.txtcoefficientb.Name = "txtcoefficientb";
            this.txtcoefficientb.Size = new System.Drawing.Size(208, 22);
            this.txtcoefficientb.TabIndex = 1;
            // 
            // txtcoefficientc
            // 
            this.txtcoefficientc.Location = new System.Drawing.Point(114, 146);
            this.txtcoefficientc.Name = "txtcoefficientc";
            this.txtcoefficientc.Size = new System.Drawing.Size(208, 22);
            this.txtcoefficientc.TabIndex = 7;
            // 
            // txtroot
            // 
            this.txtroot.Location = new System.Drawing.Point(114, 197);
            this.txtroot.Multiline = true;
            this.txtroot.Name = "txtroot";
            this.txtroot.Size = new System.Drawing.Size(208, 86);
            this.txtroot.TabIndex = 8;
            // 
            // btncompute
            // 
            this.btncompute.Location = new System.Drawing.Point(354, 58);
            this.btncompute.Name = "btncompute";
            this.btncompute.Size = new System.Drawing.Size(79, 32);
            this.btncompute.TabIndex = 9;
            this.btncompute.Text = "C&ompute";
            this.btncompute.UseVisualStyleBackColor = true;
            this.btncompute.Click += new System.EventHandler(this.btncompute_Click);
            // 
            // btnclear
            // 
            this.btnclear.Location = new System.Drawing.Point(354, 110);
            this.btnclear.Name = "btnclear";
            this.btnclear.Size = new System.Drawing.Size(79, 29);
            this.btnclear.TabIndex = 10;
            this.btnclear.Text = "C&lear";
            this.btnclear.UseVisualStyleBackColor = true;
            this.btnclear.Click += new System.EventHandler(this.btnclear_Click);
            // 
            // btnfindmax
            // 
            this.btnfindmax.Location = new System.Drawing.Point(354, 154);
            this.btnfindmax.Name = "btnfindmax";
            this.btnfindmax.Size = new System.Drawing.Size(79, 31);
            this.btnfindmax.TabIndex = 11;
            this.btnfindmax.Text = "&Find Max";
            this.btnfindmax.UseVisualStyleBackColor = true;
            this.btnfindmax.Click += new System.EventHandler(this.btnfindmax_Click);
            // 
            // btnsurprise
            // 
            this.btnsurprise.Location = new System.Drawing.Point(354, 197);
            this.btnsurprise.Name = "btnsurprise";
            this.btnsurprise.Size = new System.Drawing.Size(79, 30);
            this.btnsurprise.TabIndex = 12;
            this.btnsurprise.Text = "&Surprise";
            this.btnsurprise.UseVisualStyleBackColor = true;
            this.btnsurprise.Click += new System.EventHandler(this.btnsurprise_Click);
            // 
            // btnexit
            // 
            this.btnexit.Location = new System.Drawing.Point(354, 243);
            this.btnexit.Name = "btnexit";
            this.btnexit.Size = new System.Drawing.Size(79, 29);
            this.btnexit.TabIndex = 13;
            this.btnexit.Text = "E&xit";
            this.btnexit.UseVisualStyleBackColor = true;
            this.btnexit.Click += new System.EventHandler(this.btnexit_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(454, 323);
            this.Controls.Add(this.btnexit);
            this.Controls.Add(this.btnsurprise);
            this.Controls.Add(this.btnfindmax);
            this.Controls.Add(this.btnclear);
            this.Controls.Add(this.btncompute);
            this.Controls.Add(this.txtroot);
            this.Controls.Add(this.txtcoefficientc);
            this.Controls.Add(this.txtcoefficientb);
            this.Controls.Add(this.txtcoefficienta);
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
        private System.Windows.Forms.TextBox txtcoefficienta;
        private System.Windows.Forms.TextBox txtcoefficientb;
        private System.Windows.Forms.TextBox txtcoefficientc;
        private System.Windows.Forms.TextBox txtroot;
        private System.Windows.Forms.Button btncompute;
        private System.Windows.Forms.Button btnclear;
        private System.Windows.Forms.Button btnfindmax;
        private System.Windows.Forms.Button btnsurprise;
        private System.Windows.Forms.Button btnexit;
    }
}

