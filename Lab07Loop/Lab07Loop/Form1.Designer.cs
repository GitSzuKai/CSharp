namespace Lab07Loop
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
            this.txtstarting = new System.Windows.Forms.TextBox();
            this.label02 = new System.Windows.Forms.Label();
            this.txtyears = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txttotcost = new System.Windows.Forms.TextBox();
            this.lstoutput = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btndisplay = new System.Windows.Forms.Button();
            this.btnttcost = new System.Windows.Forms.Button();
            this.btnclear = new System.Windows.Forms.Button();
            this.btnexit = new System.Windows.Forms.Button();
            this.lblerror = new System.Windows.Forms.Label();
            this.lblerroryear = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.textBox1.Location = new System.Drawing.Point(157, 3);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(194, 22);
            this.textBox1.TabIndex = 10000;
            this.textBox1.Text = "Help The Children Foundation";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Location = new System.Drawing.Point(0, 65);
            this.label1.Margin = new System.Windows.Forms.Padding(0, 15, 15, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Starting Number:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtstarting
            // 
            this.txtstarting.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtstarting.Location = new System.Drawing.Point(127, 65);
            this.txtstarting.Margin = new System.Windows.Forms.Padding(0, 15, 0, 15);
            this.txtstarting.Name = "txtstarting";
            this.txtstarting.Size = new System.Drawing.Size(255, 22);
            this.txtstarting.TabIndex = 2;
            this.txtstarting.TextChanged += new System.EventHandler(this.txtstarting_TextChanged);
            // 
            // label02
            // 
            this.label02.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label02.Location = new System.Drawing.Point(0, 115);
            this.label02.Margin = new System.Windows.Forms.Padding(0, 15, 15, 15);
            this.label02.Name = "label02";
            this.label02.Size = new System.Drawing.Size(112, 20);
            this.label02.TabIndex = 3;
            this.label02.Text = "Years:";
            this.label02.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtyears
            // 
            this.txtyears.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtyears.Location = new System.Drawing.Point(127, 115);
            this.txtyears.Margin = new System.Windows.Forms.Padding(0, 15, 0, 15);
            this.txtyears.Name = "txtyears";
            this.txtyears.Size = new System.Drawing.Size(255, 22);
            this.txtyears.TabIndex = 4;
            this.txtyears.TextChanged += new System.EventHandler(this.txtyears_TextChanged);
            // 
            // label2
            // 
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Location = new System.Drawing.Point(0, 165);
            this.label2.Margin = new System.Windows.Forms.Padding(0, 15, 15, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 24);
            this.label2.TabIndex = 5;
            this.label2.Text = "Total Cost:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txttotcost
            // 
            this.txttotcost.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txttotcost.Location = new System.Drawing.Point(127, 165);
            this.txttotcost.Margin = new System.Windows.Forms.Padding(0, 15, 0, 15);
            this.txttotcost.Name = "txttotcost";
            this.txttotcost.ReadOnly = true;
            this.txttotcost.Size = new System.Drawing.Size(255, 22);
            this.txttotcost.TabIndex = 6;
            // 
            // lstoutput
            // 
            this.lstoutput.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lstoutput.FormattingEnabled = true;
            this.lstoutput.ItemHeight = 12;
            this.lstoutput.Location = new System.Drawing.Point(34, 241);
            this.lstoutput.Name = "lstoutput";
            this.lstoutput.Size = new System.Drawing.Size(438, 160);
            this.lstoutput.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(32, 226);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(27, 12);
            this.label3.TabIndex = 8;
            this.label3.Text = "Year";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(116, 223);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(26, 12);
            this.label4.TabIndex = 9;
            this.label4.Text = "Kids";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(219, 223);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(26, 12);
            this.label5.TabIndex = 10;
            this.label5.Text = "Cost";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(331, 223);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 12);
            this.label6.TabIndex = 11;
            this.label6.Text = "Total Kids";
            // 
            // btndisplay
            // 
            this.btndisplay.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btndisplay.Location = new System.Drawing.Point(15, 15);
            this.btndisplay.Margin = new System.Windows.Forms.Padding(15);
            this.btndisplay.Name = "btndisplay";
            this.btndisplay.Size = new System.Drawing.Size(97, 22);
            this.btndisplay.TabIndex = 12;
            this.btndisplay.Text = "&Display All";
            this.btndisplay.UseVisualStyleBackColor = true;
            this.btndisplay.Click += new System.EventHandler(this.btndisplay_Click);
            // 
            // btnttcost
            // 
            this.btnttcost.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnttcost.Location = new System.Drawing.Point(142, 15);
            this.btnttcost.Margin = new System.Windows.Forms.Padding(15);
            this.btnttcost.Name = "btnttcost";
            this.btnttcost.Size = new System.Drawing.Size(97, 22);
            this.btnttcost.TabIndex = 13;
            this.btnttcost.Text = "&Total Cost";
            this.btnttcost.UseVisualStyleBackColor = true;
            this.btnttcost.Click += new System.EventHandler(this.btnttcost_Click);
            // 
            // btnclear
            // 
            this.btnclear.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnclear.Location = new System.Drawing.Point(269, 15);
            this.btnclear.Margin = new System.Windows.Forms.Padding(15);
            this.btnclear.Name = "btnclear";
            this.btnclear.Size = new System.Drawing.Size(97, 22);
            this.btnclear.TabIndex = 14;
            this.btnclear.Text = "&Clear";
            this.btnclear.UseVisualStyleBackColor = true;
            this.btnclear.Click += new System.EventHandler(this.btnclear_Click);
            // 
            // btnexit
            // 
            this.btnexit.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnexit.Location = new System.Drawing.Point(396, 15);
            this.btnexit.Margin = new System.Windows.Forms.Padding(15);
            this.btnexit.Name = "btnexit";
            this.btnexit.Size = new System.Drawing.Size(100, 22);
            this.btnexit.TabIndex = 15;
            this.btnexit.Text = "&Exit";
            this.btnexit.UseVisualStyleBackColor = true;
            this.btnexit.Click += new System.EventHandler(this.btnexit_Click);
            // 
            // lblerror
            // 
            this.lblerror.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblerror.Font = new System.Drawing.Font("PMingLiU", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblerror.ForeColor = System.Drawing.Color.LightCoral;
            this.lblerror.Location = new System.Drawing.Point(397, 65);
            this.lblerror.Margin = new System.Windows.Forms.Padding(15, 15, 0, 15);
            this.lblerror.Name = "lblerror";
            this.lblerror.Size = new System.Drawing.Size(114, 20);
            this.lblerror.TabIndex = 16;
            this.lblerror.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblerroryear
            // 
            this.lblerroryear.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblerroryear.Font = new System.Drawing.Font("PMingLiU", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblerroryear.ForeColor = System.Drawing.Color.LightCoral;
            this.lblerroryear.Location = new System.Drawing.Point(397, 115);
            this.lblerroryear.Margin = new System.Windows.Forms.Padding(15, 15, 0, 15);
            this.lblerroryear.Name = "lblerroryear";
            this.lblerroryear.Size = new System.Drawing.Size(114, 20);
            this.lblerroryear.TabIndex = 10001;
            this.lblerroryear.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.Controls.Add(this.btndisplay, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnttcost, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnclear, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnexit, 3, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 418);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(511, 52);
            this.tableLayoutPanel1.TabIndex = 10002;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 3;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.Controls.Add(this.label1, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.label02, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.lblerror, 2, 1);
            this.tableLayoutPanel2.Controls.Add(this.label2, 0, 3);
            this.tableLayoutPanel2.Controls.Add(this.txtyears, 1, 2);
            this.tableLayoutPanel2.Controls.Add(this.txtstarting, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.txttotcost, 1, 3);
            this.tableLayoutPanel2.Controls.Add(this.textBox1, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.lblerroryear, 2, 2);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 4;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(511, 204);
            this.tableLayoutPanel2.TabIndex = 10003;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(511, 470);
            this.Controls.Add(this.tableLayoutPanel2);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lstoutput);
            this.MinimumSize = new System.Drawing.Size(466, 425);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtstarting;
        private System.Windows.Forms.Label label02;
        private System.Windows.Forms.TextBox txtyears;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txttotcost;
        private System.Windows.Forms.ListBox lstoutput;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btndisplay;
        private System.Windows.Forms.Button btnttcost;
        private System.Windows.Forms.Button btnclear;
        private System.Windows.Forms.Button btnexit;
        private System.Windows.Forms.Label lblerror;
        private System.Windows.Forms.Label lblerroryear;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;

    }
}

