/*=========================================================
* Szu Kai Yang
* yang878@purdue.edu
* CNIT155 Lab02
* Lab Section:   Thur 11:30
* Program Description:  A program that shows the information of student.
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

namespace Lab02
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnfullname_Click(object sender, EventArgs e)
        {
            string firstname;
            string middleinitial;
            string lastname;
            string showfullname;

            firstname = txtfirstname.Text;
            lastname = txtlastname.Text;
            middleinitial = txtmiddleinitial.Text;

            showfullname = firstname + " " + middleinitial + ". " + lastname;
            txtoutput.Text = "Full name: " + showfullname;


        }

        private void btnemail_Click(object sender, EventArgs e)
        {
            string username;
            string email;

            username = txtusername.Text;
            email = username + "@purdue.edu";

            txtoutput.Text = "Email: " + email;
        }

        private void btndisplayall_Click(object sender, EventArgs e)
        {

            txtoutput.Text = txtfirstname.Text + " " + txtmiddleinitial.Text + ". " + txtlastname.Text + "\r\n" +
                             txtusername.Text + "@purdue.edu" + "\r\n" +
                             "(" + txtareacode.Text + ")" + txtphoneno.Text;

        }

        private void btnclear_Click(object sender, EventArgs e)
        {
            txtmiddleinitial.Clear();
            txtfirstname.Clear();
            txtlastname.Clear();
            txtoutput.Clear();
            txtphoneno.Clear();
            txtusername.Clear();
            txtareacode.Clear();
            txtfirstname.Focus();

        }

        private void btnclose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
