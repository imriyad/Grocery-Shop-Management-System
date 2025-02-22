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


namespace LoginAndRegistrationForm
{
    public partial class Registration : Form
    {
        public Registration()
        {
            InitializeComponent();
        }
        SqlConnection Con = new SqlConnection(@"Data Source=LENOVO;Initial Catalog=LoginTbl;Integrated Security=True");

        private void label4_Click(object sender, EventArgs e)
        {
            Form1 f = new Form1();
            this.Hide();
            f.Show();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void Registration_Load(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void FNameTB_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (FNameTB.Text == "" || LNameTB.Text == "" || EmailTB.Text == "" || PhoneTB.Text == "" || PasswordTB.Text == "")
            {
                MessageBox.Show("Missing Information!");
                return;
            }
            try
            {
                Con.Open();
                string query = "insert into CRegTbl values('" + FNameTB.Text + "','" + LNameTB.Text + "','" + EmailTB.Text + "','" + PhoneTB.Text + "','" + PasswordTB.Text + "')";
                SqlCommand cmd = new SqlCommand(query, Con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Registration Successfull");

                Form1 f = new Form1();
                this.Hide();
                f.Show();

                Con.Close();
                
                


                //populate();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                if (Con.State == ConnectionState.Open)
                {
                    Con.Close();
                }
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            PasswordTB.UseSystemPasswordChar = checkBox1.Checked;

        }
    }
}
