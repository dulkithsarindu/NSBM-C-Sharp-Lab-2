using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SignupForm
{
    public partial class Form2 : Form
    {
        public Form2(string name,string usrname,string Email)
        {
            InitializeComponent();
            label1.Text = $"Name: {name}";
            label2.Text = $"Username: {usrname}";
            label3.Text = $"Email: {Email}";
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
