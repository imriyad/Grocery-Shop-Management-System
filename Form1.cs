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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        SqlConnection Con = new SqlConnection(@"Data Source=LENOVO;Initial Catalog=LoginTbl;Integrated Security=True");

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            LoginPassTB.UseSystemPasswordChar = checkBox1.Checked;

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {
            Registration re = new Registration();
            this.Hide();
            re.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(EmailTB.Text) || string.IsNullOrWhiteSpace(LoginPassTB.Text))
            {
                MessageBox.Show("Please enter both Email and Password.");
                return;
            }
            if (usertype_comboBox.SelectedIndex == -1)
            {
                MessageBox.Show("Please select a User Type.");
                return;
            }

            Con.Open();
            string query = "Select * from LoginTbl where Email ='" + EmailTB.Text + "' and Password ='" + LoginPassTB.Text + "'";

            SqlDataAdapter s = new SqlDataAdapter(query, Con);
            DataTable dt = new DataTable();
            s.Fill(dt);
            string cmbItemValue = usertype_comboBox.SelectedItem.ToString();
            if (dt.Rows.Count > 0)
            {
                bool userTypeMatch = false;
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    if (dt.Rows[i]["UserType"].ToString() == cmbItemValue)
                    {
                        userTypeMatch = true;
                        MessageBox.Show("You Logged in as " + dt.Rows[i][2]);
                        if (usertype_comboBox.SelectedIndex == 0)
                        {
                            AdminForm af = new AdminForm();
                            af.Show();
                            this.Hide();
                        }
                        else if (usertype_comboBox.SelectedIndex == 1)
                        {
                            ProductForm pf1 = new ProductForm();
                            pf1.Show();
                            this.Hide();
                        }
                        else if (usertype_comboBox.SelectedIndex == 2)
                        {
                            ManagerDashboardForm mdf = new ManagerDashboardForm();
                            mdf.Show();
                            this.Hide();
                        }
                        break;
                    }
                }
                if (!userTypeMatch)
                {
                    MessageBox.Show("Please select the correct information !!");
                }
            }
            else
            {
                MessageBox.Show("Please select the correct information !!");
            }
            Con.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void usertype_comboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {
            Registration re = new Registration();
            this.Hide();
            re.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(CEmailTB.Text) || string.IsNullOrWhiteSpace(CPasswordTB.Text))
                {
                    MessageBox.Show("Please enter both Email and Password.");
                    return;
                }
                Con.Open();
                string query = "Select Email, Password from CRegTbl where Email = @Email and Password = @Password";
                SqlCommand cmd = new SqlCommand(query, Con);
                cmd.Parameters.AddWithValue("@Email", CEmailTB.Text);
                cmd.Parameters.AddWithValue("@Password", CPasswordTB.Text);
                SqlDataAdapter s = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                s.Fill(dt);
                Con.Close();
                if (dt.Rows.Count > 0)
                {
                    ProductSellForm ps = new ProductSellForm();
                    ps.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Invalid Email or Password.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }
            finally
            {
                if (Con.State == ConnectionState.Open)
                {
                    Con.Close();
                }
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void CPasswordTB_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click_1(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            CPasswordTB.UseSystemPasswordChar =checkBox2.Checked;

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void CEmailTB_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            AboutUsForm auf = new AboutUsForm();
            this.Hide();
            auf.Show();
        }
    } 
}