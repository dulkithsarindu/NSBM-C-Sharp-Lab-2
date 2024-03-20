using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using System.Runtime.Versioning;

namespace SignupForm
{
    public partial class Form1 : Form
    {
       
        public Form1()
        {
            InitializeComponent();
            pass.PasswordChar = '*';
            conpass.PasswordChar = '*';
           
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void signup_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(fname.Text) || string.IsNullOrEmpty(lname.Text) || string.IsNullOrEmpty(dateTimePicker1.Text) || string.IsNullOrEmpty(email.Text) || string.IsNullOrEmpty(username.Text) || string.IsNullOrEmpty(pass.Text) || string.IsNullOrEmpty(conpass.Text))
            {
                MessageBox.Show("All fields must be filled");
            }
            else
            {
                if (pass.Text == conpass.Text)
                {
                    MessageBox.Show("Signup Successful");
                    string name = fname.Text + " " + lname.Text;
                    string usrname = username.Text;
                    string Email = email.Text;

                    Form2 form = new Form2(name, usrname, Email);
                    form.Show();

                }
                else
                {
                    MessageBox.Show("Passwords should be matched");
                }
            }
        }

        private void reset_Click(object sender, EventArgs e)
        {
            fname.Text = "";
            lname.Text = "";
            dateTimePicker1.Text = "";
            email.Text = "";
            username.Text = "";
            pass.Text = "";
            conpass.Text = "";

        }
    }
}
