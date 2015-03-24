/*=========================================================
*Szu Kai Yang
*yang878@purdue.edu
*CNIT155 Lab03
*
*Program Description:  Pizza and Drinks bill calculator
*
*Academic Honesty: 
*I attest that this is my original work.
*I have not used unauthorized source code, either modified or unmodified.
*I have not given other fellow student(s) access to my program.
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

namespace Lab03_VariableArithmetic
{
    public partial class Form1 : Form
    {
        const double pizzaprice = 10.00;
        const double drinkprice = 2.00;
        const double tax = 1.08;
        const double exchangerate = 1.1;
        
        public Form1()
        {
          
            InitializeComponent();
            
        }

        private void btncompute_Click(object sender, EventArgs e)
        {
            
            int numPizza;
            int numDrinks;
            int coupon;
            double subtotal;
            double discount;
            double priceafterDiscount;
            double priceTax;
            double priceEuro;
            
            //Text Change To number 
            numPizza = int.Parse(txtnumpizza.Text);
            numDrinks = int.Parse(txtnumdrink.Text);
            coupon = int.Parse(txtcoupon.Text);

            //Calculation
            subtotal = pizzaprice * numPizza + drinkprice * numDrinks;
            discount = (subtotal/100) * coupon;
            priceafterDiscount = subtotal - discount;
            priceTax = priceafterDiscount * tax;
            priceEuro = priceTax * exchangerate;

            //Show output
            txtsubtotal.Text = subtotal.ToString("C");
            txtdiscount.Text = discount.ToString("C");
            txtafterdiscount.Text = priceafterDiscount.ToString("C");
            txttaxtotal.Text = priceTax.ToString("C");
            txttotaleuro.Text =" \u20AC" + priceEuro.ToString("N2");

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnclear_Click(object sender, EventArgs e)
        {
            txtafterdiscount.Clear();
            txtcoupon.Clear();
            txtdiscount.Clear();
            txtnumdrink.Clear();
            txtnumpizza.Clear();
            txtsubtotal.Clear();
            txttaxtotal.Clear();
            txttotaleuro.Clear();
            txtnumpizza.Focus();
        }

        private void btnexit_Click(object sender, EventArgs e)
        {
            Close();
        }
        
        private void btnsurprise_Click(object sender, EventArgs e)
        {
            string surprisemessage = " Your order have been placed!" ;

           var result = MessageBox.Show(surprisemessage, "Confirmation", MessageBoxButtons.OKCancel);
            if (result == System.Windows.Forms.DialogResult.Cancel)
            {
                this.Close();
            }
            
            if (result == System.Windows.Forms.DialogResult.OK)
            {
                txtafterdiscount.Clear();
                txtcoupon.Clear();
                txtdiscount.Clear();
                txtnumdrink.Clear();
                txtnumpizza.Clear();
                txtsubtotal.Clear();
                txttaxtotal.Clear();
                txttotaleuro.Clear();
                txtnumpizza.Focus();
            }
        }
       
    }
}
