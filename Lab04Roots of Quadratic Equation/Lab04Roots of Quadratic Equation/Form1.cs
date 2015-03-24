/*=========================================================
* Szu Kai Yang
* yang878@purdue.edu
* CNIT155 Lab03
* Lab Section:   Thur 11:30
* Program Description:  A program that compute quadratic equation. 
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

namespace Lab04Roots_of_Quadratic_Equation
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
            txtcoefficienta.Clear();
            txtcoefficientb.Clear();
            txtcoefficientc.Clear();
            txtroot.Clear();
            txtcoefficienta.Focus();
        }

        private void btncompute_Click(object sender, EventArgs e)
        {
            double coefficienta;
            double coefficientb;
            double coefficientc;
            double discriminant;
            double oneroot;
            double tworoot1;
            double tworoot2;
            bool didconvert;

            didconvert = double.TryParse(txtcoefficienta.Text, out coefficienta);

            if (didconvert == false)
            {
                MessageBox.Show("Please type numbers!","Warning",MessageBoxButtons.OK,MessageBoxIcon.Error);
                txtcoefficienta.Clear();
                txtcoefficientb.Clear();
                txtcoefficientc.Clear();
                txtcoefficienta.Focus();
                return;
            }

            coefficienta = double.Parse(txtcoefficienta.Text);
            coefficientb = double.Parse(txtcoefficientb.Text);
            coefficientc = double.Parse(txtcoefficientc.Text);

            discriminant = Math.Pow(coefficientb,2) - (4 * coefficienta * coefficientc);
            oneroot = -coefficientb / (2 * coefficienta);
            tworoot1 = (-coefficientb + Math.Sqrt(discriminant)) / (2 * coefficienta);
            tworoot2 = (-coefficientb - Math.Sqrt(discriminant)) / (2 * coefficienta);
            
            if (discriminant < 0)
            {
                txtroot.Text = "Discrminant = " + discriminant.ToString("N2") +"\r\n"
                               + "Equation has no real roots!";
            }
            else if (discriminant == 0)
            {

                txtroot.Text = "Discrminant = " + oneroot.ToString("N2") + "\r\n"
                              + "Equation has one root";
            }
            else
            {
                txtroot.Text = "Equation has 2 real roots.\r\n" +
                "Root1 = " + tworoot1.ToString("N2") + "\r\n" +
                "Root2 = " + tworoot2.ToString("N2");
            }


            

        }

        private void btnfindmax_Click(object sender, EventArgs e)
        {

            double coefficienta;
            double coefficientb;
            double coefficientc;

            coefficienta = double.Parse(txtcoefficienta.Text);
            coefficientb = double.Parse(txtcoefficientb.Text);
            coefficientc = double.Parse(txtcoefficientc.Text);

            double largestnumber = coefficienta;

            if (largestnumber < coefficientb)

                largestnumber = coefficientb;
      
            if (coefficientc > largestnumber)

                largestnumber = coefficientc;
            txtroot.Text = "Maximum is: " +　largestnumber.ToString();
         }

        private void btnsurprise_Click(object sender, EventArgs e)
        {
            if (txtcoefficienta.Text =="")
            {
                MessageBox.Show("You need to type some numbers!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            bool didconvert;
            double coefficienta;
            double coefficientb;
            double coefficientc;
            didconvert = double.TryParse(txtcoefficienta.Text, out coefficienta);
           
            if (didconvert == false)
            {
                MessageBox.Show("Please type numbers!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtcoefficienta.Clear();
                txtcoefficienta.Focus();
                return;
            }

            coefficienta = double.Parse(txtcoefficienta.Text);
            coefficientb = double.Parse(txtcoefficientb.Text);
            coefficientc = double.Parse(txtcoefficientc.Text);

            double coefficientpow = Math.Pow(coefficienta, coefficientb);

            for(int i =0; i<=coefficientc;i++)
            {
                coefficientpow++;
            }
            txtroot.Text = "The Coefficienta power of Coefficentb = " + coefficientpow.ToString();
            this.BackColor = Color.Red;
            this.textBox1.BorderStyle = BorderStyle.None;
            textBox1.BackColor = Color.SteelBlue;
        }
     }
}

