/* ----------------------------------------------------------------------------------------------------------
  Szu Kai Yang  
  yang878@purdue.edu
  CNIT155  Lab 006
  Program Description:  
                  Using loop and listbox to compute work pay 
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

namespace Lab06Loops
{
    public partial class Form1 : Form
    {
        public Form1()
        { 
            InitializeComponent();
            
        }

        private void btncompute_Click(object sender, EventArgs e)
        {
            
            if (txtfullname.Text == "")
            {
                MessageBox.Show("Please type in names", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtfullname.Focus();
                return;
            }

            int spaceposition;
            spaceposition = txtfullname.Text.IndexOf(" ");        
            if (spaceposition == -1)
            {
                MessageBox.Show("Please leave a space between first name and last name", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtfullname.Focus();
                return;
            }
            int day;
            if (int.TryParse(txtdays.Text, out day) == false)
            {
                MessageBox.Show("Please have whole numers", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtdays.Focus();
                return;
            }

            if (day < 5 || day > 30)
            {
                MessageBox.Show("The day should be within 5 and 30", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtdays.Focus();
                return;
            }

            if (!radSumofsquares.Checked && !radFactorial.Checked && !radSpecial.Checked && !radSumoddcubes.Checked && !radInverse.Checked && !radPennies.Checked)
            {
                MessageBox.Show("Select at least one payment method", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            int namelength;
            namelength = txtfullname.Text.Length;
            string firstname;
            firstname = txtfullname.Text.Substring(0, spaceposition);
            lstoutput.Items.Add(firstname);
            
            if (radSumofsquares.Checked == true)
            {
                int squareday = 0;
                for (int i =1; i<=day; i++)
                {
                    squareday = squareday + (int)Math.Pow(i, 2);
                }
                txtpay.Text = squareday.ToString("C");
            }
            else if (radFactorial.Checked == true)
            {
                int factorial = 1;
                for ( int i =1; i<=day; i++)
                {
                    if (factorial>=1000000)
                    {
                        txtpay.Text = factorial.ToString("C");
                        MessageBox.Show("Exceed on "+ (i-1) + " days","Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        break;
                        
                    }else
                    {
                        factorial = factorial * i;   
                    }
                    
                }
               
            } else if (radSumoddcubes.Checked ==true)
            {
                int sumodd = 0;
                int i = 1;
                while (i<=day)
                {
                    sumodd = sumodd + (int)Math.Pow(i, 3);
                    i+=2;
                }
                txtpay.Text = sumodd.ToString("C");
            }
            else if (radSpecial.Checked ==true)
            {
                int specialsum = 1;
                for (int i =1; i<=day;i++)
                {
                    specialsum = i * (i + 1);
                }
                txtpay.Text = specialsum.ToString("C");
            }else if (radInverse.Checked == true)
            {
                double suminverse = 0.0;
                for (double i= 1; i<=day;i++)
                {
                    suminverse = suminverse + (1 / i);

                }
                double suminverseoutput;
                suminverseoutput = suminverse * 10;
                txtpay.Text = suminverseoutput.ToString("C");
            }else if ( radPennies.Checked == true)
            {
               double penny = 0.0;
                for (double i = 0; i<day;i++)
                {
                        penny =penny + 0.01*Math.Pow(2,i);
                }
                txtpay.Text = penny.ToString("C");
            }
        }

        private void btncount_Click(object sender, EventArgs e)
        {
            int nameCount;
            nameCount = lstoutput.Items.Count;
            MessageBox.Show("There is " + nameCount + " names", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Information);
            
        }

        private void btnsort_Click(object sender, EventArgs e)
        {
            lstoutput.Sorted = true;

        }

        private void btnclear_Click(object sender, EventArgs e)
        {
            txtdays.Clear();
            txtfullname.Clear();
            txtpay.Clear();
            radSumofsquares.Checked = false;
            radFactorial.Checked = false;
            radSumoddcubes.Checked = false;
            radInverse.Checked = false;
            radPennies.Checked = false;
            radSpecial.Checked = false;
        }

        private void btnexit_Click(object sender, EventArgs e)
        {
            Close();
        }

      
    }
}
