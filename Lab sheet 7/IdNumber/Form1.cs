using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace IdNumber
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int IdNumber = int.Parse(textBox1.Text);
            if (string.IsNullOrEmpty(textBox1.Text) )
            {
                MessageBox.Show("Id number cannot be empty");
            }
            try
            {
                SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\Users\User\Desktop\University\Y1Sem3\C #\Tutorial\Lab sheet 7\IdNumber\Database1.mdf"";Integrated Security=True");
                conn.Open();
                string Query = "SELECT COUNT(*) FROM Employee WHERE IdNUmber = @IdNumber";

                SqlCommand cmd = new SqlCommand(Query, conn);
                cmd.Parameters.AddWithValue("@IdNumber", IdNumber);

                int count = (int)cmd.ExecuteScalar();

                if (count > 0)
                {
                    label2.Text = $"Result: The id number {IdNumber} is found";
                }
                else
                {
                    label2.Text = $"Result: The id number {IdNumber} is not found";
                }
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error", ex.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            label2.Text = "Result:";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
