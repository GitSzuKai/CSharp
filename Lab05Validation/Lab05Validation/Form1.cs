/* ----------------------------------------------------------------------------------------------------------
  Szu Kai Yang  
  yang878@purdue.edu
  CNIT155  Lab 003
  Program Description:  
                  Write a brief description of the program in your own words.
    Academic Honesty: 
    I attest that this is my original work.
    I have not used unauthorized source code, either modified or unmodified.
    I have not given other fellow student(s) access to my program.
================================================================== */

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab05Validation
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnexit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnclear_Click(object sender, EventArgs e)
        {
            txtdepartment.Clear();
            txtgpa.Clear();
            txtid.Clear();
            txtname.Clear();
            txtoutput.Clear();
            txtname.Focus();

        }

        private void btnevaluate_Click(object sender, EventArgs e)
        {
            if (txtname.Text == "")
            {
                MessageBox.Show("Pleae type in names", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtname.Focus();
                return;
            }

            int length;
            string twozero;
            twozero = txtid.Text.Substring(0,2);

            length = txtid.Text.Length;
            if (length != 10 || twozero != "00")
            {
              
                MessageBox.Show("10 digits only and please start with 00", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtid.Focus();
                return;
               
            }
            string uppercasedepartment;
            uppercasedepartment = txtdepartment.Text.ToUpper();
            
            if (uppercasedepartment !="CGT" && uppercasedepartment != "CIT")
            {
                MessageBox.Show("Department must be CIT or CGT", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtdepartment.Focus();
                return;
            }

            double gpa;
            if (double.TryParse(txtgpa.Text, out gpa) == false || gpa<0.00 || gpa>4.00)
            {
                MessageBox.Show("GPA must be real number and should be within 0 and 4","Error",MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtgpa.Focus();
                return;
            }

            if (gpa >= 3.25)
            {
                txtoutput.Text = "Dear " + txtname.Text + Environment.NewLine
                                 + "You get a $2000 Scholarship!" + Environment.NewLine
                                 + "Congratulation!";
            }
            else if ( gpa < 3.25 && gpa>=2.80)
            {
                txtoutput.Text = "Dear " + txtname.Text + Environment.NewLine
                                 + "You get a $1000.00 Scholarship!" + Environment.NewLine
                                 + "Congratulation!";
            }

            else if ( gpa < 2.80 && gpa >= 2.25)
            {
                txtoutput.Text = "Dear " + txtname.Text + Environment.NewLine
                                 + "You get a $500 Scholarship!" + Environment.NewLine
                                 + "Congratulation!";
            }
        }
    }
}
