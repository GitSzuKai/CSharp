/*=========================================================
* Szu Kai Yang
* yang878@purdue.edu
* CNIT155 Lab 07
* Lab Section:   Thur 11:30
* Program Description:  Program that compute vacinated children. 
* Academic Honesty: 
*	I attest that this is my original work.
*	I have not used unauthorized source code, either modified or unmodified.
*	I have not given other fellow student(s) access to my program.
*=========================================================== */  
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab07Loop
{
    public partial class Form1 : Form
    {
        const double vacinecost = 1.5;
        public Form1()
        {
            InitializeComponent();
        }

        private void btnexit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnttcost_Click(object sender, EventArgs e)
        {
            int numberofkids;
            if (!int.TryParse(txtstarting.Text, out numberofkids) || numberofkids < 50)
            {
                MessageBox.Show("Number of kids must be a whole number and greater than or equal to 50", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtstarting.Focus();
                return;
            }

            
            int years;
            if (!int.TryParse(txtyears.Text, out years) || years < 1 || years > 10)
            {
                MessageBox.Show("Years should be whole number and within 1-10", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtyears.Focus();
                return;
            }

            int total = 0;
            int last = numberofkids;
            for (int i = 1; i<=years; i++)
            {
                total += last;
                last = (int)(last * 1.1);
            }
            txttotcost.Text = (total * vacinecost).ToString("C");
        }

        private void txtstarting_TextChanged(object sender, EventArgs e)
        {
            int numberofkids;
            lblerror.Text = "";
            if (txtstarting.Text.Length == 0 || !int.TryParse(txtstarting.Text, out numberofkids) || numberofkids < 50)
            {
                lblerror.Text = "Input Invalid";
            }
            if (txtstarting.Text.Length == 0)
            {
                lblerror.Text = "";
                return;
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {

            txtstarting.TabIndex = 0;
            
        }

        private void btnclear_Click(object sender, EventArgs e)
        {
            txtstarting.Text = "";
            txtyears.Text = "";
            txttotcost.Text = "";
            lstoutput.Items.Clear();
            txtstarting.Focus();
        }

        private void txtyears_TextChanged(object sender, EventArgs e)
        {

            int years;
            if (!int.TryParse(txtyears.Text, out years) || years < 1 || years > 10)
            {
                lblerroryear.Text = "Input Invalid";
            }
            if (txtyears.Text.Length == 0)
            {
                lblerroryear.Text = "";
                return;
            }
        }

        private void btndisplay_Click(object sender, EventArgs e)
        {
            int numberofkids;
            if (!int.TryParse(txtstarting.Text, out numberofkids) || numberofkids < 50)
            {
                MessageBox.Show("Number of kids must be a whole number and greater than or equal to 50", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtstarting.Focus();
                return;
            }


            int years;
            if (!int.TryParse(txtyears.Text, out years) || years < 1 || years > 10)
            {
                MessageBox.Show("Years should be whole number and within 1-10", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtyears.Focus();
                return;
            }
            lstoutput.Items.Clear();
            int total = 0;
            int last = numberofkids;
            for (int i = 1; i <= years; i++)
            {
                total += last;

                string txt = String.Format("{0,-25}{1,-30}{2,-25:C}{3, 18}", i, last, last * vacinecost, total);

                lstoutput.Items.Add(txt);
                
                last = (int)(last * 1.1);
            }

        }

    }
}
